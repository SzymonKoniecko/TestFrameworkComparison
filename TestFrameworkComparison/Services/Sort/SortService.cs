using TestFrameworkComparison.Data;
using TestFrameworkComparison.Helpers;

namespace TestFrameworkComparison.Services.Sort
{
    public class SortService
    {
        private ISortService _sortService;

        public SortService(ISortService sortService)
        {
            _sortService = sortService;
        }
        public void ExecuteSort(int fileNumber)
        {
            if (_sortService == null)
                throw new InvalidOperationException("NO STRATEGY");
            if (fileNumber < 0 && fileNumber > 2)
                throw new InvalidOperationException("INVALID file number");
            _sortService.SortNumbersToCorrectOrder(FileReaderHelper.ReadNumbersFromFileToArray(DataPath.GetSortingPaths()[fileNumber]));
        }
    }
}
