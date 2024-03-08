namespace TestFrameworkComparison.Models
{
    public class PerformanceModel
    {
        public long StartMemory { get; set; }
        public long EndMemory { get; set; }
        public TimeSpan Elapsed { get; set; }
    }
}
