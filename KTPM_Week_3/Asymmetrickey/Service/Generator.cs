using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Asymmetrickey.Service
{
    class Generator
    {
        
        public static RSACryptoServiceProvider generatorKeyPair()
        {
            return new RSACryptoServiceProvider(2048);
        }

        static public byte[] Encryption(byte[] Data, String publicstr, bool DoOAEPPadding)
        {
            try
            {
                byte[] encryptedData;
                using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider())
                {
                    //RSA.ImportParameters(RSAKey);
                    RSA.FromXmlString(publicstr);
                    encryptedData = RSA.Encrypt(Data, DoOAEPPadding);
                }
                return encryptedData;
            }
            catch (CryptographicException e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }

        static public byte[] Decryption(byte[] Data, String privatestr, bool DoOAEPPadding)
        {
            try
            {
                byte[] decryptedData;
                using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider())
                {
                    //RSA.ImportParameters(RSAKey);
                    RSA.FromXmlString(privatestr);
                    decryptedData = RSA.Decrypt(Data, DoOAEPPadding);
                }
                return decryptedData;
            }
            catch (CryptographicException e)
            {
                Console.WriteLine(e.ToString());
                return null;
            }
        }
    }
}
