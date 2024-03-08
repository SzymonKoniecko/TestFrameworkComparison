namespace TestFrameworkComparison.Helpers
{
    public static class FileReaderHelper
    {
        public static int[] ReadNumbersFromFileToArray(string filePath)
        {
            List<int> ints = new();
            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        if (int.TryParse(line, out int number))
                        {
                            ints.Add(number);
                        }
                        else
                        {
                            Console.WriteLine($"CANNOT CONVERT '{line}' TO INT.");
                        }
                    }
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine($"CANNOT FIND A FILE FOR THAT PATH '{filePath}'");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"ERROR: {ex.Message}");
            }
            if (ints.Count == 0) throw new Exception("NO DATA FROM FILE");
            return ints.ToArray();
        }
    }
}
