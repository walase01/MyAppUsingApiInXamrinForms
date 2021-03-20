using MyApplicationUsingApi.ViewModels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyApplicationUsingApi.Models
{
    public class TeamsInformation:BaseViewModel
    {
        [JsonProperty("pubDateTime")]
        public string PubDateTime { get; set; }

        [JsonProperty("igorPath")]
        public string IgorPath { get; set; }

        [JsonProperty("xslt")]
        public string Xslt { get; set; }

        [JsonProperty("xsltForceRecompile")]
        public string XsltForceRecompile { get; set; }

        [JsonProperty("xsltInCache")]
        public string XsltInCache { get; set; }

        [JsonProperty("xsltCompileTimeMillis")]
        public string XsltCompileTimeMillis { get; set; }

        [JsonProperty("xsltTransformTimeMillis")]
        public string XsltTransformTimeMillis { get; set; }

        [JsonProperty("consolidatedDomKey")]
        public string ConsolidatedDomKey { get; set; }

        [JsonProperty("endToEndTimeMillis")]
        public string EndToEndTimeMillis { get; set; }
    }
}
