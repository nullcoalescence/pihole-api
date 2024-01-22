namespace pihole_api.Constants
{
    public class Commands
    {
        public const string PiholeEnable = "pihole enable";
        public const string PiholeDisable = "pihole disable";
        public const string PiholeStatus = "pihole status";
        public const string PiholeRestartDns = "pihole restartdns";
        public const string PiholeArpFlush = "pihole arpflush";
        public const string ActiveDhcpLeases = "cat /etc/pihole/dhcp.leases";
    }
}
