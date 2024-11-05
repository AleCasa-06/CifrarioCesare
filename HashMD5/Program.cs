using HashMD5;

string alfabeto = "abcdefghijklmnopqrstuvwxyz";


char[] parola = new char[5];

ha has = new ha();

for (int i = 0; i < alfabeto.Length; i++)
{
    parola[0] = alfabeto[i];

    for (int j = 0; j < alfabeto.Length; j++)
    {
        parola[1] = alfabeto[j];

        for (int k = 0; k < alfabeto.Length; k++)
        {
            parola[2] = alfabeto[k];

            for (int l = 0; l < alfabeto.Length; l++)
            {
                parola[3] = alfabeto[l];

                for (int m = 0; m < alfabeto.Length; m++)
                {
                    parola[4] = alfabeto[m];

                   
                    string combinazione = new string(parola);

                    
                    string hashCombinazione = has.CalcolaHash(combinazione);

                   
                    if (hashCombinazione == has.getHash())
                    {
                        Console.WriteLine($"La password originale è: {combinazione}");
                        return; 
                    }
                }
            }
        }
    }
}
