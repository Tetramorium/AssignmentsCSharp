using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment._1.Calculator
{
    public class CurrencyRates
    {
        public double USD { get; set; }
    }

    public class RatesResult
    {
        [JsonProperty("@base")]
        public string Base { get; set; }
        [JsonProperty("date")]
        public DateTime Date { get; set; }
        [JsonProperty("rates")]
        public CurrencyRates Rates { get; set; }
    }
}
