using Microsoft.Extensions.DependencyInjection;
using TestFrameworkComparison.Services.Sort;

namespace TestFrameworkComparison
{
    internal class Program
    {
        static void Main()
        {
            var serviceProvider = new ServiceCollection()
                .AddScoped<ISortService, QuickSortService>()
                .AddScoped<SortService>()
                .BuildServiceProvider();

            var sortingService = serviceProvider.GetRequiredService<SortService>();

            sortingService.ExecuteSort(0);
        }
    }
}
