﻿using BenchmarkDotNet.Attributes;
using TestFrameworkComparison.Helpers;

namespace TestFrameworkComparison.Runners
{
    public static class NUnitTestRunner
    {
        private static string BASE_COMMAND = "dotnet test --filter ";
        [Benchmark]
        public static void Run(string script)
        {
            Console.WriteLine(PowerShellHelper.Command(BASE_COMMAND + script));
        }
    }
}