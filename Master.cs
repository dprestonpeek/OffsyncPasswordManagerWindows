using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace OffSyncPasswordManager
{
    class Master
    {
        public static string[] KeyData 
        {
            get
            {
                return new string[5] { Key, IV, KeySalt, AuthKeySalt, AuthKey };
            } 
            set 
            {
                Key = value[0];
                IV = value[1];
                KeySalt = value[2];
                AuthKeySalt = value[3];
                AuthKey = value[4];
            }
        }
        public static string Key = "";
        public static string IV = "";
        public static string KeySalt = "";
        public static string AuthKeySalt = "";
        public static string AuthKey = "";

        public static string PlainKey = "";

        private static string keyFile = "encryptedKey.txt";
        private static string pwordsFile = "encryptedStrings.txt";

        public static void InitializeMasterKeyData()
        {
            try
            {
                KeyData = RetrieveMasterKeyDataIfCorrect();
                Key = KeyData[0];
            }
            catch (Exception e)
            {
                string[] encryptedData = AesEncryption.EncryptString(Key, GenerateMasterKeyKey());
                KeyData = new string[5] { Key, encryptedData[1], encryptedData[2], encryptedData[3], encryptedData[4] };
                File.WriteAllLines(keyFile, encryptedData);
            }
        }

        public static bool KeyExists()
        {
            if (File.Exists(keyFile))
            {
                string[] storedData = File.ReadAllLines(keyFile);
                string storedKey = storedData[0];

                if (storedKey.Equals(""))
                {
                    return false;
                }
                return true;
            }
            else
            {
                File.WriteAllLines(keyFile, KeyData);
                File.WriteAllLines(pwordsFile, new string[0]);
                return false;
            }
        }

        public static string[] RetrieveMasterKeyDataIfCorrect()
        {
            string[] storedData = File.ReadAllLines(keyFile);
            string storedKey = storedData[0];
            string decryptedKey = AesEncryption.DecryptToString(Convert.FromBase64String(storedKey), GenerateMasterKeyKey(), storedData[1], storedData[2], storedData[3], storedData[4]);

            if (decryptedKey.Equals(Key))
            {
                return new string[5] { decryptedKey, storedData[1], storedData[2], storedData[3], storedData[4] };
            }
            return new string[0];
        }

        public static bool KeyCorrect()
        {
            string[] storedData = File.ReadAllLines(keyFile);
            string storedKey = storedData[0];
            string storedIv = storedData[1];
            string storedKeySalt = storedData[2];
            string storedAuthKeySalt = storedData[3];
            string storedAuthKey = storedData[4];
            string decryptedKey = AesEncryption.DecryptToString(Convert.FromBase64String(storedKey), GenerateMasterKeyKey(), storedIv, storedKeySalt, storedAuthKeySalt, storedAuthKey);

            return KeyMatches(decryptedKey);
        }

        public static bool KeyMatches(string toMatch)
        {
            if (toMatch != null)
            {
                if (toMatch.Equals(Key))
                {
                    return true;
                }
            }
            return false;
        }

        public static bool KeyDataNotEmpty()
        {
            foreach (string line in KeyData)
            {
                if (line.Equals(""))
                {
                    return false;
                }
            }
            return true;
        }

        public static string[] EncryptAndSaveMasterKey()
        {
            if (KeyDataNotEmpty())
            {
                string[] encryptedMasterKey = AesEncryption.EncryptString(Key, GenerateMasterKeyKey(), KeyData[1], KeyData[2], KeyData[3], KeyData[4]);
                File.WriteAllLines(keyFile, encryptedMasterKey);
                return encryptedMasterKey;
            }
            InitializeMasterKeyData();
            return new string[5] { Key, KeyData[1], KeyData[2], KeyData[3], KeyData[4] };
        }

        public static void ChangeMasterKey(string newKey)
        {
            Key = newKey;
            EncryptAndSaveMasterKey();
        }

        private static string DecryptMasterKey(string encryptedKey)
        {
            if (KeyCorrect() && KeyDataNotEmpty())
            {
                string decryptedMasterKey = AesEncryption.DecryptToString(Convert.FromBase64String(encryptedKey), GenerateMasterKeyKey(), IV, KeySalt, AuthKeySalt, AuthKey);
                return decryptedMasterKey;
            }
            return "";
        }

        public static string GenerateMasterKeyKey()
        {
            int initLength = Key.Length;
            string rmdr = Key.Substring(Key.Length - Key.Length % 5);
            string MasterKeyKey = "";

            for (int i = 4; i < initLength; i += 5)
            {
                MasterKeyKey += Key.Substring(i - 4, 5);
                MasterKeyKey += "|";
            }
            MasterKeyKey += rmdr;
            return MasterKeyKey;
        }
    }
}
