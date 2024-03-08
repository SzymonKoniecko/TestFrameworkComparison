using TestFrameworkComparison.Helpers;

namespace TestFrameworkComparison.Runners
{
    public static class NUnitTestRunner
    {
        private static string BASE_COMMAND = "dotnet test --filter NUnitProject.";
        public static void Run(string methodIndicator)
        {
            PrinterHelper.PrintPreformanceResult(
                PerformanceHelper.FetchPerformance(PowerShellHelper.Command(BASE_COMMAND + methodIndicator), Enums.FrameworkEnum.NUnit)
                );
        }
    }
}