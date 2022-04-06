/*In questo esercizio vi chiedo di definire qualche funzione di utilità che poi potete usare per poter fare operazioni complesse nei vostri programma principale.
Scrivete nel vostro programma principale Program.cs le seguenti funzioni di base:
void StampaArray(int[] array): che preso un array di numeri interi, stampa a video il contenuto dell’array in questa forma “[elemento 1, elemento 2, elemento 3, ...]
”. Potete prendere quella fatta in classe questa mattina :faccia_leggermente_sorridente:
int Quadrato(int numero): che vi restituisca il quadrato del numero passato come parametro.
int[] ElevaArrayAlQuadrato(int[] array): che preso un array di numeri interi, restituisca un nuovo array con tutti gli elementi elevati quadrato. Attenzione:
è importante restituire un nuovo array, e non modificare l’array come parametro della funzione! Vi ricordate perchè? Pensateci (vedi slide)
int sommaElementiArray(int[] array): che preso un array di numeri interi, restituisca la somma totale di tutti gli elementi dell’array.
Una volta completate queste funzioni di utilità di base, e dato il seguente array di numeri [2, 6, 7, 5, 3, 9] già dichiarato nel vostro codice,
si vogliono utilizzare le funzioni per:
Stampare l’array di numeri fornito a video
Stampare l’array di numeri fornito a video, dove ogni numero è stato prima elevato al quadrato (Verificare che l’array originale non sia stato modificato,
ristampo nuovamente l’array originale e verificando che sia rimasto [2, 6, 7, 5, 3, 9])
Stampare la somma di tutti i numeri
Stampare la somma di tutti i numeri elevati al quadrati */

//------------------- PROGRAMMA PRINCIPALE ------------------- 


//Dichiarazione dell'array
int[] ArrayNumerico = { 2, 6, 7, 5, 3, 9 };

//Stampiamo l'intero array
Console.WriteLine("Ecco il contenuto del nostro array: ");
StampaArray(ArrayNumerico);

//Stampa dell'array al quadrato
int[] Numalquadrato = ElevaArrayAlQuadrato(ArrayNumerico);
Console.WriteLine("Ecco il nostro array al quadrato: ");
StampaArray(Numalquadrato);


//Verifica che l'array iniziale non sia stato modificato
Console.WriteLine("Verifichiamo che il nostro array iniziale non sia cambiato: ");
StampaArray(ArrayNumerico);

//Somma degli elementi del nostro array
int Sum = sommaElementiArray(ArrayNumerico);
Console.WriteLine("Ecco la somma dei valori del nostro array: " + Sum);

//Somma degli elementi al quadrato
int elevatoAlQuadrato = Quadrato(Sum);
Console.WriteLine("Ecco anche la somma degli elementi dell'array al quadrato: " + elevatoAlQuadrato);

//Somma di ogni elemento che è stato elevato al quadrato
int SumElementiAlQuadrato = sommaElementiArray(Numalquadrato);
Console.WriteLine("Ecco anche la Somma di ogni elemento che è stato elevato al quadrato: " + SumElementiAlQuadrato);


//---------------- FINE PROGRAMMA PRINCIPALE -----------------





//------------------- FUNZIONI -------------------

//Stampa il contenuto di un Array
void StampaArray(int[] array)
{
    int ultimoIndiceArray = array.Length - 1;
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i == ultimoIndiceArray)
        {
            Console.Write(array[i]);
        }
        else
        {
            Console.Write(array[i] + ", ");
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
int[] ElevaArrayAlQuadrato(int[] array)
{
    int[] quadrato = (int[])array.Clone();
    for (int i = 0; i < quadrato.Length; i++)
    {
        quadrato[i] = array[i] * array[i];
    }

    return quadrato;
}

//Ritorna la somma degli elementi di un array
int sommaElementiArray(int[] array)
{
    int somma = 0;
    for (int i = 0; i < array.Length; i++)
    {
        somma = somma + array[i]; 
    }

        return somma;
}
//---------------- FINE FUNZIONI -----------------