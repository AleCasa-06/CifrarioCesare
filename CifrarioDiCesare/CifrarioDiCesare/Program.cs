
using CifrarioDiCesare;

Console.WriteLine("Benvenuto nel cifrario di cesare");
Cesare c = new Cesare();


Console.WriteLine("Inserisci un messaggio: ");
string message = Console.ReadLine();

Console.WriteLine("Inserisci la chiave di spostamento: ");
int n = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("Vuoi criptare o decriptare? (c/d): ");
char scelta = Convert.ToChar( Console.ReadLine());


switch (scelta)
{
    case 'c':
        c.CifraCesare(message, n); 
        break;

    case 'd':

        c.DecifrfaCesare(message, n);
        break; 
}