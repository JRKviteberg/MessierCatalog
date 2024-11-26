using MessierCatalogue.Data;
using MessierCatalogue.Algorithms;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Leser inn Messier-katalogen...");
        var data = MessierReader.LoadData("Messier.csv");

        int filledRows = 0;
        for (int i = 0; i < data.GetLength(0); i++)
        {
            if (!string.IsNullOrEmpty(data[i, 0]))
                filledRows++;
        }

        Console.WriteLine($"Fant {filledRows} objekter i katalogen!");

        while (true)
        {
            Console.WriteLine("\nVelg en handling:");
            Console.WriteLine("1. Søk");
            Console.WriteLine("2. Sorter");
            Console.WriteLine("3. Avslutt");
            Console.Write("Valg: ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.Write("Skriv inn et søkeord: ");
                string query = Console.ReadLine();
                var results = Search.PerformSearch(data, query);
                Search.DisplayResults(results);
            }
            else if (choice == "2")
            {
                Console.WriteLine("Velg kolonne å sortere på:");
                Console.WriteLine("1. Messier nummer");
                Console.WriteLine("2. NGC nummer");
                Console.WriteLine("3. Magnitude");
                Console.Write("Valg: ");
                string columnChoice = Console.ReadLine();

                int columnIndex = columnChoice switch
                {
                    "1" => 0, 
                    "2" => 1, 
                    "3" => 6,
                    _ => -1
                };

                if (columnIndex == -1)
                {
                    Console.WriteLine("Ugyldig valg. Prøv igjen.");
                    continue;
                }

                Console.WriteLine("Velg rekkefølge for sortering:");
                Console.WriteLine("1. Stigende (Ascending)");
                Console.WriteLine("2. Synkende (Descending)");
                Console.Write("Valg: ");
                string orderChoice = Console.ReadLine();

                bool ascending = orderChoice switch
                {
                    "1" => true,
                    "2" => false,
                    _ => true 
                };

                Sort.PerformSort(data, columnIndex, ascending);

                if (ascending)
                {
                    Console.WriteLine("Sortering fullført i stigende rekkefølge. Viser de første 20 resultatene:");
                }
                else
                {
                    Console.WriteLine("Sortering fullført i synkende rekkefølge. Viser de første 20 resultatene:");
                }

                for (int i = 0; i < Math.Min(20, filledRows); i++)
                {
                    for (int j = 0; j < data.GetLength(1); j++)
                    {
                        if (!string.IsNullOrEmpty(data[i, j]))
                            Console.Write($"{data[i, j]} ");
                    }
                    Console.WriteLine();
                }
            }
            else if (choice == "3")
            {
                Console.WriteLine("Avslutter programmet. Ha en fin dag!");
                break;
            }
            else
            {
                Console.WriteLine("Ugyldig valg. Prøv igjen.");
            }
        }
    }
}
