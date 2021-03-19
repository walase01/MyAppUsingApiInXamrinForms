using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyApplicationUsingApi.Models
{
    public class Standard
    {
        [JsonProperty("isNBAFranchise")]
        public bool IsNBAFranchise { get; set; }

        [JsonProperty("isAllStar")]
        public bool IsAllStar { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("altCityName")]
        public string AltCityName { get; set; }

        [JsonProperty("fullName")]
        public string FullName { get; set; }

        [JsonProperty("tricode")]
        public string Tricode { get; set; }

        [JsonProperty("teamId")]
        public string TeamId { get; set; }

        [JsonProperty("nickname")]
        public string Nickname { get; set; }

        [JsonProperty("urlName")]
        public string UrlName { get; set; }

        [JsonProperty("teamShortName")]
        public string TeamShortName { get; set; }

        [JsonProperty("confName")]
        public string ConfName { get; set; }

        [JsonProperty("divName")]
        public string DivName { get; set; }
    }
}
