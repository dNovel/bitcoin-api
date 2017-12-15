namespace BitcoinInfo.Provider
{
    using Microsoft.AspNetCore.Mvc;
    using System.Threading.Tasks;

    public interface IProvider
    {
        Task<string> GetExchangeRate();
    }
}