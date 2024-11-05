using Vigenere;

Vig v = new Vig();

Console.WriteLine("Inserisci il testo:");
string testo = Console.ReadLine();

Console.WriteLine("Inserisci la chiave:");
string key = Console.ReadLine();

Console.WriteLine("cifrare o decifrare? c/d:");
string scelta = Console.ReadLine();
string testoCifrato = "";
string testoDecifrato = ""; 

    if (scelta[0] == 'c')
    {
        testoCifrato = v.CifraVigenere(testo, key);
        Console.WriteLine("Testo cifrato: " + testoCifrato);
    }
    else
    {
        testoDecifrato = v.DecifraVigenere(testo, key);
        Console.WriteLine("Testo decifrato: " + testoDecifrato);
    }