using TestFrameworkComparison.Helpers;
using TestFrameworkComparison.Models;

namespace TestFrameworkComparison.Runners
{
    public static class XUnitTestRunner
    {
        private static string BASE_COMMAND = "dotnet test --filter XUnitProject.";
        private static string END_PARAMS = " --logger \"console;verbosity=detailed\"";
        public static PerformanceModel Run(string methodIndicator)
        {
            return PerformanceHelper.FetchPerformance(PowerShellHelper.Command(BASE_COMMAND + methodIndicator + END_PARAMS), Enums.FrameworkEnum.XUnit);
        }
    }
}
