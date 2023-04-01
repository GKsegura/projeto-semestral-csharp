using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace ProjetoVerkoop
{
    internal class MD5
    {

        public static string returnHash(string input)
        {
            using (System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create())
            {
                return getHash(input, md5);
            }
        }

        public static bool compareHash(string input, string hash)
        {
            string pass1 = returnHash(input);

            if(verificHash(hash,pass1))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static string getHash(string input, System.Security.Cryptography.MD5 hash)
        {
            byte[] data = hash.ComputeHash(Encoding.UTF8.GetBytes(input));
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < data.Length; i++)
            {
                sb.Append(data[i].ToString("X2"));
            }
            return sb.ToString();
        }

        private static Boolean verificHash(string input, string hash)
        {
            StringComparer comparer = StringComparer.OrdinalIgnoreCase;

            if (comparer.Compare(input, hash) == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
