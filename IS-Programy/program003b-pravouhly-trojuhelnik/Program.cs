Console.Clear();
string again = "a";
// .ToLower() převede vstup na malá písmena, takže program bude pokračovat při zadávání "a" tak i "A"
while(again.ToLower() == "a" )
{
    Console.WriteLine();
    Console.Clear();
    Console.WriteLine("********************************************");
    Console.WriteLine("**** Vykreslení pravoúhlého trojúhelníku ****");
    Console.WriteLine("********************************************");
    Console.WriteLine("*************** Jan Havlíček ***************");
    Console.WriteLine("********************************************");
    Console.WriteLine("********************************************");

    // Vstupem je výška trojúhelníku (počet řádků), musí to být kladné celé číslo
    Console.Write("Zadejte výšku trojúhelníku (kladné celé číslo): ");
    int height;
    while(!int.TryParse(Console.ReadLine(), out height) || height <= 0)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("Nezadali jste kladné celé číslo! Zadejte výšku trojúhelníku znovu: ");
        Console.ResetColor();
    }

    // Rekapitulace zadané hodnoty
    Console.WriteLine();
    Console.WriteLine("==================================");
    Console.WriteLine($"Výška: {height}");
    Console.WriteLine("==================================");
    Console.WriteLine();

    // Jádro konkrétního algoritmu
    // Vnější cyklus řídí řádky - v i-tém řádku je právě i hvězdiček
    for(int row = 1; row <= height; row++)
    {
        // Vnitřní cyklus vypíše tolik hvězdiček, kolik odpovídá číslu aktuálního řádku
        for(int col = 1; col <= row; col++)
        {
            Console.Write("*");
        }

        // Po dokončení řádku přejdeme na nový řádek
        Console.WriteLine();
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
