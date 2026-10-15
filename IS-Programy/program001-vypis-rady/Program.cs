// ==== Program: výpis řady čísel ====
// Uživatel zadá první hodnotu, poslední hodnotu a krok (rozestup mezi čísly).
// Program vypíše všechna čísla od "first" do "last" s daným krokem.

// Výzva uživateli (Write nevypíše nový řádek, takže uživatel píše hned za text)
Console.Write("Zadej první hodnotu (first): ");

// Přečteme vstup z klávesnice a převedeme text na celé číslo (int)
int first = int.Parse(Console.ReadLine()!);

// Stejně načteme poslední hodnotu
Console.Write("Zadej poslední hodnotu (last): ");
int last = int.Parse(Console.ReadLine()!);

// A nakonec krok (o kolik se čísla liší)
Console.Write("Zadej krok (step): ");
int step = int.Parse(Console.ReadLine()!);

// Prázdný řádek pro lepší přehlednost výstupu
Console.WriteLine();

// Cyklus projde čísla od "first" do "last" a vždy přičte "step"
// i = první hodnota; opakuj dokud i <= last; po každém kroku i zvýš o step
for (int i = first; i <= last; i += step)
{
    // Vypíše aktuální číslo řady
    Console.WriteLine(i);
}