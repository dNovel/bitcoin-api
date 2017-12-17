// <copyright file="BitcoinCourse.cs" company="Dominik Steffen">
// Please do not change anything without asking for permission. No warranty as this is private code.
// </copyright>

namespace BitcoinInfo.API
{
    using System;
    using System.Threading.Tasks;
    using BitcoinInfo.Models;
    using BitcoinInfo.Provider;
    using Newtonsoft.Json;

    /// <summary>
    /// The implementation of an controller and API
    /// </summary>
    public class BitcoinCourse : IBitcoinCourse
    {
        /// <summary>
        /// A method to get the price at a specific time
        /// </summary>
        /// <param name="time"></param>
        /// <returns></returns>
        public async Task<string> GetBtcCourseAtTime(int time)
        {
            try
            {
                IProvider provider = new BlockchainInfo();
                var res = await provider.GetExchangeRate();

                string sObj = string.Empty;
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

        /// <summary>
        /// Get the current course
        /// </summary>
        /// <returns></returns>
        public async Task<string> GetCurrentBtcCourse()
        {
            try
            {
                IProvider provider = new BlockchainInfo();
                var res = await provider.GetExchangeRate();

                string sObj = string.Empty;
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