namespace MessierCatalogue.Algorithms
{
    public static class Search
    {
        public static string[,] PerformSearch(string[,] data, string query, int maxResults = 10)
        {
            var results = new string[maxResults, data.GetLength(1)];
            int resultCount = 0;

            Console.WriteLine($"Søker etter: {query}");

            for (int i = 0; i < data.GetLength(0); i++)
            {
                if (resultCount >= maxResults) break;

                for (int j = 0; j < data.GetLength(1); j++)
                {
                    if (data[i, j] != null && data[i, j].IndexOf(query, StringComparison.OrdinalIgnoreCase) >= 0)
                    {
                        Console.WriteLine($"Match funnet i rad {i + 1}: {data[i, j]}");
                        
                        for (int col = 0; col < data.GetLength(1); col++)
                        {
                            results[resultCount, col] = data[i, col];
                        }
                        resultCount++;
                        break; 
                    }
                }
            }

            if (resultCount == 0)
            {
                Console.WriteLine("Ingen treff funnet.");
            }

            return results;
        }

        public static void DisplayResults(string[,] results)
        {
            Console.WriteLine("Søkeresultater:");
            for (int i = 0; i < results.GetLength(0); i++)
            {
                if (!string.IsNullOrEmpty(results[i, 0]))
                {
                    Console.Write($"Resultat {i + 1}: ");
                    for (int j = 0; j < results.GetLength(1); j++)
                    {
                        if (!string.IsNullOrEmpty(results[i, j]))
                            Console.Write($"{results[i, j]} ");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
