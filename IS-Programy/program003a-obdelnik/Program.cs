Console.Clear();
string again = "a";
// .ToLower() převede vstup na malá písmena, takže program bude pokračovat při zadávání "a" tak i "A"
while(again.ToLower() == "a" )
{
    Console.WriteLine();
    Console.Clear();
    Console.WriteLine("***************************************");
    Console.WriteLine("******** Vykreslení obdelniku *********");
    Console.WriteLine("***************************************");
    Console.WriteLine("************** Jan Havlíček ************");
    Console.WriteLine("***************************************");
    Console.WriteLine("***************************************");

    // Vstup pro šířku
    Console.Write("Zadejte šířku obrazce (kladné celé číslo): ");
    int width;
    while(!int.TryParse(Console.ReadLine(), out width) ||  width <= 0 )
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("Nezadali jste kladné celé číslo! Zadejte šířku obrazce znovu: ");
        Console.ResetColor();
    }

    // Vstup pro výšku
    Console.Write("Zadejte výšku obrazce (kladné celé číslo): ");
    int height;
    while(!int.TryParse(Console.ReadLine(), out height) ||  height <= 0 )
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("Nezadali jste kladné celé číslo! Zadejte výšku obrazce znovu: ");
        Console.ResetColor();
    }

    
    // Rekapitulace zadaných hodnot
    Console.WriteLine();
    Console.WriteLine("==================================");
    // Výpis zadaných hodnot do jednoho řádku
    Console.WriteLine($"Šířka: {width}; Výška: {height}");
    Console.WriteLine("==================================");
    Console.WriteLine();

    // Jádro konkrétního algortimu

    // Pole barev - řádky obdélníku se střídavě vykreslují dvěma barvami
    ConsoleColor[] colors = new ConsoleColor[]
    {
        ConsoleColor.Red,
        ConsoleColor.Green
    };

    // Vnější cyklus, který bude řídit správný počet zobrazených řádků (výška) 
    for(int i = 1; i <= height ; i++)
    {
        // Barvu vybíráme podle čísla řádku
        // Modulo (%) zajistí, že se barvy po dosažení konce pole zase opakují od začátku
        Console.ForegroundColor = colors[(i - 1) % colors.Length];

        // Vnitřní cyklus se stará o to, aby se v každém řádku vykreslil správný počet znaků (šířka krát)
        for(int j = 1; j <= width; j++)
        {
            Console.Write("* ");
            System.Threading.Thread.Sleep(System.TimeSpan.FromMilliseconds(100));    
        }
        
        Console.WriteLine();
        
    }

    // Obnovení původní barvy textu (aby další text nebyl obarvený)
    Console.ResetColor();

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


