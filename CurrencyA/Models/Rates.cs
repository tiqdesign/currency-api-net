using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CurrencyA.Models
{
    public class Rates
    {
        [Newtonsoft.Json.JsonProperty("GBP", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public  float? GBP { get; set; }
        [Newtonsoft.Json.JsonProperty("HKD", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public  float? HKD { get; set; }
        [Newtonsoft.Json.JsonProperty("IDR", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public  float? IDR { get; set; }
        [Newtonsoft.Json.JsonProperty("ILS", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public  float? ILS { get; set; }
        [Newtonsoft.Json.JsonProperty("DKK", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public  float? DKK { get; set; }
        [Newtonsoft.Json.JsonProperty("INR", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public  float? INR { get; set; }
        [Newtonsoft.Json.JsonProperty("CHF", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public  float? CHF { get; set; }
        [Newtonsoft.Json.JsonProperty("MXN", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public  float? MXN { get; set; }
        [Newtonsoft.Json.JsonProperty("CZK", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public  float? CZK { get; set; }
        [Newtonsoft.Json.JsonProperty("SGD", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public  float? SGD { get; set; }
        [Newtonsoft.Json.JsonProperty("THB", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public  float? THB { get; set; }
        [Newtonsoft.Json.JsonProperty("HRK", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public  float? HRK { get; set; }
        [Newtonsoft.Json.JsonProperty("MYR", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public  float? MYR { get; set; }
        [Newtonsoft.Json.JsonProperty("NOK", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public  float? NOK { get; set; }
        [Newtonsoft.Json.JsonProperty("CNY", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public  float? CNY { get; set; }
        [Newtonsoft.Json.JsonProperty("BGN", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public  float? BGN { get; set; }
        [Newtonsoft.Json.JsonProperty("PHP", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public  float? PHP { get; set; }
        [Newtonsoft.Json.JsonProperty("SEK", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public  float? SEK { get; set; }
        [Newtonsoft.Json.JsonProperty("PLN", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public  float? PLN { get; set; }
        [Newtonsoft.Json.JsonProperty("ZAR", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public  float? ZAR { get; set; }
        [Newtonsoft.Json.JsonProperty("CAD", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public  float? CAD { get; set; }
        [Newtonsoft.Json.JsonProperty("ISK", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public  float? ISK { get; set; }
        [Newtonsoft.Json.JsonProperty("BRL", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public  float? BRL { get; set; }
        [Newtonsoft.Json.JsonProperty("RON", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public  float? RON { get; set; }
        [Newtonsoft.Json.JsonProperty("NZD", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public  float? NZD { get; set; }
        [Newtonsoft.Json.JsonProperty("TRY", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public  float? TRY { get; set; }
        [Newtonsoft.Json.JsonProperty("JPY", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public  float? JPY { get; set; }
        [Newtonsoft.Json.JsonProperty("RUB", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public  float? RUB { get; set; }
        [Newtonsoft.Json.JsonProperty("KRW", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public  float? KRW { get; set; }
        [Newtonsoft.Json.JsonProperty("USD", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public  float? USD { get; set; }
        [Newtonsoft.Json.JsonProperty("HUF", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public  float? HUF { get; set; }
       


    }
}
