﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SharedCode
{
    public class Extension
    {
        [JsonProperty("vsix")]
        public string Vsix { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("version")]
        public string Version { get; set; }
    }

    public class VsCodeConfig
    {
        public string VsCode32Url { get; set; }
        public string VsCode32Name { get; set; }
        public string VsCode64Url { get; set; }
        public string VsCode64Name { get; set; }
        [JsonProperty("wpilibExtension")]
        public Extension WPILibExtension { get; set; }
        [JsonProperty("thirdPartyExtensions")]
        public Extension[] ThirdPartyExtensions { get; set; }
    }
}
