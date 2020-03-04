using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using Newtonsoft.Json;

namespace kilr_application
{
    class API
    {
        public API() { }

        public T Get<T>(String endpoint)
        {
            var json = new WebClient().DownloadString("http://i430228.hera.fhict.nl/api/" + endpoint + ".php");

            return JsonConvert.DeserializeObject<T>(json);
        }
    }
}
