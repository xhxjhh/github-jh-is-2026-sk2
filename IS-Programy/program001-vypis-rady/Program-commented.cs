// jednořádkový 

/* 
Toto je
více řádkový 
komentář
*/

// jako první si připravíme smyčku pro opakování programu

Console.Clear();
string again = "a";
// .ToLower() převede vstup na malá písmena, takže program bude pokračovat při zadávání "a" tak i "A"
while(again.ToLower() == "a" )
{
    Console.WriteLine();
    Console.Clear();
    Console.WriteLine("******************************************");
    Console.WriteLine("*************** Výpis řady ***************");
    Console.WriteLine("******************************************");
    Console.WriteLine("************** Jan Havlíček ***************");
    Console.WriteLine("******************************************");
    Console.WriteLine("******************************************");

    // Vstup počáteční hodnoty - špatně řešený
    // Console.Write("Zadejte první číslo řady: ");
    // int first = int.Parse(Console.ReadLine());

    // Vstup počáteční hodnoty - správně řešený
    Console.Write("Zadejte první číslo řady (celé číslo): ");
    int first;
    while(!int.TryParse(Console.ReadLine(), out first))
    {
        Console.Write("Nezadali jste celé číslo! Zadejte první číslo řady znovu (celé číslo): ");
    }

    // Vstup koncové hodnoty - správně řešený
    Console.Write("Zadejte poslední číslo řady (celé číslo): ");
    int last;
    while(!int.TryParse(Console.ReadLine(), out last))
    {
        Console.Write("Nezadali jste celé číslo! Zadejte poslední číslo řady znovu (celé číslo): ");
    }

    // Vstup diference s kontrolou kladné hodnoty
    Console.Write("Zadejte diferenci (kladné celé číslo): ");
    int step;
    while(!int.TryParse(Console.ReadLine(), out step) || step <= 0 )
    {
        Console.Write("Diference musí být kladné celé číslo! Zadejte diferenci znovu (kladné celé číslo): ");
    }


    // Rekapitulace zadaných hodnot
    Console.WriteLine();
    Console.WriteLine("==================================");
    // Výpis zadaných hodnot pod sebou
    // Console.WriteLine($"První číslo: {first}");
    // Console.WriteLine($"Poslední číslo: {last}");
    // Console.WriteLine($"Diference (krok): {step}");
    
    // Výpis zadaných hodnot do jednoho řádku
    Console.WriteLine($"První číslo: {first}; Poslední číslo: {last}; Diference (krok): {step}");
    Console.WriteLine("==================================");
    Console.WriteLine();

    // Jádro algortimu pro výpis řady
    Console.WriteLine("Výpis číselné řady: ");

    if(first <= last)
    {
        int current = first;
        while(current <= last) {
            // Čísla řady vypsaná pod sebou
            Console.WriteLine(current);
            
            // Čísla řady vypsaná vedle sebe
            // Console.Write($"{current}; ");
            
            // current = current + step;
            // předchozí řádek lze napsat stručněji
            current += step;
        }
    }
    else
    {
        Console.WriteLine("Řadu nelze vypsat!");
        Console.WriteLine("První číslo je větší než poslední.");
        Console.WriteLine("Tento program umí vypsat pouze vzestupnou řadu (od menšího k většímu)");
    }

    // Dotaz směrem k uživateli na opakování
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a. Následně potvrďte klávesou Enter. ");
    Console.WriteLine("Jakokouli jinou klávesou program ukončíte.");
    Console.WriteLine();
    Console.Write("Chcete program spustit znovu? ");
    again = Console.ReadLine() ?? "";

}   

