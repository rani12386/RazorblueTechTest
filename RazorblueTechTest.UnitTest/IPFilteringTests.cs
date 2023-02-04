using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazorblueTechTest.UnitTest
{
    public class IPAddressTests
    {
        [Theory]
        [InlineData("192.168.0.0/24", "192.168.0.10", true)]
        [InlineData("192.168.0.0/24", "192.168.1.10", false)]


        public void IpAddressFilterTests(string cidraddress, string ipaddress, bool expected)
        {
            Assert.Equal(expected, IPFiltering.IPFiltering.IsInRange(cidraddress, ipaddress));
        }
    }
}
