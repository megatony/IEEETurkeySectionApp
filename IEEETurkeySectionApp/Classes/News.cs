using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEEETurkeySectionApp.Classes
{
    public class News
    {
        [JsonProperty(PropertyName = "id")]
        public string id { get; set; }

        [JsonProperty(PropertyName = "header")]
        public string header { get; set; }

        [JsonProperty(PropertyName = "content")]
        public string content { get; set; }

        [JsonProperty(PropertyName = "writer")]
        public string writer { get; set; }

        [JsonProperty(PropertyName = "__createdAt")]
        public DateTimeOffset date { get; set; }
    }
}
