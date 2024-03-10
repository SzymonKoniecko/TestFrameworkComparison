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
            int paramIndex = 0;
            string testMethodName = String.Empty;
            Console.WriteLine("Provided args: ");
            foreach (var param in args)
            {
                Console.Write(param + " ");
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
                        case ArgumentHelper.SORT:
                            if (args.Length >= paramIndex + 2)
                            {
                                testMethodName = ArgumentHelper.GetSortingTestMethod(args[paramIndex + 1], args[paramIndex + 2]);
                                break;
                            }
                            if (args.Length >= paramIndex + 1)
                            {
                                testMethodName = ArgumentHelper.GetSortingTestMethod(args[paramIndex + 1], "0");
                                break;
                            }
                            else
                            {
                                throw new ArgumentException("MISSING SORTING METHOD OR SORTING SIZE");
                            }
                    }
                    paramIndex++;
                }
            }
            Console.WriteLine();
            var performanceData = new List<PerformanceModel>();
            if (isNUnit)
                performanceData.Add(NUnitTestRunner.Run(testMethodName));
            if (isXUnit)
                performanceData.Add(XUnitTestRunner.Run(testMethodName));
            if (isMsTest)
                performanceData.Add(MsTestRunner.Run(testMethodName));
            if (performanceData.Count > 0)
            {
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