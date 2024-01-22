using System.Diagnostics;

namespace pihole_api.Services
{
    /// <summary>
    /// Runs commands in the system shell (bash) and returns result.
    /// </summary>
    public class ShellService : IShellService
    {
        private ILogger<ShellService> _logger;

        private const string ShellName = "bash";

        public ShellService(ILogger<ShellService> logger)
        {
            _logger = logger;
        }

        public async Task<string> ExecuteShellCommandAsync(string command)
        {
            _logger.LogInformation($"Starting process to execute command in {ShellName} shell: {command}");

            var stopwatch = new Stopwatch();
            stopwatch.Start();

            Process process = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = ShellName,
                    RedirectStandardInput = true,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    UseShellExecute = false
                }
            };

            process.Start();
            await process.StandardInput.WriteLineAsync(command);

            var output = await process.StandardOutput.ReadLineAsync();

            stopwatch.Stop();
            _logger.LogInformation($"Executed command in {stopwatch.Elapsed.TotalSeconds} seconds.");

            return output;
        }
    }
}
