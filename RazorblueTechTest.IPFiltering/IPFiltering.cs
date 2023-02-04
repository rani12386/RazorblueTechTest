using System.Net;

namespace RazorblueTechTest.IPFiltering
{
    public static class IPFiltering
    {
        public static bool IsInRange(string CIDRaddress, string address)
        {
            string[] parts = CIDRaddress.Split('/');
            long Ipaddress = BitConverter.ToInt32(IPAddress.Parse(address).GetAddressBytes(), 0);
            int Cidr_add = BitConverter.ToInt32(IPAddress.Parse(parts[0]).GetAddressBytes(), 0);
            int Cidr_host = IPAddress.HostToNetworkOrder(-1 << (32 - int.Parse(parts[1])));
            return ((Ipaddress & Cidr_host) == (Cidr_add & Cidr_host));
        }
    }
}