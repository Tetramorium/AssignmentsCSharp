using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment._2.FlagsOfTheWorld.Model
{
    public class Country
    {
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("flag")]
        public string FlagUrl { get; set; }
        [JsonProperty("translations")]
        public Translations Translations { get; set; }
    }

    public class Translations
    {
        public string de { get; set; }
        public string fr { get; set; }
        public string nl { get; set; }
    }
}
