using TestFrameworkComparison.Helpers;

namespace TestFrameworkComparison.Services.Sort
{
    public class BubbleSortService : ISortService
    {
        public void SortNumbersToCorrectOrder(int[] numbersArray)
        {
            var n = numbersArray.Length;
            for (int i = 0; i < n - 1; i++)
                for (int j = 0; j < n - i - 1; j++)
                    if (numbersArray[j] > numbersArray[j + 1])
                    {
                        var tempVar = numbersArray[j];
                        numbersArray[j] = numbersArray[j + 1];
                        numbersArray[j + 1] = tempVar;
                    }
            PrinterHelper.PrintNumbers(numbersArray);
        }
    }
}
