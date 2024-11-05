using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vigenere
{
    public class Vig
    {
        public Vig() { }

        private Cesare ce;
        

        public string CifraVigenere(string m, string key)
        {
            ce = new Cesare();
            string result = "";
            string completeKey = ""; 

            for(int i = 0; i < m.Length; i++)
            {
                completeKey += key[i % key.Length]; 
                completeKey = completeKey.ToLower();
            }
            Console.WriteLine(completeKey);
               
            for(int i = 0; i < m.Length; i++)
            {


                result += ce.CifraCesare(m[i].ToString(), (completeKey[i]) % 97);
            }


          

            return result; 
        }


        public string DecifraVigenere(string m, string key)
        {
            ce = new Cesare();
            string result = "";
            string completeKey = "";

            for (int i = 0; i < m.Length; i++)
            {
                completeKey += key[i % key.Length];
                completeKey = completeKey.ToLower();
            }
            Console.WriteLine(completeKey);

            for (int i = 0; i < m.Length; i++)
            {


                result += ce.DecifraCesare(m[i].ToString(),(completeKey[i]) % 97);
            }







            return result;
        }
    }
}
