﻿
using System.Diagnostics.CodeAnalysis;

Console.Clear();
string again = "a";
// .ToLower() převede vstup na malá písmena, takže program bude pokračovat při zadávání "a" tak i "A"
while(again.ToLower() == "a" )
{
    Console.WriteLine();
    Console.Clear();
    Console.WriteLine("******************************************");
    Console.WriteLine("******** Ciferný součet a součin ********");
    Console.WriteLine("******************************************");
    Console.WriteLine("************** Jan Havlicek ***************");
    Console.WriteLine("******************************************");
    Console.WriteLine("******************************************");

    // Vstup celého čísla
    Console.Write("Zadejte celé číslo: ");
    int number;
    while(!int.TryParse(Console.ReadLine(), out number))
    {
        Console.Write("Nezadali jste celé číslo! Zadejte celé číslo znovu: ");
    }

    
    
    // Rekapitulace zadaných hodnot
    Console.WriteLine();
    Console.WriteLine("==================================");
    // Výpis zadaných hodnot do jednoho řádku
    Console.WriteLine($"Celé číslo: {number}");
    Console.WriteLine("==================================");
    Console.WriteLine();

    // Jádro konkrétního algortimu 
    
    // 1. Příprava pomocných proměnných pro výpočet
    int numberBackup = number; // Záloha původního čísla pro závěrečný výpis
    int sum = 0;               // Neutrální hodnotou pro sčítání je 0
    int product = 1;           // Neutrální hodnotou pro násobení je 1 (ne 0!)
    int digit;                 // Proměnná pro uložení právě zpracovávané číslice 

    // 2. Ošetření záporných čísel (znaménko nemá vliv na součet cifer)
    if(number < 0)
    {
        number = -number;
    } 

    // 3. zvláštní případ
    if (number == 0)
    {
        sum = 0;     // Součet cifer čísla 0 je 0
        product = 0; // Součin cifer čísla 0 je 0 (jinak by zůstal neutrální 1)
    }
    else
    {
        Console.WriteLine();
        Console.WriteLine("Průběh rozkladu čísla na jednotlivé číslice (z prava do leva)");
        
        // 4. Jádro problému - matematický rozklad čísla pomocí cyklu
        while (number > 0 )
        {
            // Operátoru % se říká MODULO (slouží k určení zbytku po celočíselném dělení)
            digit = number % 10;      // MODULO 10 nám získá poslední číslici
            sum = sum + digit;        // Přičtení číslice k celkovému součtu
            product = product * digit; // Vynásobení číslice k celkovému součinu
            number = number / 10;     // Celočíselné dělení 10kou odstraní poslední číslici 

            Console.WriteLine($"Aktuální číslice (zbytek): {digit}");
            Console.WriteLine($"Číslo po odříznutí aktuální číslice: {number}");
            Console.WriteLine($"Aktuální hodnota ciferného součtu: {sum}");
            Console.WriteLine($"Aktuální hodnota ciferného součinu: {product}");

        }
    }


    // 5. Výpis výsledků
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine("==================================");
    Console.WriteLine($"Ciferný součet čísla {numberBackup} je {sum}");
    Console.WriteLine($"Ciferný součin čísla {numberBackup} je {product}");
    Console.WriteLine("==================================");
    Console.WriteLine();

    




    

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

