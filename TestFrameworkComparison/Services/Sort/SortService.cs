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
        public int[] ExecuteSort(int fileNumber)
        {
            if (_sortService == null)
                throw new InvalidOperationException("NO STRATEGY");
            if (fileNumber < 0 && fileNumber > 2)
                throw new InvalidOperationException("INVALID file number");
            return _sortService.SortNumbersToCorrectOrder(
                        FileReaderHelper.ReadNumbersFromFileToArray(
                            PathHelper.GetSortingPaths()[fileNumber]
                            )
                        );
        }
    }
}
