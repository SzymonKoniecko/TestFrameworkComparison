namespace TestFrameworkComparison.Helpers
{
    public static class PathHelper
    {
        private static string BASE_PATH = GetBasePath();
        private const string SORT_DATA = "\\Data\\Sort";
        public static List<string> GetSortingPaths()
        {
            int[] lenghts = [50, 5000, 500000];
            var paths = new List<string>();
            foreach (var item in lenghts)
            {
                paths.Add(Path.Combine(GetBasePath() + SORT_DATA, $"randomNumbers{item}.txt"));
            }
            return paths;
        }
        static string GetBasePath()
        {
            string executedLoc = System.Reflection.Assembly.GetExecutingAssembly().Location;

            string[] catalogs = executedLoc.Split("\\");
            string basePath = "";
            for (int i = 0; i < catalogs.Length; i++)
            {
                if (i + 1 < catalogs.Length)
                {
                    basePath += i == 0 ? catalogs[i] : "\\" + catalogs[i];
                    if (catalogs[i].Equals("TestFrameworkComparison"))
                    {
                        return basePath + "\\" + catalogs[i];
                    }
                }
            }
            throw new Exception("CANNOT FIND BASE PATH");
        }
        public static string GetNUnitProjectPath()
        {
            return Path.Combine(BASE_PATH + "NUnitProject");
        }
    }
}