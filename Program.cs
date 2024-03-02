using Microsoft.Extensions.DependencyInjection;
using TestFrameworkComparison.Helpers;
using TestFrameworkComparison.Services;
using TestFrameworkComparison.Services.Sort;

namespace TestFrameworkComparison
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                throw new ArgumentNullException("MISSING ARGUMENTS");
            }
            int index = 0;
            var serviceProvider = new ServiceCollection();
            int fileIndex = 0;
            foreach (var param in args)
            {
                if (!string.IsNullOrEmpty(param))
                {
                    if (param.Equals("--Sort"))
                    {
                        serviceProvider.GetSortService(args[index + 1]);
                        fileIndex = index + 2;
                    }
                }
                index++;
            }
            PrinterHelper.PrintNumbers(args);
            if (args.Contains("--Sort"))
            {
                var sortingService = serviceProvider.AddScoped<SortService>().BuildServiceProvider().GetService<SortService>();
                sortingService.ExecuteSort(int.Parse(args[fileIndex]));
            }
        }
    }
}
