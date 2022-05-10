using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;


namespace SharpXDecrypt
{
    class Program
    {
        static void Main(string[] args)
        {

             Console.WriteLine();
             Console.WriteLine("Xshell Info!");
             Console.WriteLine();
             if (args.Length == 1)
             {
                 XClass.Decrypt(args[0]);
             }
             else
             {
                 XClass.Decrypt();
             }
             Console.WriteLine("[*] read done!");
//             Console.ReadKey();

        }
    }   
}
