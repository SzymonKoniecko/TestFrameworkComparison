using NUnitProject.Models;
using TestFrameworkComparison.Services.Sort;
namespace NUnitProject
{
    [TestFixture]
    public class SortTest
    {
        private PerformanceMeterDto performanceMeterDto;
        private SortService sortService;
        [SetUp]
        public void Setup()
        {
            performanceMeterDto = new PerformanceMeterDto();
            performanceMeterDto.StartTest();
        }
        [TearDown]
        public void TearDown()
        {
            performanceMeterDto.EndTest();
        }
        [Test]
        public void Quick0()
        {
            sortService = new(new QuickSortService());
            var result = sortService.ExecuteSort(0);
            Assert.AreEqual(50, result.Length);
        }
        [Test]
        public void Quick1()
        {
            sortService = new(new QuickSortService());
            var result = sortService.ExecuteSort(1);
            Assert.AreEqual(5000, result.Length);
        }
        [Test]
        public void Quick2()
        {
            sortService = new(new QuickSortService());
            var result = sortService.ExecuteSort(2);
            Assert.AreEqual(500000, result.Length);
        }
        [Test]
        public void Bubble0()
        {
            sortService = new(new BubbleSortService());
            var result = sortService.ExecuteSort(0);
            Assert.AreEqual(50, result.Length);
        }
        [Test]
        public void Bubble1()
        {
            sortService = new(new BubbleSortService());
            var result = sortService.ExecuteSort(1);
            Assert.AreEqual(5000, result.Length);
        }
        [Test]
        public void Bubble2()
        {
            sortService = new(new BubbleSortService());
            var result = sortService.ExecuteSort(0);
            Assert.AreEqual(50, result.Length);
        }
    }
}