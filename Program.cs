namespace Frutas_Favoritas;
class Program
{
    static void Main(string[] args)
    {
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("---Minhas Frutas Favoritas---");
        Console.ResetColor();

        Console.WriteLine();
        
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("1. Maçã");
        Console.WriteLine("2. Banana");
        Console.WriteLine("3. Melancia");
        Console.WriteLine("4. Uva");
        Console.WriteLine("5. Manga");
        Console.ResetColor();
    }
}
