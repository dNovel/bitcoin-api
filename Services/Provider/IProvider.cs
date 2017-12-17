namespace BitcoinInfo.Provider
{
    using System;
    using System.Collections.Generic;
    using Microsoft.AspNetCore.Mvc;
    using System.Threading.Tasks;
    using BitcoinInfo.Models;

    public interface IProvider
    {
        string GetApiKey();
        string GetBaseUri();

        Task<List<CoursePacket>> GetExchangeRate();
    }
}