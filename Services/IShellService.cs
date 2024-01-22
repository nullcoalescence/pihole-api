namespace pihole_api.Services
{
    public interface IShellService
    {
        public Task<string> ExecuteShellCommand(string command);
    }
}
