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

    Console.WriteLine("Náhodná čísla:");
    for(int i = 0; i < myRandNumbs.Length; i++ )
    {
        // Generování i-tého náhodného čísla
        myRandNumbs[i] = myRandNumb.Next(lowerBound, upperBound+1);
        Console.Write($"{myRandNumbs[i]}; ");
    }
    Console.WriteLine();

    // Hledání extrémů začneme od prvního prvku pole (index 0)
    int max = myRandNumbs[0];       // Zatím považujeme první prvek za maximum
    int maxPosition = 0;            // Pozice (index) zatím nalezeného maxima
    int min = myRandNumbs[0];       // Zatím považujeme první prvek za minimum
    int minPosition = 0;            // Pozice (index) zatím nalezeného minima

    // Projdeme zbytek pole (od indexu 1) a porovnáváme s dosavadním extrémem
    for(int i = 1; i < myRandNumbs.Length; i++)
    {
        // Ostrá nerovnost ">" zajistí, že při stejné hodnotě zůstane uložena PRVNÍ pozice
        if(myRandNumbs[i] > max)
        {
            max = myRandNumbs[i];
            maxPosition = i;
        }

        // Stejně u minima - ostrá nerovnost "<" = první výskyt minima
        if(myRandNumbs[i] < min)
        {
            min = myRandNumbs[i];
            minPosition = i;
        }
    }

    // Výpis výsledků
    Console.WriteLine();
    Console.WriteLine("==================================");
    Console.WriteLine($"Maximum: {max}");
    Console.WriteLine($"Pozice prvního maxima: {maxPosition}");
    Console.WriteLine($"Minimum: {min}");
    Console.WriteLine($"Pozice prvního minima: {minPosition}");
    Console.WriteLine("==================================");

    // Vykreslení obrazce přesýpacích hodin
    // Obrazec vykreslujeme pouze tehdy, je-li maximum alespoň 3
    if (max >= 3)
    {
        Console.WriteLine();
        Console.WriteLine("Přesýpací hodiny (výška i šířka = maximum):");

        // Paleta barev - každý řádek obrazce se vykreslí jinou barvou (barvy se cyklicky opakují)
        ConsoleColor[] colors = new ConsoleColor[]
        {
            ConsoleColor.Red,
            ConsoleColor.Green,
            ConsoleColor.Yellow,
            ConsoleColor.Blue,
            ConsoleColor.Magenta,
            ConsoleColor.Cyan
        };

        // Počet řádků obrazce odpovídá maximu
        for (int row = 0; row < max; row++)
        {
            // Barva aktuálního řádku vybraná z palety (modulo zajistí opakování barev)
            Console.ForegroundColor = colors[row % colors.Length];

            // Vzdálenost řádku od bližšího okraje (horního nebo dolního)
            int distance = Math.Min(row, max - 1 - row);

            // Směrem ke středu ubývá vždy o dvě hvězdičky
            int stars = max - 2 * distance;

            // Odsazení zleva, aby byl obrazec vycentrovaný pod sebou
            int spaces = max - stars;

            Console.Write(new string(' ', spaces));

            // Vykreslení hvězdiček řádku (za každou hvězdičkou následuje mezera)
            for (int s = 0; s < stars; s++)
            {
                Console.Write("* ");
            }

            Console.WriteLine();
        }

        // Vrácení původní barvy, aby zbytek textu (dotaz na opakování) nebyl obarvený
        Console.ResetColor();
    }
    else
    {
        // Maximum je příliš malé na to, aby obrazec vypadal jako přesýpací hodiny
        Console.WriteLine();
        Console.WriteLine("Maximum je menší než 3, obrazec se nevykresluje.");
    }

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