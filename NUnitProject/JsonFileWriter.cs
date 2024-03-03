using Newtonsoft.Json;

namespace NUnitProject
{
    public static class JsonFileWriter
    {
        public static void WriteToJsonFile<T>(T obj, string filePath = "C:/TestLogs")
        {
            try
            {
                string jsonContent = JsonConvert.SerializeObject(obj, Formatting.Indented);

                // Zapis do pliku
                File.WriteAllText(filePath, jsonContent);

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Wystąpił błąd podczas zapisu do pliku JSON: {ex.Message}");
            }
        }
    }
}
