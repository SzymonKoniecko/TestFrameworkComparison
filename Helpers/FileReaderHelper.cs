namespace TestFrameworkComparison.Helpers
{
    public static class FileReaderHelper
    {
        public static void ReadNumbersFromFile(string filePath)
        {
            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        if (int.TryParse(line, out int number))
                        {
                            Console.WriteLine(number);
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
        }
    }
}
