namespace TestFrameworkComparison.Helpers
{
    public static class PrinterHelper
    {
        public static void PrintNumbers<T>(IEnumerable<T> numbers)
        {
            foreach (var number in numbers)
            {
                Console.WriteLine(number + " ");
            }
        }
    }
}
