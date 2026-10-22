// ==========================================================================
// Program 001: Výpis řady čísel
// Autor: Jan Havlíček
// --------------------------------------------------------------------------
// Uživatel zadá první hodnotu (first), poslední hodnotu (last) a krok
// (difference = rozestup mezi čísly). Program vypíše všechna čísla
// od "first" do "last" s daným krokem. Poté se zeptá, zda má pokračovat
// vypsáním další řady.
// ==========================================================================

// Oddělovač, který používáme pro hezčí vzhled konzole (aby se nemusel pořád opisovat)
string line = new string('=', 60);

// ---- Uvítací hlavička ----------------------------------------------------
// Vypíše název programu a autora, aby bylo na první pohled jasné, co běží
Console.WriteLine(line);
Console.WriteLine("  PROGRAM 001 - VÝPIS ŘADY ČÍSEL");
Console.WriteLine("  Autor: Jan Havlíček");
Console.WriteLine(line);
Console.WriteLine(); // prázdný řádek pro odsazení od zbytku výpisu

// ---- Řídící proměnná hlavního cyklu --------------------------------------
// Dokud je "again" true, program se zeptá na další řadu a znovu ji vypíše
bool again = true;

// ---- Hlavní cyklus programu ----------------------------------------------
// Opakujeme celé zadání a výpis, dokud uživatel chce pokračovat
while (again)
{
    // Malý nadpis, aby bylo poznat, že začíná zadávání nové řady
    Console.WriteLine("--- ZADÁNÍ NOVÉ ŘADY ---");

    // Výzva uživateli (Write nevypíše nový řádek, takže uživatel píše hned za text)
    Console.Write("Zadej první hodnotu (first): ");

    // Přečteme vstup a zkusíme převést na celé číslo (int).
    // TryParse vrátí false, když uživatel nezadal číslo (např. text),
    // takže program díky tomu nespadne.
    if (!int.TryParse(Console.ReadLine(), out int first))
    {
        Console.WriteLine("!! Chyba: nezadal jsi celé číslo.\n");
        continue; // přeskočíme zbytek a zeptáme se znovu
    }

    // Stejně načteme poslední hodnotu
    Console.Write("Zadej poslední hodnotu (last): ");
    if (!int.TryParse(Console.ReadLine(), out int last))
    {
        Console.WriteLine("!! Chyba: nezadal jsi celé číslo.\n");
        continue; // přeskočíme zbytek a zeptáme se znovu
    }

    // A nakonec krok (o kolik se čísla liší)
    Console.Write("Zadej krok (difference): ");
    if (!int.TryParse(Console.ReadLine(), out int difference))
    {
        Console.WriteLine("!! Chyba: nezadal jsi celé číslo.\n");
        continue; // přeskočíme zbytek a zeptáme se znovu
    }

    // ---- Opatření 1: kontrola pořadí hodnot ------------------------------
    // První hodnota nesmí být větší než poslední, jinak by cyklus
    // neproběhl ani jednou (first > last) a nevypadlo by nic.
    if (first > last)
    {
        Console.WriteLine("!! Chyba: první hodnota musí být menší nebo rovna poslední.\n");
        continue; // přeskočíme výpis a zeptáme se znovu
    }

    // ---- Opatření 2: kontrola kroku --------------------------------------
    // Krok musí být kladný, jinak by se cyklus zacyklil
    // nebo by čísla místo přičítání ubývala.
    if (difference <= 0)
    {
        Console.WriteLine("!! Chyba: krok (difference) musí být větší než 0.\n");
        continue; // přeskočíme výpis a zeptáme se znovu
    }

    // ---- Výpis výsledné řady ---------------------------------------------
    Console.WriteLine();
    Console.WriteLine($"Výsledná řada od {first} do {last} s krokem {difference}:");
    Console.WriteLine(new string('-', 60)); // oddělovač před samotnými čísly

    // Cyklus projde čísla od "first" do "last" a vždy přičte "difference"
    // current = první hodnota; opakuj dokud current <= last;
    // po každém kroku current zvýš o difference
    for (int current = first; current <= last; current += difference)
    {
        // Vypíše aktuální číslo řady
        Console.WriteLine(current);
    }

    // ---- Dotaz na pokračování --------------------------------------------
    // Zeptáme se, zda má program vypsat další řadu.
    // "again" nastavíme na true jen když uživatel napíše "a" (velikost
    // písmena ani mezery kolem nehrají roli díky Trim() a ToLower()).
    Console.WriteLine(new string('-', 60));
    Console.Write("Chceš zadat další řadu? (a/n): ");
    again = Console.ReadLine()!.Trim().ToLower() == "a";
    Console.WriteLine();
}

// ---- Rozloučení ----------------------------------------------------------
// Vypíše se po ukončení hlavního cyklu, když uživatel zvolí "n"
Console.WriteLine(line);
Console.WriteLine("  Děkuji za použití programu. Jan Havlíček");
Console.WriteLine(line);
