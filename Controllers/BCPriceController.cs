// <copyright file="BCPriceController.cs" company="Dominik Steffen">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace BitcoinInfo.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using BitcoinInfo.API;
    using Microsoft.AspNetCore.Mvc;

    /// <summary>
    /// The controller answering the API calls
    /// </summary>
    [ApiVersion("0.1")]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class BCPriceController : Controller
    {
        /// <summary>
        /// GET api/bitcoincourse
        /// </summary>
        /// <returns></returns>
        [MapToApiVersion("0.1")]
        [HttpGet(Name = "GetCurrentCourse")]
        public IActionResult Get()
        {
            BitcoinCourse btcCourse = new BitcoinCourse();
            var res = btcCourse.GetCurrentBtcCourse();

            return this.Ok(res);
        }

        /// <summary>
        /// GET api/bitcoincourse/123456
        /// </summary>
        /// <param name="time"></param>
        /// <returns></returns>
        [HttpGet("{id}", Name = "GetCourseAtTime")]
        public IActionResult Get(int time)
        {
            BitcoinCourse btcCourse = new BitcoinCourse();
            var res = btcCourse.GetBtcCourseAtTime(time);

            return this.Ok(res);
        }

        /// <summary>
        /// POST api/bitcoincourse
        /// </summary>
        /// <param name="value"></param>
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        /// <summary>
        /// PUT api/bitcoincourse/5
        /// </summary>
        /// <param name="id"></param>
        /// <param name="value"></param>
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        /// <summary>
        /// DELETE api/bitcoincourse/5
        /// </summary>
        /// <param name="id"></param>
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
