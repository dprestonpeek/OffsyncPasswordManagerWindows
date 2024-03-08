//using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace OffSyncPasswordManager
{
    class AesEncryption
    {
        private const int AesBlockByteSize = 128 / 8;

        private const int PasswordSaltByteSize = 128 / 8;
        private const int PasswordByteSize = 256 / 8;
        private const int PasswordIterationCount = 100_000;

        private const int SignatureByteSize = 256 / 8;

        private const int MinimumEncryptedMessageByteSize =
            PasswordSaltByteSize + // auth salt
            PasswordSaltByteSize + // key salt
            AesBlockByteSize + // IV
            AesBlockByteSize + // cipher text min length
            SignatureByteSize; // signature tag

        private static readonly Encoding StringEncoding = Encoding.UTF8;
        private static readonly RandomNumberGenerator Random = RandomNumberGenerator.Create();

        public static string[] EncryptString(string toEncrypt, string password)
        {
            var iv = Convert.ToBase64String(GenerateRandomBytes(AesBlockByteSize));
            var keySalt = Convert.ToBase64String(GenerateRandomBytes(PasswordSaltByteSize));
            var authKeySalt = Convert.ToBase64String(GenerateRandomBytes(PasswordSaltByteSize));
            var authKey = Convert.ToBase64String(GetKey(password, Convert.FromBase64String(authKeySalt)));

            return EncryptString(toEncrypt, password, iv, keySalt, authKeySalt, authKey);
        }

        public static string[] EncryptString(string toEncrypt, string password, string ivStr, string keySaltStr, string authKeySaltStr, string authKeyStr)
        {
            // encrypt
            var keySalt = Convert.FromBase64String(keySaltStr);
            var key = GetKey(password, keySalt);
            var iv = Convert.FromBase64String(ivStr);

            byte[] cipherText;
            using (var aes = CreateAes())
            using (var encryptor = aes.CreateEncryptor(key, iv))
            {
                var plainText = StringEncoding.GetBytes(toEncrypt);
                cipherText = encryptor
                    .TransformFinalBlock(plainText, 0, plainText.Length);
            }

            // sign
            var authKeySalt = Convert.FromBase64String(authKeySaltStr);
            var authKey = GetKey(password, authKeySalt);

            var result = MergeArrays(
                additionalCapacity: SignatureByteSize,
                authKeySalt, keySalt, iv, cipherText);

            var signatureTag = new byte[0];
            using (var hmac = new HMACSHA256(authKey))
            {
                var payloadToSignLength = result.Length - SignatureByteSize;
                signatureTag = hmac.ComputeHash(result, 0, payloadToSignLength);
                signatureTag.CopyTo(result, payloadToSignLength);
            }

            string strResult = Convert.ToBase64String(result);
            string strIV = Convert.ToBase64String(iv);
            string strKeySalt = Convert.ToBase64String(keySalt);
            string strAuthKeySalt = Convert.ToBase64String(authKeySalt);
            string strAuthKey = Convert.ToBase64String(authKey);

            return new string[5] { strResult, strIV, strKeySalt, strAuthKeySalt, strAuthKey };
        }

        public static string DecryptToString(byte[] encryptedData, string password)
        {
            var authKeySalt = encryptedData
                .AsSpan(0, PasswordSaltByteSize).ToArray();
            var keySalt = encryptedData
                .AsSpan(PasswordSaltByteSize, PasswordSaltByteSize).ToArray();
            var iv = encryptedData
                .AsSpan(2 * PasswordSaltByteSize, AesBlockByteSize).ToArray();
            var signatureTag = encryptedData
                .AsSpan(encryptedData.Length - SignatureByteSize, SignatureByteSize).ToArray();
            var authKey = GetKey(password, authKeySalt);

            string ivStr = Convert.ToBase64String(iv);
            string keySaltStr = Convert.ToBase64String(keySalt);
            string authKeySaltStr = Convert.ToBase64String(authKeySalt);
            string authKeyStr = Convert.ToBase64String(authKey);

            return DecryptToString(encryptedData, password, ivStr, keySaltStr, authKeySaltStr, authKeyStr);
        }

        public static string DecryptToString(byte[] encryptedData, string password, string ivStr, string keySaltStr, string authKeySaltStr, string authKeyStr)
        {
            if (encryptedData is null
                || encryptedData.Length < MinimumEncryptedMessageByteSize)
            {
                throw new ArgumentException("Invalid length of encrypted data");
            }

            var authKeySalt = Convert.FromBase64String(authKeySaltStr);
            var keySalt = Convert.FromBase64String(keySaltStr);
            var iv = Convert.FromBase64String(ivStr);
            var signatureTag = encryptedData
                .AsSpan(encryptedData.Length - SignatureByteSize, SignatureByteSize).ToArray();

            var cipherTextIndex = authKeySalt.Length + keySalt.Length + iv.Length;
            var cipherTextLength =
                encryptedData.Length - cipherTextIndex - signatureTag.Length;

            var authKey = Convert.FromBase64String(authKeyStr);
            var key = GetKey(password, keySalt);

            // verify signature
            using (var hmac = new HMACSHA256(authKey))
            {
                var payloadToSignLength = encryptedData.Length - SignatureByteSize;
                var signatureTagExpected = hmac
                    .ComputeHash(encryptedData, 0, payloadToSignLength);

                // constant time checking to prevent timing attacks
                var signatureVerificationResult = 0;
                for (int i = 0; i < signatureTag.Length; i++)
                {
                    signatureVerificationResult |= signatureTag[i] ^ signatureTagExpected[i];
                }

                if (signatureVerificationResult != 0)
                {
                    throw new CryptographicException("Invalid signature");
                }
            }

            // decrypt
            using (var aes = CreateAes())
            {
                using (var encryptor = aes.CreateDecryptor(key, iv))
                {
                    try
                    {
                        var decryptedBytes = encryptor
                            .TransformFinalBlock(encryptedData, cipherTextIndex, cipherTextLength);
                        return StringEncoding.GetString(decryptedBytes);
                    }
                    catch(Exception ex)
                    {
                        return null;
                    }
                }
            }
        }

        private static Aes CreateAes()
        {
            var aes = Aes.Create();
            aes.Mode = CipherMode.CBC;
            aes.Padding = PaddingMode.PKCS7;
            return aes;
        }

        private static byte[] GetKey(string password, byte[] passwordSalt)
        {
            var keyBytes = StringEncoding.GetBytes(password);

            using (var derivator = new Rfc2898DeriveBytes(
                keyBytes, passwordSalt,
                PasswordIterationCount, HashAlgorithmName.SHA256))
            {
                return derivator.GetBytes(PasswordByteSize);
            }

            //byte[] derivator = KeyDerivation.Pbkdf2(
            //    password, passwordSalt, KeyDerivationPrf.HMACSHA256,
            //    PasswordIterationCount, PasswordByteSize);
            //return derivator;
        }

        private static byte[] GenerateRandomBytes(int numberOfBytes)
        {
            var randomBytes = new byte[numberOfBytes];
            Random.GetBytes(randomBytes);
            return randomBytes;
        }

        private static byte[] MergeArrays(int additionalCapacity = 0, params byte[][] arrays)
        {
            var merged = new byte[arrays.Sum(a => a.Length) + additionalCapacity];
            var mergeIndex = 0;
            for (int i = 0; i < arrays.GetLength(0); i++)
            {
                arrays[i].CopyTo(merged, mergeIndex);
                mergeIndex += arrays[i].Length;
            }

            return merged;
        }

        // converts password to 128 bit hash
        private static byte[] GetKey(string password)
        {
            var keyBytes = Encoding.UTF8.GetBytes(password);
            using (var md5 = MD5.Create())
            {
                return md5.ComputeHash(keyBytes);
            }
        }
    }
}
