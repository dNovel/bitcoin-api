namespace BitcoinInfo.API
{
    using System;
    using BitcoinInfo.Provider;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;

    public class BitcoinCourse : IBitcoinCourse
    {
        public async Task<string> GetBtcCourseAtTime(int time)
        {
            try
            {
                IProvider provider = new CoinbaseProvider();
                var res = await provider.GetExchangeRate();
                return res.ToString();
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        public async Task<string> GetCurrentBtcCourse()
        {
            try
            {
                IProvider provider = new CoinbaseProvider();
                var res = await provider.GetExchangeRate();
                return res.ToString();
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }
    }
}