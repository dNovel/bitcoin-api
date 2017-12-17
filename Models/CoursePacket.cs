// <copyright file="CoursePacket.cs" company="Dominik Steffen">
// Please do not change anything without asking for permission. No warranty as this is private code.
// </copyright>

namespace BitcoinInfo.Models
{
    using Newtonsoft.Json;

    /// <summary>
    /// An object representation of a data package
    /// </summary>
    public class CoursePacket
    {
        /// <summary>
        /// Gets or sets the currency
        /// </summary>
        [JsonProperty("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// Gets or sets price 15 minutes before
        /// </summary>
        [JsonProperty("15m")]
        public double MinutesOld15 { get; set; }

        /// <summary>
        /// Gets or sets last price seen
        /// </summary>
        [JsonProperty("last")]
        public double Last { get; set; }

        /// <summary>
        /// Gets or sets buy price
        /// </summary>
        [JsonProperty("buy")]
        public double Buy { get; set; }

        /// <summary>
        /// Gets or sets sell price
        /// </summary>
        [JsonProperty("sell")]
        public double Sell { get; set; }

        /// <summary>
        /// Gets or sets the currency symbol
        /// </summary>
        [JsonProperty("symbol")]
        public string Symbol { get; set; }
    }
}