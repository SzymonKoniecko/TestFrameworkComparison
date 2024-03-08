using MsTestProject.Models;

namespace MsTestProject
{
    [TestClass]
    public class UnitTest1
    {
        private PerformanceMeterDto performanceMeterDto;
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
        public void TestMethod1()
        {
            Assert.IsNotNull(performanceMeterDto);
        }
    }
}