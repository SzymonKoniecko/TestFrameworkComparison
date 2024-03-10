using TestFrameworkComparison.Helpers;
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
            if (isNUnit)
                NUnitTestRunner.Run("Tests.TestCOMMAND");
            if (isXUnit)
                XUnitTestRunner.Run("UnitTest1.TestCOMMAND");
            if (isMsTest)
                MsTestRunner.Run("UnitTest1.TestMethod1");
        }
    }
}