Console.Clear();
string again = "a";
// .ToLower() převede vstup na malá písmena, takže program bude pokračovat při zadávání "a" tak i "A"
while(again.ToLower() == "a" )
{
    Console.WriteLine();
    Console.Clear();
    Console.WriteLine("******************************************");
    Console.WriteLine("**** Generátor pseudonáhodných čísel *****");
    Console.WriteLine("******************************************");
    Console.WriteLine("************** Jan Havlíček ***************");
    Console.WriteLine("******************************************");
    Console.WriteLine("******************************************");

    // Vstup pro počet generovaných čísel
    Console.Write("Zadejte počet generovaných (kladné celé číslo): ");
    int n;
    while(!int.TryParse(Console.ReadLine(), out n) || n<=0 )
    {
        Console.Write("Nezadali jste celé kladné celé číslo! Zadejte počet čísel znovu: ");
    }

    // Vstup pro dolní mez
    Console.Write("Zadejte dolní mez (celé číslo): ");
    int lowerBound;
    while(!int.TryParse(Console.ReadLine(), out lowerBound))
    {
        Console.Write("Nezadali jste celé číslo! Zadejte dolní mez znovu: ");
    }

    // Vstup pro horní mez
    Console.Write("Zadejte horní mez (celé číslo větší nebo rovno hodnotě pro dolní mez): ");
    int upperBound;
    while(!int.TryParse(Console.ReadLine(), out upperBound) || upperBound < lowerBound)
    {
        Console.Write("Nezadali jste celé číslo nebo je horní mez menší než dolní mez! Zadejte horní mez znovu: ");
    }

  
    // Rekapitulace zadaných hodnot
    Console.WriteLine();
    Console.WriteLine("==================================");
    // Výpis zadaných hodnot do jednoho řádku
    Console.WriteLine($"Počet generovaných čísel: {n}; Dolní mez: {lowerBound}; Horní mez: {upperBound}");
    Console.WriteLine("==================================");
    Console.WriteLine();

    // Jádro konkrétního algortimu 
    
    // Deklarace pole a alokace v paměti
    int[] myRandNumbs = new int[n];

    // Inicializace generátoru náhodných čísel
    Random myRandNumb = new Random();
    // Random myRandNumb = new Random(50); // Pevný seed pro testovací účely (vždy stejná čísla)

    Console.WriteLine("Generovaná čísla: ");
    for(int i = 0; i < myRandNumbs.Length; i++ )
    {
        // Generování i-tého náhodného čísla
        myRandNumbs[i] = myRandNumb.Next(lowerBound, upperBound+1);
        Console.Write($"{myRandNumbs[i]}; ");
    }

    // Statistika vygenerovaných čísel
    // Počítadla vždy začínají na nule, protože ještě nic nespočítala
    int positiveCount = 0; // Počet kladných čísel
    int negativeCount = 0; // Počet záporných čísel
    int zeroCount = 0;     // Počet nul
    int evenCount = 0;     // Počet sudých čísel
    int oddCount = 0;      // Počet lichých čísel

    // Projdeme vygenerované číslo po čísle a podle podmínek navyšujeme počítadla
    foreach (int number in myRandNumbs)
    {
        // Rozlišení kladné / záporné / nulové
        if (number > 0)
        {
            positiveCount++;
        }
        else if (number < 0)
        {
            negativeCount++;
        }
        else
        {
            zeroCount++;
        }

        // Rozlišení sudé / liché
        // Pozor: nula je sudá (0 % 2 == 0), proto se započítá mezi sudá
        if (number % 2 == 0)
        {
            evenCount++;
        }
        else
        {
            oddCount++;
        }
    }

    // Výpis statistiky
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine("==================================");
    Console.WriteLine("Statistika vygenerovaných čísel:");
    Console.WriteLine($"Kladných: {positiveCount}");
    Console.WriteLine($"Záporných: {negativeCount}");
    Console.WriteLine($"Nulových: {zeroCount}");
    Console.WriteLine($"Sudých: {evenCount}");
    Console.WriteLine($"Lichých: {oddCount}");
    Console.WriteLine("==================================");

    // Konec jádra konkrétního algoritmu


    // Dotaz směrem k uživateli na opakování
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a. Následně potvrďte klávesou Enter. ");
    Console.WriteLine("Jakokouli jinou klávesou program ukončíte.");
    Console.WriteLine();
    Console.Write("Chcete program spustit znovu? ");
    again = Console.ReadLine() ?? "";

}   

