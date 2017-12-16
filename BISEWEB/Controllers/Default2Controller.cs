using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BISEWEB.Controllers
{
    public class Default2Controller : ApiController
    {
        // GET: api/Default2
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Default2/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Default2
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Default2/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Default2/5
        public void Delete(int id)
        {
        }
    }
}
