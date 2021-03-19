using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyApplicationUsingApi.Models
{
    public class League
    {
        [JsonProperty("standard")]
        public IList<Standard> Standard { get; set; }

        [JsonProperty("africa")]
        public IList<object> Africa { get; set; }

        [JsonProperty("sacramento")]
        public IList<object> Sacramento { get; set; }

        [JsonProperty("vegas")]
        public IList<object> Vegas { get; set; }

        [JsonProperty("utah")]
        public IList<object> Utah { get; set; }
    }
}
