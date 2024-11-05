using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace HashMD5
{
    public class ha
    {
        private string hash; 

        public string getHash()
        {
            return hash; 
        }

        public ha() {
            hash = "5d41402abc4b2a76b9719d911017c592"; 
        }   

        public string CalcolaHash(string input)
        {
            using (MD5 md5 = MD5.Create())
            {
                byte[] inputBytes = Encoding.ASCII.GetBytes(input);
                byte[] hashBytes = md5.ComputeHash(inputBytes);
                StringBuilder sb = new StringBuilder();
                foreach (byte b in hashBytes)
                {
                    sb.Append(b.ToString("x2"));  // Converte in formato esadecimale
                }
                return sb.ToString();
            }
        }
    }
}
