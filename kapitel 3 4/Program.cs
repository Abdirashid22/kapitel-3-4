using System;

class Program
{
    static void Main()
    {

        Console.Write("Ange låtens längd i minuter: ");
        int minuter = int.Parse(Console.ReadLine());

        Console.Write("Ange låtens längd i sekunder: ");
        int sekunder = int.Parse(Console.ReadLine());


        int totalSekunder = minuter * 60 + sekunder;


        int minGräns = 2 * 60 + 45; // 2 minuter och 45 sekunder
        int maxGräns = 4 * 60 + 20; // 4 minuter och 20 sekunder


        if (totalSekunder >= minGräns && totalSekunder <= maxGräns)
        {
            Console.WriteLine("Låten får spelas på radiostationen.");
        }
        else
        {
            Console.WriteLine("Låten får inte spelas på radiostationen.");
        }
    }
}

