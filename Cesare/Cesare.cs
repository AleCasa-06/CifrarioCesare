public class Cesare{
     public  string CifraCesare(string testo, int shift)
    {
        string risultato = "";
        
        foreach (char carattere in testo)
        {
            if (char.IsLetter(carattere))
            {
                
                char offset = char.IsUpper(carattere) ? 'A' : 'a'; //capisco il range A=65 oppure a=97
                risultato += (char)((carattere - offset + shift) % 26 + offset); //il modulo mi serve per ricominciare
            }
            else
            {
                risultato += carattere; 
            }
        }
        
        return risultato;
    }

   
    public  string DecifraCesare(string testo, int shift)
    {
        return CifraCesare(testo, -shift);
    }

}