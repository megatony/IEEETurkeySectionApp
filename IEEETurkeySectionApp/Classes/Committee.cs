using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEEETurkeySectionApp.Classes
{
    public class Committee
    {
        [JsonProperty(PropertyName = "id")]
        public string id { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string name { get; set; }

        [JsonProperty(PropertyName = "title")]
        public string title { get; set; }

        [JsonProperty(PropertyName = "contact")]
        public string contact { get; set; }

        [JsonProperty(PropertyName = "picture")]
        public string picture { get; set; }
    }
}
