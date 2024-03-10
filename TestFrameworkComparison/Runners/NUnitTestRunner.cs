using TestFrameworkComparison.Helpers;
using TestFrameworkComparison.Models;

namespace TestFrameworkComparison.Runners
{
    public static class NUnitTestRunner
    {
        private static string BASE_COMMAND = "dotnet test --filter NUnitProject.";
        public static PerformanceModel Run(string methodIndicator)
        {
            return PerformanceHelper.FetchPerformance(PowerShellHelper.Command(BASE_COMMAND + methodIndicator), Enums.FrameworkEnum.NUnit);
        }
    }
}