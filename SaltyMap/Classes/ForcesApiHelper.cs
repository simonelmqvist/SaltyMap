using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Newtonsoft.Json;
using SaltyMap.Models;

namespace SaltyMap.Classes
{
    public class ForcesApiHelper
    {
        public List<ForcesData> Gather()
        {
            var baseUrl = "https://bc37a263.ngrok.io/maps";
            using (var wc = new WebClient())
            {
                var response = wc.DownloadString(baseUrl);
                var datas = JsonConvert.DeserializeObject<List<ForcesData>>(response);
                return datas;
            }
        }
    }
}
