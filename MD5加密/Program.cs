using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MD5加密
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = GetMD5("123");
            Console.WriteLine(str);
            Console.ReadKey();
        }

        public static string GetMD5(string str)
        {
            MD5 md5 = MD5.Create();
            byte[] buffer = Encoding.Default.GetBytes(str);
            byte[] md5Buffer = md5.ComputeHash(buffer);
            string temp = "";
            for (int i = 0; i < md5Buffer.Length; i++)
            {
                temp += md5Buffer[i].ToString("x2");
            }
            return temp;
        }

    }
}
