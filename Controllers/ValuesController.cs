using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPI.Controllers
{
    [RoutePrefix("api/Values")]
    public class ValuesController : ApiController
    {
        // GET api/values1
        [Route("GetIEnumerable")]
        public IEnumerable<string> GetAll()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values2
        [Route("Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values3
        [Route("Post")]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values4
        [Route("Put")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values5
        [Route("Delete")]
        public void Delete(int id)
        {
        }
    }
}
