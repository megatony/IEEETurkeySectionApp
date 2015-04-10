using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEEETurkeySectionApp.Classes
{
    public class Conferences
    {
        [JsonProperty(PropertyName = "id")]
        public string id { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string name { get; set; }

        [JsonProperty(PropertyName = "organizer")]
        public string organizer { get; set; }

        [JsonProperty(PropertyName = "content")]
        public string content { get; set; }

        [JsonProperty(PropertyName = "date")]
        public DateTimeOffset date { get; set; }
    }
}
