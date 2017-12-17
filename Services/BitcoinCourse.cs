namespace BitcoinInfo.API
{
    using System;
    using BitcoinInfo.Provider;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using BitcoinInfo.Models;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class BitcoinCourse : IBitcoinCourse
    {
        public async Task<string> GetBtcCourseAtTime(int time)
        {
            try
            {
                IProvider provider = new BlockchainInfo();
                var res = await provider.GetExchangeRate();

                string sObj = "";
                foreach(CoursePacket cp in res)
                {
                    if(cp.Currency != "USD")
                    {
                        continue;
                    } else
                    {
                        sObj = JsonConvert.SerializeObject(cp);
                    }
                }

                return sObj;
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
                IProvider provider = new BlockchainInfo();
                var res = await provider.GetExchangeRate();

                string sObj = "";
                foreach (CoursePacket cp in res)
                {
                    if (cp.Currency != "USD")
                    {
                        continue;
                    }
                    else
                    {
                        sObj = JsonConvert.SerializeObject(cp);
                    }
                }

                return sObj;
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }
    }
}