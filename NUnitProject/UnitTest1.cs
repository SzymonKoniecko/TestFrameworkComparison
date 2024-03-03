using BenchmarkDotNet.Attributes;
using System.Diagnostics;
namespace NUnitProject
{
    [TestFixture]
    [MemoryDiagnoser]
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            Stopwatch sw = new Stopwatch();
        }

        [Test]
        public void Test1() => Assert.Pass();
        [Test]
        [Category("TestCommand")]
        public void TestCommand()
        {
        }
    }
}