using ConsoleTableExt;
using TestFrameworkComparison.Helpers;
using TestFrameworkComparison.Models;
using TestFrameworkComparison.Runners;

namespace TestFrameworkComparison
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isNUnit = false;
            bool isXUnit = false;
            bool isMsTest = false;
            Console.Clear();
            if (args.Length == 0)
            {
                throw new ArgumentNullException("MISSING ARGUMENTS");
            }
            foreach (var param in args)
            {
                if (!string.IsNullOrEmpty(param))
                {
                    switch (param.Trim().ToLower())
                    {
                        case ArgumentHelper.AllFrameworks:
                            isNUnit = true;
                            isXUnit = true;
                            isMsTest = true;
                            break;
                        case ArgumentHelper.NUnit:
                            isNUnit = true;
                            break;
                        case ArgumentHelper.XUnit:
                            isXUnit = true;
                            break;
                        case ArgumentHelper.MsTest:
                            isMsTest = true;
                            break;
                    }
                }
            }
            var performanceData = new List<PerformanceModel>();
            if (isNUnit)
                performanceData.Add(NUnitTestRunner.Run("Tests.TestCOMMAND"));
            if (isXUnit)
                performanceData.Add(XUnitTestRunner.Run("UnitTest1.TestCOMMAND"));
            if (isMsTest)
                performanceData.Add(MsTestRunner.Run("UnitTest1.TestMethod1"));
            if (performanceData.Count > 0)
            {
                performanceData.OrderBy(x => x.Elapsed);
                ConsoleTableBuilder
                    .From(performanceData)
                    .WithTitle("Result ", ConsoleColor.Yellow, ConsoleColor.DarkGray)
                    .WithColumn("Start Memory", "End Memory", "Diff - Memory", "Elapsed Time", "Framework")
                    .ExportAndWriteLine(TableAligntment.Center);
            }
            else
            {
                ConsoleTableBuilder
                    .From(performanceData)
                    .WithTitle("No RESULTS");
            }
        }
    }
}