using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEEETurkeySectionApp.Classes
{
    public class StudentBranch
    
    {
        [JsonProperty(PropertyName = "id")]
        public string id { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string name { get; set; }

        [JsonProperty(PropertyName = "president")]
        public string president { get; set; }

        [JsonProperty(PropertyName = "contact")]
        public string contact { get; set; }

        [JsonProperty(PropertyName = "logo")]
        public string logo { get; set; }
    }
}
