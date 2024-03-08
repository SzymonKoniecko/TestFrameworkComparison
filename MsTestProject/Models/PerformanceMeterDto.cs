using MsTestProject.Enums;
using Newtonsoft.Json;
using System.Diagnostics;

namespace MsTestProject.Models
{
    public class PerformanceMeterDto
    {
        private static Stopwatch _stopwatch = new Stopwatch();
        public long StartMemory { get; private set; }
        public long EndMemory { get; private set; }
        public TimeSpan Elapsed { get; private set; }
        public FrameworkEnum Framework { get; private set; } = FrameworkEnum.MsTest;
        public void StartTest()
        {
            _stopwatch.Start();
            StartMemory = GC.GetTotalMemory(true);
        }
        public string EndTest()
        {
            _stopwatch.Stop();
            EndMemory = GC.GetTotalMemory(true);
            Elapsed = _stopwatch.Elapsed;
            return new string("#PERFORMANCE_DATA_START " +
                JsonConvert.SerializeObject(this) +
                " #PERFORMANCE_DATA_END");
        }
    }
}
