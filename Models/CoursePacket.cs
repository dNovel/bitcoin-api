namespace BitcoinInfo.Models
{
    using Newtonsoft.Json;

    public class CoursePacket
    {
        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("15m")]
        public double MinutesOld15 { get; set; }

        [JsonProperty("last")]
        public double Last { get; set; }

        [JsonProperty("buy")]
        public double Buy { get; set; }

        [JsonProperty("sell")]
        public double Sell { get; set; }

        [JsonProperty("symbol")]
        public string Symbol { get; set; }
    }
}