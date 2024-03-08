﻿using TestFrameworkComparison.Helpers;

namespace TestFrameworkComparison.Runners
{
    public static class NUnitTestRunner
    {
        private static string BASE_COMMAND = "dotnet test --filter ";
        public static void Run(string script)
        {
            PrinterHelper.PrintPreformanceResult(
                PerformanceHelper.FetchPerformance(PowerShellHelper.Command(BASE_COMMAND + script), Enums.FrameworkEnum.NUnit)
                );
        }
    }
}