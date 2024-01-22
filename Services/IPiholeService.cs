namespace pihole_api.Services
{
    public interface IPiholeService
    {
        public Task<string> Enable();
        public Task<string> Disable();
        public Task<string> Status();
        public Task<string> RestartDns();
        public Task<string> ArpFlush();
        public Task<string> GetActiveDhcpLeases();
        public Task<bool> DeviceHasActiveDhcpLease();
    }
}
