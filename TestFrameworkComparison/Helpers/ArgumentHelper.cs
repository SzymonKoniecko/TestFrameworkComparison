namespace TestFrameworkComparison.Helpers
{
    public static class ArgumentHelper
    {
        public const string AllFrameworks = "-all";
        public const string XUnit = "-xunit";
        public const string NUnit = "-nunit";
        public const string MsTest = "-mstest";
        public const string SORT = "--sort";
        public static string GetSortingTestMethod(string sortingMethod, string sortingSizeOfNumbers)
        {
            switch (sortingMethod)
            {
                case "Quick":
                    return $"SortTest.Quick{sortingSizeOfNumbers}";
                case "Bubble":
                    return $"SortTest.Bubble{sortingSizeOfNumbers}";
                default:
                    throw new ArgumentException("INCORRECT SORTING METHOD");
            }
        }
    }
}
