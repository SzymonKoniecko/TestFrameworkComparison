using NUnitProject.Models;
namespace NUnitProject
{
    [TestFixture]
    public class Tests
    {
        private PerformanceMeterDto performanceMeterDto;
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
        [Category("TestCOMMAND")]
        public void TestCOMMAND()
        {
        }
    }
}