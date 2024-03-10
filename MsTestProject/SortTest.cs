using MsTestProject.Models;
using TestFrameworkComparison.Services.Sort;

namespace MsTestProject
{
    [TestClass]
    public class SortTest
    {
        private PerformanceMeterDto performanceMeterDto;
        private SortService sortService;
        [TestInitialize]
        public void TestInitialize()
        {
            performanceMeterDto = new PerformanceMeterDto();
            performanceMeterDto.StartTest();
        }
        [TestCleanup]
        public void TestCleanup()
        {
            Console.Out.WriteLine(performanceMeterDto.EndTest());
        }
        [TestMethod]
        public void Quick0()
        {
            sortService = new(new QuickSortService());
            var result = sortService.ExecuteSort(0);
            Assert.AreEqual(50, result.Length);
        }
        [TestMethod]
        public void Quick1()
        {
            sortService = new(new QuickSortService());
            var result = sortService.ExecuteSort(1);
            Assert.AreEqual(5000, result.Length);
        }
        [TestMethod]
        public void Quick2()
        {
            sortService = new(new QuickSortService());
            var result = sortService.ExecuteSort(2);
            Assert.AreEqual(500000, result.Length);
        }
        [TestMethod]
        public void Bubble0()
        {
            sortService = new(new BubbleSortService());
            var result = sortService.ExecuteSort(0);
            Assert.AreEqual(50, result.Length);
        }
        [TestMethod]
        public void Bubble1()
        {
            sortService = new(new BubbleSortService());
            var result = sortService.ExecuteSort(1);
            Assert.AreEqual(5000, result.Length);
        }
        [TestMethod]
        public void Bubble2()
        {
            sortService = new(new BubbleSortService());
            var result = sortService.ExecuteSort(0);
            Assert.AreEqual(50, result.Length);
        }
    }
}