using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace apitesting.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "Timo", "Sbrzesny" };
        }

        //// GET api/values/5
        //[HttpGet("{id}")]
        //public ActionResult<string> Get(int id)
        //{
        //    return "value";
        //}

        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            switch (id)
            {
                case 1: return "value";
                case 2: return "yolo";
                default: return "valü";
            }
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
            var thread = new Thread(new ThreadStart(() => Thread.Sleep(5000)));
            thread.Start();
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
            throw new OutOfMemoryException("yolo breaker");
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            Console.WriteLine("drop it like its hot");
        }
    }
}
