using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CifrarioDiCesare
{
    public class Cesare
    {
        


        public Cesare()
        {
            
            
        }
        public string CifraCesare(string m, int s)
        {
            
            for(int i = 0; i < m.Count(); i++) { 
                char l = m[i];
                string cifrata = "";
                int mod = 0; 

                if(char.IsLower(l))
                {
                    for(int j = 65; j <= 90; j++)
                    {
                        
                        if(mod > 0)
                        {
                            //qua sforo di mod numeri


                        }
                    }
                }
                else if(char.IsUpper(l))
                {
                    for (int j = 97; j <= 122; j++)
                    {

                    }
                }
                else
                {

                }
            }
        }

        public string DecifrfaCesare(string m, int s)
        {

        }

    }
}
