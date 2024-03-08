using Newtonsoft.Json;
using TestFrameworkComparison.Models;

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
        public static void PrintPreformanceResult(PerformanceModel performanceModel)
        {
            Console.WriteLine(JsonConvert.SerializeObject(performanceModel));
        }
        public static void PrintSummaryOfCall()
        {
            throw new NotImplementedException();
        }
    }
}
