using Newtonsoft.Json;
using System.Diagnostics;

namespace NUnitProject.Models
{
    public class PerformanceMeterDto
    {
        private static Stopwatch _stopwatch = new Stopwatch();
        public long StartMemory { get; private set; }
        public long EndMemory { get; private set; }
        public TimeSpan Elapsed { get; private set; }
        public void StartTest()
        {
            _stopwatch.Start();
            StartMemory = GC.GetTotalMemory(true);
        }
        public void EndTest()
        {
            _stopwatch.Stop();
            EndMemory = GC.GetTotalMemory(true);
            Elapsed = _stopwatch.Elapsed;
            TestContext.Out.WriteLine(
                JsonConvert.SerializeObject(this)
                );
        }
    }
}
