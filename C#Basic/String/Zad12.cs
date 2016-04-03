using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String
{
    public class Zad12
    {
        public static void UlrConventor(string urladress)
        {
            StringBuilder protocol = new StringBuilder();
            protocol.Append("[protocol] = ");
            StringBuilder server = new StringBuilder();
            server.Append("[server] = ");
            StringBuilder resource = new StringBuilder();
            resource.Append("[resource] = ");
            int foundprotocol = urladress.IndexOf(":",0);
            protocol.Append('"');
            protocol.Append(urladress.Substring(0,foundprotocol));
            protocol.Append('"');

            int foundserver = urladress.IndexOf("/", 0);
            int brfoundserver = 0;
            while (brfoundserver<2)
            {
                foundserver = urladress.IndexOf("/", foundserver+1);
                brfoundserver++;
            }
            server.Append('"');
            server.Append(urladress.Substring(foundprotocol,foundserver - foundprotocol).Trim(':','/'));
            server.Append('"');

            resource.Append('"');
            resource.Append(urladress.Substring(foundserver));
            resource.Append('"');

            Console.WriteLine(protocol.ToString());
            Console.WriteLine(server.ToString());
            Console.WriteLine(resource.ToString());
        }
    }
}
