using BenchmarkDotNet.Attributes;
using NUnitProject.Models;
namespace NUnitProject
{
    [TestFixture]
    [MemoryDiagnoser]
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
        public void Test1() => Assert.IsTrue(true);
        [Test]
        [Category("TestCommand")]
        public void TestCommand()
        {
        }
    }
}