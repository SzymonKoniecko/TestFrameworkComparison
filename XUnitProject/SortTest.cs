using TestFrameworkComparison.Services.Sort;
using Xunit.Abstractions;
using XUnitProject.Models;

namespace XUnitProject
{
    public class SortTest : IDisposable
    {
        private readonly ITestOutputHelper _testOutputHelper;
        private PerformanceMeterDto performanceMeterDto;
        private SortService sortService;
        public SortTest(ITestOutputHelper testOutputHelper)
        {
            _testOutputHelper = testOutputHelper;
            performanceMeterDto = new PerformanceMeterDto();
            performanceMeterDto.StartTest();
        }

        public void Dispose()
        {
            _testOutputHelper.WriteLine(performanceMeterDto.EndTest());
        }

        [Fact]
        public void Quick0()
        {
            sortService = new(new QuickSortService());
            var result = sortService.ExecuteSort(0);
            Assert.Equal(50, result.Length);
        }
        [Fact]
        public void Quick1()
        {
            sortService = new(new QuickSortService());
            var result = sortService.ExecuteSort(1);
            Assert.Equal(5000, result.Length);
        }
        [Fact]
        public void Quick2()
        {
            sortService = new(new QuickSortService());
            var result = sortService.ExecuteSort(2);
            Assert.Equal(500000, result.Length);
        }
        [Fact]
        public void Bubble0()
        {
            sortService = new(new QuickSortService());
            var result = sortService.ExecuteSort(0);
            Assert.Equal(50, result.Length);
        }
        [Fact]
        public void Bubble1()
        {
            sortService = new(new BubbleSortService());
            var result = sortService.ExecuteSort(1);
            Assert.Equal(5000, result.Length);
        }
        [Fact]
        public void Bubble2()
        {
            sortService = new(new BubbleSortService());
            var result = sortService.ExecuteSort(0);
            Assert.Equal(50, result.Length);
        }
    }
}