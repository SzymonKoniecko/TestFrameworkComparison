using Newtonsoft.Json;
using TestFrameworkComparison.Enums;
using TestFrameworkComparison.Models;

namespace TestFrameworkComparison.Helpers
{
    public static class PerformanceHelper
    {
        public static PerformanceModel FetchPerformance(string data, FrameworkEnum frameworkEnum)
        {
            var performanceJson = data.Split("#PERFORMANCE_DATA_START ")[1].Split(" #PERFORMANCE_DATA_END")[0];
            if (String.IsNullOrEmpty(performanceJson))
            {
                throw new NullReferenceException($"Missing json from fetched test logs {frameworkEnum}");
            }
            return JsonConvert.DeserializeObject<PerformanceModel>(performanceJson);
        }
    }
}
