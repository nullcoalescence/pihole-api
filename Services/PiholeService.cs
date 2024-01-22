
using pihole_api.Constants;

namespace pihole_api.Services
{
    public class PiholeService : IPiholeService
    {
        private readonly ILogger<PiholeService> _logger;
        private readonly IShellService _shellService;

        public PiholeService(ILogger<PiholeService> logger, IShellService shellService)
        {
            _logger = logger;
            _shellService = shellService;
        }

        public async Task<string> Enable()
        {
            var result = await _shellService.ExecuteShellCommandAsync(Commands.PiholeEnable);
            return result;
        }

        public async Task<string> Disable()
        {
            var result = await _shellService.ExecuteShellCommandAsync(Commands.PiholeDisable);
            return result;
        }

        public async Task<string> Status()
        {
            var result = await _shellService.ExecuteShellCommandAsync(Commands.PiholeStatus);
            return result;
        }

        public async Task<string> RestartDns()
        {
            var result = await _shellService.ExecuteShellCommandAsync(Commands.PiholeRestartDns);
            return result;
        }

        public async Task<string> ArpFlush()
        {
            var result = await _shellService.ExecuteShellCommandAsync(Commands.PiholeArpFlush);
            return result;
        }

        public async Task<string> GetActiveDhcpLeases()
        {
            var result = await _shellService.ExecuteShellCommandAsync(Commands.ActiveDhcpLeases);
            return result;
        }

        public async Task<bool> DeviceHasActiveDhcpLease()
        {
            var result = await _shellService.ExecuteShellCommandAsync(Commands.ActiveDhcpLeases);
            return true;
        }

    }
}
