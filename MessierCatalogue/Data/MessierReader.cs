using System.Text;

namespace MessierCatalogue.Data
{
    public static class MessierReader
    {
        public static string[,] LoadData(string filePath, int maxRows = 110, int maxColumns = 10)
        {
            var data = new string[maxRows, maxColumns];
            int rowIndex = 0;

            try
            {
                using (var reader = new StreamReader(filePath, Encoding.GetEncoding("ISO-8859-1")))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null && rowIndex < maxRows)
                    {
                        if (line.StartsWith(";") || string.IsNullOrWhiteSpace(line))
                        {
                            continue;
                        }
                        
                        if (line.StartsWith("Name,"))
                        {
                            continue;
                        }

                        var fields = line.Split(','); // Bruk komma som separator
                        for (int colIndex = 0; colIndex < fields.Length && colIndex < maxColumns; colIndex++)
                        {
                            data[rowIndex, colIndex] = fields[colIndex].Trim();
                        }
                        rowIndex++;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Feil under lesing av fil: {ex.Message}");
            }

            return data;
        }
    }
}