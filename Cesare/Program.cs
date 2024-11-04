

Cesare c = new Cesare();  
 
 Console.WriteLine("Inserisci il testo da cifrare:");
        string testo = Console.ReadLine();

        Console.WriteLine("Inserisci il numero di spostamenti:");
        int shift = int.Parse(Console.ReadLine());

         Console.WriteLine("cifrare o decifrare? c/d:");
         string scelta = Console.ReadLine();
         string testoCifrato = ""; 
        if(scelta[0] == 'c'){
            testoCifrato = c.CifraCesare(testo, shift);
            Console.WriteLine("Testo cifrato: " + testoCifrato);
        }
        else{
            string testoDecifrato = c.DecifraCesare(testoCifrato, shift);
            Console.WriteLine("Testo decifrato: " + testoDecifrato);
        }
        

        