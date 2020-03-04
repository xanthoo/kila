using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace kilr_application
{
    class API
    {
        public API() { }

        public void Get(String endpoint)
        {
            var json = new WebClient().DownloadString("http://i430228.hera.fhict.nl/api/" + endpoint + ".php");

            Console.WriteLine(json);
        }
    }
}
