﻿//The following Copyright applies to the LitDev Extension for Small Basic and files in the namespace LitDev.
//Copyright (C) <2011 - 2015> litdev@hotmail.co.uk
//This file is part of the LitDev Extension for Small Basic.

//LitDev Extension is free software: you can redistribute it and/or modify
//it under the terms of the GNU General Public License as published by
//the Free Software Foundation, either version 3 of the License, or
//(at your option) any later version.

//LitDev Extension is distributed in the hope that it will be useful,
//but WITHOUT ANY WARRANTY; without even the implied warranty of
//MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//GNU General Public License for more details.

//You should have received a copy of the GNU General Public License
//along with menu.  If not, see <http://www.gnu.org/licenses/>.

using Microsoft.SmallBasic.Library;
using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace LitDev
{
    static class StringEncryption
    {
        public static int KeyLengthBits = 256; //AES Key Length in bits
        public static int SaltLength = 8; //Salt length in bytes
        public static int IterationCount = 2000; //Passkey iterations
        private static RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();

        public static string DecryptString(string ciphertext, string passphrase)
        {
            try
            {
                var inputs = ciphertext.Split(":".ToCharArray(), 3);
                var iv = Convert.FromBase64String(inputs[0]); // Extract the IV
                var salt = Convert.FromBase64String(inputs[1]); // Extract the salt
                var ciphertextBytes = Convert.FromBase64String(inputs[2]); // Extract the ciphertext

                // Derive the key from the supplied passphrase and extracted salt
                byte[] key = DeriveKeyFromPassphrase(passphrase, salt);

                // Decrypt
                byte[] plaintext = DoCryptoOperation(ciphertextBytes, key, iv, false);

                // Return the decrypted string
                return Encoding.UTF8.GetString(plaintext);
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
            return "";
        }

        public static string EncryptString(string plaintext, string passphrase)
        {
            try
            {
                var salt = GenerateRandomBytes(SaltLength); // Random salt
                var iv = GenerateRandomBytes(16); // AES is always a 128-bit block size
                var key = DeriveKeyFromPassphrase(passphrase, salt); // Derive the key from the passphrase

                // Encrypt
                var ciphertext = DoCryptoOperation(Encoding.UTF8.GetBytes(plaintext), key, iv, true);

                // Return the formatted string
                return String.Format("{0}:{1}:{2}", Convert.ToBase64String(iv), Convert.ToBase64String(salt), Convert.ToBase64String(ciphertext));
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
            return "";
        }

        private static byte[] DeriveKeyFromPassphrase(string passphrase, byte[] salt)
        {
            var keyDerivationFunction = new Rfc2898DeriveBytes(passphrase, salt, IterationCount);  //PBKDF2

            return keyDerivationFunction.GetBytes(KeyLengthBits / 8);
        }

        private static byte[] GenerateRandomBytes(int lengthBytes)
        {
            var bytes = new byte[lengthBytes];
            rng.GetBytes(bytes);

            return bytes;
        }

        private static byte[] DoCryptoOperation(byte[] inputData, byte[] key, byte[] iv, bool encrypt)
        {
            byte[] output;

            using (var aes = new AesCryptoServiceProvider())
            using (var ms = new MemoryStream())
            {
                var cryptoTransform = encrypt ? aes.CreateEncryptor(key, iv) : aes.CreateDecryptor(key, iv);

                try
                {
                    using (var cs = new CryptoStream(ms, cryptoTransform, CryptoStreamMode.Write))
                    {
                        cs.Write(inputData, 0, inputData.Length);
                    }
                    output = ms.ToArray();
                }
                catch
                {
                    output = new byte[0];
                }
            }

            return output;
        }

        public static string CalculateMD5Hash(string input)
        {
            try
            {
                MD5 md5 = MD5.Create();
                byte[] inputBytes = Encoding.UTF8.GetBytes(input);
                byte[] hash = md5.ComputeHash(inputBytes);
                return HexString(hash);
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
            return "";
        }

        public static string CalculateMD5HashFile(string fileName)
        {
            try
            {
                MD5 md5 = MD5.Create();
                byte[] inputBytes = System.IO.File.ReadAllBytes(fileName);
                byte[] hash = md5.ComputeHash(inputBytes);
                return HexString(hash);
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
            return "";
        }

		public static string CalculateSHA512HashFile(string fileName)
		{
			try
			{
				SHA512 sha512 = SHA512.Create();
				byte[] inputBytes = System.IO.File.ReadAllBytes(fileName);
				byte[] hash = sha512.ComputeHash(inputBytes);
				return HexString(hash);
			}
			catch (Exception ex)
			{
				Utilities.OnError(Utilities.GetCurrentMethod(), ex);
			}
			return "";
		}

        public static string CalculateSHA512Hash(string input)
        {
            try
            {
                SHA512 sha512 = SHA512.Create();
                byte[] inputBytes = Encoding.UTF8.GetBytes(input);
                byte[] hash = sha512.ComputeHash(inputBytes);
                return HexString(hash);

            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
            return "";
        }

        private static string HexString(byte[] bytes)
        {
            StringBuilder sBuilder = new StringBuilder();
            for (int i = 0; i < bytes.Length; i++)
            {
                sBuilder.Append(bytes[i].ToString("x2"));
            }
            return sBuilder.ToString();
        }
    }

    /// <summary>
    /// Encryption and hash methods.
    /// </summary>
    [SmallBasicType]
    public static class LDEncryption
    {
        private static UTF8Encoding ByteConverter = new UTF8Encoding();
        private static RSACryptoServiceProvider RSA = new RSACryptoServiceProvider();
        private static SHA512CryptoServiceProvider sha512 = new SHA512CryptoServiceProvider();

        /// <summary>
        /// Encrypt an RSA message.  
        /// Requires a Public key to be set (Anyone can encrypt with public key).
        /// If no key is set then one created for this session is used.
        /// </summary>
        /// <param name="unencrypted">The message to encrypt.</param>
        /// <returns>The encrypted message.</returns>
        public static Primitive RSAEncrypt(Primitive unencrypted)
        {
            try
            {
                byte[] plaintext = ByteConverter.GetBytes(unencrypted);
                byte[] encryptedtext = RSA.Encrypt(plaintext, false);
                return Convert.ToBase64String(encryptedtext);
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                return "";
            }
        }

        /// <summary>
        /// Decrpyt an RSA message.  
        /// Requires a Private key to be set (Only originator can decrypt with private key).
        /// If no key is set then one created for this session is used.
        /// </summary>
        /// <param name="encrypted">The encypted message.</param>
        /// <returns>The unencrypted message.</returns>
        public static Primitive RSADecrypt(Primitive encrypted)
        {
            try
            {
                byte[] encryptedtext = Convert.FromBase64String(encrypted);
                byte[] plaintext = RSA.Decrypt(encryptedtext, false);
                return ByteConverter.GetString(plaintext);
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                return "";
            }
        }

        /// <summary>
        /// Sign an RSA message.  
        /// Requires a Private key to be set (Only originator can sign with private key).
        /// If no key is set then one created for this session is used.
        /// </summary>
        /// <param name="data">The message to sign.</param>
        /// <returns>The signing for the message.</returns>
        public static Primitive RSASign(Primitive data)
        {
            try
            {
                byte[] plaindata = ByteConverter.GetBytes(data);
                byte[] signdata = RSA.SignData(plaindata, sha512);
                return Convert.ToBase64String(signdata);
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                return "";
            }
        }

        /// <summary>
        /// Verify a signed RSA message.  
        /// Requires a Public key to be set (Anyone can verify with public key).
        /// If no key is set then one created for this session is used.
        /// </summary>
        /// <param name="data">The message that was signed.</param>
        /// <param name="sign">The signing for the message.</param>
        /// <returns>"True" or "False".</returns>
        public static Primitive RSAVerify(Primitive data, Primitive sign)
        {
            try
            {
                byte[] plaindata = ByteConverter.GetBytes(data);
                byte[] signdata = Convert.FromBase64String(sign);
                return RSA.VerifyData(plaindata, sha512, signdata);
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                return "";
            }
        }

        /// <summary>
        /// Randomly reset the private and public keys
        /// </summary>
        public static void RSAReset()
        {
            RSA = new RSACryptoServiceProvider();
        }

        /// <summary>
        /// Get or set a public RSA key.
        /// </summary>
        public static Primitive RSAPublicKey
        {
            get { return RSA.ToXmlString(false); }
            set { RSA.FromXmlString(value); }
        }

        /// <summary>
        /// Get or set a private RSA key.
        /// </summary>
        public static Primitive RSAPrivateKey
        {
            get { return RSA.ToXmlString(true); }
            set { RSA.FromXmlString(value); }
        }

        /// <summary>
        /// Encrypt some text using AES encryption and a password key.
        /// The encrypted text can be saved to a file.
        /// Note that if you forget the password there is NO WAY to decrypt!
        /// </summary>
        /// <param name="source">The text to encrypt.</param>
        /// <param name="password">The password key for the encryption.</param>
        /// <returns>The encrypted text (cypher).</returns>
        public static Primitive AESEncrypt(Primitive source, Primitive password)
        {
            return StringEncryption.EncryptString(source, password);
        }

        /// <summary>
        /// Decrypt an AES encrypted cypher (previously encrypted) using a password key.
        /// </summary>
        /// <param name="cypher">The encrypted text (cypher).</param>
        /// <param name="password">The password key for the encryption.</param>
        /// <returns>The original unencrypted text or "" if password and cypher don't match.</returns>
        public static Primitive AESDecrypt(Primitive cypher, Primitive password)
        {
            return StringEncryption.DecryptString(cypher, password);
        }

        /// <summary>
        /// Create an MD5 hash of a text input (http://wikipedia.org/wiki/MD5).
        /// This 32 character hash is recommended where a general or shorter hash is required (password or data integrity).
        /// </summary>
        /// <param name="text">A text or password to create a hash.</param>
        /// <returns>The 32 character hex MD5 Hash.</returns>
        public static Primitive MD5Hash(Primitive text)
        {
            return StringEncryption.CalculateMD5Hash(text);
        }

        /// <summary>
        /// Create an MD5 hash of a file.
        /// This 32 character hash is for file data integrity checks (e.g. a file contents is unchanged).
        /// </summary>
        /// <param name="fileName">The full path to a file to get the hash.</param>
        /// <returns>The 32 character hex MD5 Hash.</returns>
        public static Primitive MD5HashFile(Primitive fileName)
        {
            if (!System.IO.File.Exists(fileName))
            {
                Utilities.OnFileError(Utilities.GetCurrentMethod(), fileName);
                return "";
            }
            return StringEncryption.CalculateMD5HashFile(fileName);
        }

        /// <summary>
        /// Create a SHA2-512 hash of a text input.
        /// This 128 character hash is recommended for the most secure password encryption.
        /// </summary>
        /// <param name="password">A text to create a hash (often a password).</param>
        /// <returns>The 128 character hex SHA512 Hash.</returns>
        public static Primitive SHA512Hash(Primitive password)
        {
            return StringEncryption.CalculateSHA512Hash(password);
        }

        /// <summary>
        /// Create an SHA512 hash of a file.
        /// This 128 character hash is for file data integrity checks (e.g. a file contents is unchanged).
        /// </summary>
        /// <param name="fileName">The full path to a file to get the hash.</param>
        /// <returns>The 128 character hex SHA512 Hash.</returns>
        public static Primitive SHA512HashFile(Primitive fileName)
        {
            if (!System.IO.File.Exists(fileName))
            {
                Utilities.OnFileError(Utilities.GetCurrentMethod(), fileName);
                return "";
            }
            return StringEncryption.CalculateSHA512HashFile(fileName);
        }
    }
}
