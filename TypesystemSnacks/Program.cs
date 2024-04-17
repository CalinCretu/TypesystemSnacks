using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace TypesystemSnacks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Snack 1. L’utente inserisce due numeri in successione. Il software stampa il maggiore.
            Console.WriteLine("Snack 1. L’utente inserisce due numeri in successione. Il software stampa il maggiore.");

            // Chiedo all'utente di inserire il primo numero
            Console.WriteLine("Inserisci il primo numero!");

            // Leggo il primo input e lo trasformiamo in un numero intero
            int primoNumero = int.Parse(Console.ReadLine());

            // Chiedo all'utente di inserire il secondo numero
            Console.WriteLine("Inserisci il secondo numero");

            // Leggo il secondo input e lo trasformiamo in un numero intero
            int secondoNumero = int.Parse(Console.ReadLine());

            // Verifico quale numero è maggiore tra numero1 e numero2 usando l'operatore ternario
            int maggiore = (primoNumero > secondoNumero) ? primoNumero : secondoNumero;

            // Stampo il numero maggiore
            Console.WriteLine("Il numero maggiore è: " + maggiore);



            // Snack 2. L’utente inserisce due parole in successione. Il software stampa prima la parola più corta, poi la parola più lunga.
            Console.WriteLine("Snack 2. L’utente inserisce due parole in successione. Il software stampa prima la parola più corta, poi la parola più lunga.");

            // Chiedo all'utente di inserire la prima parola
            Console.WriteLine("Inserisci la prima parola!");

            // Leggo il primo input di tipo string e lo assegno alla variabile primaParola
            string primaParola = Console.ReadLine();

            // Chiedo all'utente di inserire la seconda parola
            Console.WriteLine("Inserisci la seconda parola!");

            // Leggo il secondo input di tipo string e lo assegno alla variabile secondaParola
            string secondaParola = Console.ReadLine();

            // Verifico la lunghezza delle parole e le stampo a schermo
            if (primaParola.Length <= secondaParola.Length)
            {
                Console.WriteLine("La parola più corta è: " + primaParola);
                Console.WriteLine("La parola più lunga è: " + secondaParola);
            }
            else
            {
                Console.WriteLine("La parola più corta è: " + secondaParola);
                Console.WriteLine("La parola più lunga è: " + primaParola);
            }



            // Snack 3. Il software deve chiedere per 10 volte all’utente di inserire un numero. Il programma stampa la somma di tutti i numeri inseriti.
            Console.WriteLine("Snack 3. Il software deve chiedere per 10 volte all’utente di inserire un numero. Il programma stampa la somma di tutti i numeri inseriti.");

            // Dichiaro la variabile somma con valore = 0
            int somma = 0;

            // Ciclo for per effettuare 10 richieste all'utente
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Inserisci il numero " + (i + 1) + ":");

                // Leggo l'input dell'utente e lo converto in un numero intero
                int numero = int.Parse(Console.ReadLine());

                // Aggiungo il numero alla somma
                somma += numero;
            }

            // Stampo a schermo il risultato della somma dei 10 numeri
            Console.WriteLine("La somma dei numeri inseriti è: " + somma);



            // Snack 4. Calcola la somma e la media dei numeri da 2 a 10.
            Console.WriteLine("Snack 4. Calcola la somma e la media dei numeri da 2 a 10.");

            //Dichiaro le variabili per memorizzare la somma e la media
            int sum = 0;
            double media = 0;

            // Ciclo for per iterare da 2 a 10
            for (int i = 2; i <= 10; i++)
            {
                // Aggiunge il valore di i alla somma
                sum += i;
            }

            // Calcola la media dividendo la somma per il numero di elementi
            media = (double)sum / 9; // 9 perché ci sono 9 numeri da 2 a 10

            // Stampa la somma e la media
            Console.WriteLine($"La somma dei numeri da 2 a 10 è: {sum}");
            Console.WriteLine($"La media dei numeri da 2 a 10 è: {media:F2} ");



            // Snack 5. Il software chiede all’utente di inserire un numero. Se il numero inserito è pari, stampa il numero, se è dispari, stampa il numero successivo.
            Console.WriteLine("Il software chiede all’utente di inserire un numero. Se il numero inserito è pari, stampa il numero, se è dispari, stampa il numero successivo.");

            //Chiedo all'utente di inserire un numero
            Console.WriteLine("Inserisci un numero:");

            // Leggo l'input dell'utente e lo converto in un numero intero
            int number = int.Parse(Console.ReadLine());

            // Verifico se il numero è pari o dispari
            if (number % 2 == 0)
            {
                // nel caso il numero è pari
                Console.WriteLine("Il numero inserito è pari!");
            }
            else
            {
                // nel caso il numero è dispari
                Console.WriteLine("Il numero inserito è dispari. Il successivo è: " + (number + 1));
            }



            // Snack 6. In un array sono contenuti i nomi degli invitati alla festa del grande Gatsby. Chiedi all’utente il suo nome e comunicagli se può partecipare o meno alla festa.
            Console.WriteLine("In un array sono contenuti i nomi degli invitati alla festa del grande Gatsby. Chiedi all’utente il suo nome e comunicagli se può partecipare o meno alla festa.");

            // Creo l'array con il nome degli invitati
            string[] nomiInvitati = { "Massimo Boldi", "Christian De Sica", "Enzo Salvi", "Diego Abatantuono", "Michael Jackson di Latina" };

            // Chiedo all'utente il suo nome
            Console.WriteLine("Inserisci il tuo nome:");

            // Leggo l'input dell'utente e lo memorizzo nella variabile "nomeUtente"
            string nomeUtente = Console.ReadLine();

            // Creo la variabile booleana invitato e le do il valore false di default
            bool invitato = false;

            // Verifico se il nome dell'utente è presente nell'array degli invitati
            foreach (string nome in nomiInvitati)
            {
                if (nome.Equals(nomeUtente))
                {
                    invitato = true;
                    break;
                }
            }
            // Stampo il risultato del controllo
            if (invitato)
            {
                Console.WriteLine("Sei invitato alla festa del Grande Gatsby. Benvenuto!");
            }
            else
            {
                Console.WriteLine("Mi dispiace, non sei invitato alla festa del Grande Gatsby.");
            }



            //Snack 7. Crea un array vuoto. Chiedi per 6 volte all’utente di inserire un numero, se è dispari inseriscilo nell’array.
            Console.WriteLine("Crea un array vuoto. Chiedi per 6 volte all’utente di inserire un numero, se è dispari inseriscilo nell’array.");

            // Creao un array vuoto per memorizzare i numeri dispari
            int[] numeriDispari = new int[6];

            // Creo una variabile chiamata indice per tenere traccia della posizione nell'array
            int indice = 0;

            // Chiedo all'utente di inserire un numero 6 volte
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine("Inserisci il " + (i + 1) + "° numero" + ":");
                int numero = int.Parse(Console.ReadLine());

                // Verifica se il numero inserito è dispari
                if (numero % 2 != 0)
                {
                    // Se è dispari, lo aggiunge all'array dei numeri dispari
                    numeriDispari[indice] = numero;
                    indice++; // Incrementa l'indice per spostarsi alla prossima posizione nell'array
                }
            }
            // Stampa l'array dei numeri dispari
            Console.WriteLine("I numeri dispari inseriti sono:");
            for (int i = 0; i < indice; i++)
            {
                Console.WriteLine(numeriDispari[i]);
            }



            // Snack 8. Crea un array di numeri interi e fai la somma di tutti gli elementi che sono in posizione dispari.
            Console.WriteLine("Crea un array di numeri interi e fai la somma di tutti gli elementi che sono in posizione dispari.");

            // Creo un array di numeri interi
            int[] numeri = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };

            // Creo la variabile per memorizzare la somma degli elementi in posizione dispari
            int sommaDispari = 0;

            // Ciclo for su array numeri
            for (int i = 0; i < numeri.Length; i++)
            {
                // Verifico se l'indice è dispari
                if (i % 2 != 0)
                {
                    // Aggiungo il valore dell'elemento corrente alla somma
                    sommaDispari += numeri[i];

                    // Stampo i numeri con indice dispari
                    Console.WriteLine("I numeri con indice dispari sono:" + numeri[i]);
                }
            }

            // Stampo la somma degli elementi in posizione dispari
            Console.WriteLine("La somma degli elementi in posizione dispari è: " + sommaDispari);
        }
    }
}