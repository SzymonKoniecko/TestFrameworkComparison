﻿using Microsoft.Extensions.DependencyInjection;
using TestFrameworkComparison.Runners;
using TestFrameworkComparison.Services;
using TestFrameworkComparison.Services.Sort;

namespace TestFrameworkComparison
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            if (args.Length == 0)
            {
                throw new ArgumentNullException("MISSING ARGUMENTS");
            }
            int index = 0;
            var serviceProvider = new ServiceCollection();
            int fileIndex = 0;
            SortService sortingService = null;
            foreach (var param in args)
            {
                if (!string.IsNullOrEmpty(param))
                {
                    if (param.Equals("--Sort"))
                    {
                        sortingService = serviceProvider
                            .SetSortService(args[index + 1])
                            .AddScoped<SortService>()
                            .BuildServiceProvider()
                            .GetService<SortService>();
                        fileIndex = index + 2;
                    }
                }
                index++;
            }
            if (sortingService != null)
            {
                NUnitTestRunner.Run("Tests.TestCOMMAND");
                XUnitTestRunner.Run("UnitTest1.TestCOMMAND");
                MsTestRunner.Run("UnitTest1.TestMethod1");
                //sortingService.ExecuteSort(int.Parse(args[fileIndex]));
            }
        }
    }
}