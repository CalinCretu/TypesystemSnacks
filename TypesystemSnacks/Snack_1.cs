using System;

namespace TypesystemSnacks
{
    internal class Snack_1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Snack 1. L’utente inserisce due numeri in successione. Il software stampa il maggiore.");

            // Chiedo all'utente di inserire il primo numero
            Console.WriteLine("Inserisci il primo numero");

            // Leggiamo il primo input e lo trasformiamo in un numero intero
            int primoNumero = int.Parse(Console.ReadLine());

            // Chiedo all'utente di inserire il secondo numero
            Console.WriteLine("Inserisci il secondo numero");

            // Leggiamo il secondo input e lo trasformiamo in un numero intero
            int secondoNumero = int.Parse(Console.ReadLine());

            // Verifica quale numero è maggiore tra numero1 e numero2 usando l'operatore ternario
            int maggiore = (primoNumero > secondoNumero) ? primoNumero : secondoNumero;

            // Stampa il numero maggiore
            Console.WriteLine("Il numero maggiore è: " + maggiore);
        }
    }
}