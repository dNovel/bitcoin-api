// <copyright file="IProvider.cs" company="Dominik Steffen">
// Please do not change anything without asking for permission. No warranty as this is private code.
// </copyright>

namespace BitcoinInfo.Provider
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using BitcoinInfo.Models;

    /// <summary>
    /// Implementation of a service provider
    /// </summary>
    public interface IProvider
    {
        /// <summary>
        /// Gets the API key
        /// </summary>
        /// <returns></returns>
        string GetApiKey();

        /// <summary>
        /// Gets the base URI address
        /// </summary>
        /// <returns></returns>
        string GetBaseUri();

        /// <summary>
        /// Gets the current exchange rate
        /// </summary>
        /// <returns></returns>
        Task<List<CoursePacket>> GetExchangeRate();
    }
}