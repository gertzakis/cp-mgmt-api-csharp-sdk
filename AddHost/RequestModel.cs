using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace AddHost
{
    [Serializable]
    class RequestModel
    {
        [JsonProperty("name")]
        public string HostName { get; set; }

        [JsonProperty("ip-address")]
        public string HostIP { get; set; }

        [JsonProperty("color", NullValueHandling = NullValueHandling.Ignore)]
        public string Color { get; set; }
    }
}
