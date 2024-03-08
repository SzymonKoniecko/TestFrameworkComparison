using Xunit.Abstractions;
using XUnitProject.Models;

namespace XUnitProject
{
    public class UnitTest1 : IDisposable
    {
        private readonly ITestOutputHelper _testOutputHelper;
        private PerformanceMeterDto performanceMeterDto;
        public UnitTest1(ITestOutputHelper testOutputHelper)
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
        public void TestCOMMAND()
        {
            Assert.Null(null);
        }
    }
}