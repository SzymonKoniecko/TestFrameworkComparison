using TestFrameworkComparison.Enums;

namespace TestFrameworkComparison.Models
{
    public class PerformanceModel
    {
        public long StartMemory { get; set; }
        public long EndMemory { get; set; }
        public long DifferenceMemory { get; set; }
        public TimeSpan Elapsed { get; set; }
        public FrameworkEnum Framework { get; set; }
    }
}
