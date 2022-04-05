/*BONUS: Convertire le funzioni appena dichiarate in funzioni generiche, ossia funzioni che possono lavorare con array di numeri interi di lunghezza variabile,
 * ossia debbono poter funzionare sia che gli passi array di 5 elementi, sia di 6, di 7, di ... e così via.
A questo punto modificare il programma in modo che chieda all’utente quanti numeri voglia inserire, e
dopo di che questi vengono inseriti a mano dall’utente esternamente. Rieseguire il programma con l’input preso esternamente dall’utente */

//------------------- PROGRAMMA PRINCIPALE ------------------- 


//Dichiarazione dell'array e la sua lunghezza
Console.WriteLine("inserisci quanti numeri vuoi inserire: ");
int n = int.Parse(Console.ReadLine());
int[] ArrayNumerico = {n};
CaricaArray(ArrayNumerico, n);

//Stampiamo l'intero array
Console.WriteLine("Ecco il contenuto del nostro array: ");
StampaArray(ArrayNumerico,n);

//Stampa dell'array al quadrato 
int[] Numalquadrato = ElevaArrayAlQuadrato(ArrayNumerico,n);
Console.WriteLine("Ecco il nostro array al quadrato: ");
StampaArray(Numalquadrato,n);


//Verifica che l'array iniziale non sia stato modificato
Console.WriteLine("Verifichiamo che il nostro array iniziale non sia cambiato: ");
StampaArray(ArrayNumerico,n);

//Somma degli elementi del nostro array
int Sum = sommaElementiArray(ArrayNumerico,n);
Console.WriteLine("Ecco la somma dei valori del nostro array: " + Sum);

//Somma degli elementi al quadrato
int elevatoAlQuadrato = Quadrato(Sum);
Console.WriteLine("Ecco anche la somma degli elementi dell'array al quadrato: " + elevatoAlQuadrato);

//Somma di ogni elemento che è stato elevato al quadrato
int SumElementiAlQuadrato = sommaElementiArray(Numalquadrato,n);
Console.WriteLine("Ecco anche la Somma di ogni elemento che è stato elevato al quadrato: " + SumElementiAlQuadrato);


//---------------- FINE PROGRAMMA PRINCIPALE -----------------





//------------------- FUNZIONI -------------------

//Stampa il contenuto di un Array
void CaricaArray(int[] Array, int lunghezzaArray)
{
    for (int i = 0; i < lunghezzaArray; i++)
    {
        Console.WriteLine("Inserisci un numero: ");
        Array[i] = int.Parse(Console.ReadLine());
    }
}

void StampaArray(int[] Array, int lunghezzaArray)
{
    int ultimoIndiceArray = lunghezzaArray - 1;
    Console.Write("[");
    for (int i = 0; i < lunghezzaArray; i++)
    {
        if (i == ultimoIndiceArray)
        {
            Console.Write(Array[i]);
        }
        else
        {
            Console.Write(Array[i] + ", ");
        }
    }
    Console.WriteLine("]");
}

//Ritorna il quadrato di un numero
int Quadrato(int numero)
{
    int quadrato = 0;
    quadrato = numero * numero;

    return quadrato;
}

//Ritorna l'elevazione al quadrato di un array
int[] ElevaArrayAlQuadrato(int[] Array, int lunghezzaArray)
{
    int[] quadrato = (int[])Array.Clone();
    for (int i = 0; i < lunghezzaArray; i++)
    {
        quadrato[i] = Array[i] * Array[i];
    }

    return quadrato;
}

//Ritorna la somma degli elementi di un array
int sommaElementiArray(int[] Array, int lunghezzaArray)
{
    int somma = 0;
    for (int i = 0; i < lunghezzaArray; i++)
    {
        somma = somma + Array[i];
    }

    return somma;
}
//---------------- FINE FUNZIONI -----------------
