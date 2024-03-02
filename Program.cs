using TestFrameworkComparison.Data;
using TestFrameworkComparison.Helpers;

namespace TestFrameworkComparison
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FileReaderHelper.ReadNumbersFromFile(DataPath.GetSortingPaths()[2]);
        }
    }
}
