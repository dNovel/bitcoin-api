using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BitcoinInfo.API;

namespace BitcoinInfo.Controllers
{
    [ApiVersion("0.1")]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class BCPriceController : Controller
    {
        // GET api/bitcoincourse
        [MapToApiVersion("0.1")]
        [HttpGet(Name = "GetCurrentCourse")]
        public IActionResult Get()
        {
            BitcoinCourse btcCourse = new BitcoinCourse();
            var res = btcCourse.GetCurrentBtcCourse();

            return Ok(res);
        }

        // GET api/bitcoincourse/123456
        [HttpGet("{id}", Name = "GetCourseAtTime")]
        public IActionResult Get(int time)
        {
            BitcoinCourse btcCourse = new BitcoinCourse();
            var res = btcCourse.GetBtcCourseAtTime(time);

            return Ok(res);
        }

        // POST api/bitcoincourse
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/bitcoincourse/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/bitcoincourse/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
