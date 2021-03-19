using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyApplicationUsingApi.Models
{
    public class TeamsList
    {
        [JsonProperty("_internal")]
        public TeamsInformation TeamsInformation { get; set; }

        [JsonProperty("league")]
        public League League { get; set; }
    }
}
