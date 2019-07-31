using System;
using System.Security.Cryptography;

namespace DotNet_ProtectedMemory
{
    class Program
    {
        static void Main(string[] args)
        {
            RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
            byte[] Data = new byte[16];
            rng.GetBytes(Data);
            Console.WriteLine("[Original Data]");
            Console.WriteLine("{0}\n", BitConverter.ToString(Data));
            /*Protect the data using DPAPI with context of current user, which means
             only the current user can call unprotect successfully on the encrypted data*/
            ProtectedMemory.Protect(Data, MemoryProtectionScope.SameLogon);
            Console.WriteLine("[Protected Data]");
            Console.WriteLine("{0}\n",BitConverter.ToString(Data));
            /*Unprotect the data using DPAPI with context of current user*/
            ProtectedMemory.Unprotect(Data, MemoryProtectionScope.SameLogon);
            Console.WriteLine("[Unprotected Data]");
            Console.WriteLine("{0}\n",BitConverter.ToString(Data));
            Console.Read();

        }
    }
}
