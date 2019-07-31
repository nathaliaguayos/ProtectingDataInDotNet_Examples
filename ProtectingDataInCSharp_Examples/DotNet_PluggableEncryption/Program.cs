using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DotNet_PluggableEncryption
{
    class Program
    {
        public static void Main(string[] args)
        {
           
            //To show the data we must decrypt the data.
        }
        public static void EncryptData()
        {
            byte[] b = new byte[] { 0x0, 0x1, 0x2, 0x3 };

            //byte[] result = EncryptData_PluggableExample(b, new AesCryptoServiceProvider());
            byte[] result = EncryptData_PluggableExample(b, new AesCryptoServiceProvider());

            //To show the data we must decrypt the data.
        }
        public static byte[] EncryptData_PluggableExample(byte[] data, SymmetricAlgorithm alg)
        {
            //Perform input validation on input parameters

            //Encrypt the data and return the result
            MemoryStream ms = null;
            CryptoStream cs = null;

            try
            {
                ms = new MemoryStream();
                cs = new CryptoStream(ms, alg.CreateEncryptor(), CryptoStreamMode.Write);

                cs.Write(data, 0, data.Length);
                return ms.ToArray();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return null;
            }
            finally
            {
                if (cs != null) cs.Close();
                if (ms != null) ms.Close();
            }
        }
    }
}
