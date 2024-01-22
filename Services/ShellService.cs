using System.Diagnostics;

namespace pihole_api.Services
{
    /// <summary>
    /// Runs commands in the system shell (bash) and returns result.
    /// </summary>
    public class ShellService : IShellService
    {
        private ILogger<ShellService> _logger;

        private string _shellName = "bash";

        public ShellService(ILogger<ShellService> logger)
        {
            _logger = logger;
        }

        public async Task<string> ExecuteShellCommand(string command)
        {
            Process process = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = _shellName,
                    RedirectStandardInput = true,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    UseShellExecute = false
                }
            };

            process.Start();
            await process.StandardInput.WriteLineAsync(command);

            var output = await process.StandardOutput.ReadLineAsync();
            return output;
        }
    }
}
