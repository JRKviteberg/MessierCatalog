namespace MessierCatalogue.Algorithms
{
    public static class Sort
    {
        public static void PerformSort(string[,] data, int columnIndex, bool ascending = true)
        {
            int rowCount = data.GetLength(0);
            
            for (int i = 0; i < rowCount - 1; i++)
            {
                for (int j = 0; j < rowCount - i - 1; j++)
                {
                    if (string.IsNullOrEmpty(data[j, columnIndex]) || string.IsNullOrEmpty(data[j + 1, columnIndex]))
                        continue;
                    
                    bool shouldSwap = ascending
                        ? Compare(data[j, columnIndex], data[j + 1, columnIndex]) > 0
                        : Compare(data[j, columnIndex], data[j + 1, columnIndex]) < 0;

                    if (shouldSwap)
                    {
                        SwapRows(data, j, j + 1);
                    }
                }
            }
        }
        
        private static int Compare(string value1, string value2)
        {
            if (value1.StartsWith("M") && value2.StartsWith("M"))
            {
                if (int.TryParse(value1.Substring(1), out int messierNum1) && int.TryParse(value2.Substring(1), out int messierNum2))
                {
                    return messierNum1.CompareTo(messierNum2);
                }
            }
            
            if (double.TryParse(value1, out double numericValue1) && double.TryParse(value2, out double numericValue2))
                return numericValue1.CompareTo(numericValue2);
            
            return string.Compare(value1, value2, StringComparison.OrdinalIgnoreCase);
        }

        private static void SwapRows(string[,] data, int rowIndex1, int rowIndex2)
        {
            int columnCount = data.GetLength(1);
            for (int col = 0; col < columnCount; col++)
            {
                string temp = data[rowIndex1, col];
                data[rowIndex1, col] = data[rowIndex2, col];
                data[rowIndex2, col] = temp;
            }
        }
    }
}
