using Microsoft.Extensions.DependencyInjection;
using TestFrameworkComparison.Services.Sort;

namespace TestFrameworkComparison.Services
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection SetSortService(this IServiceCollection services, string arg)
        {
            switch (arg)
            {
                case "Bubble":
                    services.AddScoped<ISortService, BubbleSortService>();
                    break;
                case "Quick":
                    services.AddScoped<ISortService, QuickSortService>();
                    break;
                default:
                    throw new ArgumentException("MISSING SORTING METHOD");
            }

            return services;
        }
    }
}
