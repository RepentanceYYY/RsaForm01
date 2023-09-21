using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace RsaForm01
{
    class RsaTools
    {
        /// <summary>
        /// 生成公钥和密钥
        /// </summary>
        /// <returns></returns>
        public static string[] createRsaKey()
        {
            string[] kes = new string[2];
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
            byte[] privateKeyBytes = rsa.ExportCspBlob(true);
            string privateKey = Convert.ToBase64String(privateKeyBytes);

            byte[] publicKeyBytes = rsa.ExportCspBlob(false);
            string publicKey = Convert.ToBase64String(publicKeyBytes);
            kes[0] = publicKey;
            kes[1] = privateKey;
            return kes;
        }

        /// <summary>
        /// 使用公钥加密，分段加密
        /// </summary>
        /// <param name="content"></param>
        /// <param name="privateKeyPath"></param>
        /// <returns></returns>
        public static string EncrytByPublic(string publickKeyBase64, string strEncryptString)
        {
            if (string.IsNullOrWhiteSpace(strEncryptString))
            {
                return null;
            }
            if (string.IsNullOrWhiteSpace(publickKeyBase64))
            {
                throw new Exception("公钥不能为空");
            }
            byte[] publicKeyByte = Convert.FromBase64String(publickKeyBase64);
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();

            rsa.ImportCspBlob(publicKeyByte);
            byte[] originalData = Encoding.UTF8.GetBytes(strEncryptString);
            if (originalData == null || originalData.Length <= 0)
            {
                throw new NotSupportedException();
            }
            if (rsa == null)
            {
                throw new ArgumentNullException();
            }
            byte[] encryContent = null;
            #region 分段加密
            int bufferSize = (rsa.KeySize / 8) - 11;
            byte[] buffer = new byte[bufferSize];
            //分段加密
            using (MemoryStream input = new MemoryStream(originalData))
            using (MemoryStream ouput = new MemoryStream())
            {
                while (true)
                {
                    int readLine = input.Read(buffer, 0, bufferSize);
                    if (readLine <= 0)
                    {
                        break;
                    }
                    byte[] temp = new byte[readLine];
                    Array.Copy(buffer, 0, temp, 0, readLine);
                    byte[] encrypt = rsa.Encrypt(temp, false);
                    ouput.Write(encrypt, 0, encrypt.Length);
                }
                encryContent = ouput.ToArray();
            }
            #endregion
            return Convert.ToBase64String(encryContent);
        }

        /// <summary>
        /// 通过私钥解密，分段解密
        /// </summary>
        /// <param name="content"></param>
        /// <param name="privateKeyPath"></param>
        /// <returns></returns>
        public static string DecryptByPrivate(string privateKeyPath, string strDecryptString)
        {
            if (string.IsNullOrWhiteSpace(strDecryptString))
            {
                return null;
            }
            if (string.IsNullOrWhiteSpace(privateKeyPath))
            {
                throw new Exception("密钥不能为空");
            }
            byte[] privateKeyByte = Convert.FromBase64String(privateKeyPath);
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
            rsa.ImportCspBlob(privateKeyByte);
            byte[] encryptData = Convert.FromBase64String(strDecryptString);
            //byte[] dencryContent = rsa.Decrypt(encryptData, false);
            byte[] dencryContent = null;
            #region 分段解密
            if (encryptData == null || encryptData.Length <= 0)
            {
                throw new NotSupportedException();
            }

            int keySize = rsa.KeySize / 8;
            byte[] buffer = new byte[keySize];

            using (MemoryStream input = new MemoryStream(encryptData))
            using (MemoryStream output = new MemoryStream())
            {
                while (true)
                {
                    int readLine = input.Read(buffer, 0, keySize);
                    if (readLine <= 0)
                    {
                        break;
                    }
                    byte[] temp = new byte[readLine];
                    Array.Copy(buffer, 0, temp, 0, readLine);
                    byte[] decrypt = rsa.Decrypt(temp, false);
                    output.Write(decrypt, 0, decrypt.Length);
                }
                dencryContent = output.ToArray();
            }
            #endregion
            return Encoding.UTF8.GetString(dencryContent);
        }
    }
}
