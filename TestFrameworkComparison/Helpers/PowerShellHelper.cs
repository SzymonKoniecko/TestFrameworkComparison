using System.Management.Automation;
using System.Text;

namespace TestFrameworkComparison.Helpers
{
    public static class PowerShellHelper
    {
        private static PowerShell ps = PowerShell.Create();
        public static string Command(string script)
        {
            string errorMsg = string.Empty;
            string output = string.Empty;
            ps.AddScript(script);
            ps.AddCommand("Out-String");
            PSDataCollection<PSObject> outputCollection = new();
            ps.Streams.Error.DataAdded += (object sender, DataAddedEventArgs e) =>
            {
                errorMsg = ((PSDataCollection<ErrorRecord>)sender)[e.Index].ToString();
            };
            IAsyncResult result = ps.BeginInvoke<PSObject, PSObject>(null, outputCollection);
            ps.EndInvoke(result);
            StringBuilder sb = new();
            foreach (var outItem in outputCollection)
            {
                sb.AppendLine(outItem.BaseObject.ToString());
            }
            ps.Commands.Clear();
            if (!string.IsNullOrEmpty(errorMsg))
            {
                return errorMsg;
            }
            return sb.ToString().Trim();
        }
    }
}
