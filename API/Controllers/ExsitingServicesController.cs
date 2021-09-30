using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DTO;
using BL;

namespace API.Controllers
{
    [System.Web.Http.Cors.EnableCors(origins: "*", headers: "*", methods: "*")]
    public class ExsitingServicesController : ApiController
    {
        // GET: api/ExsitingServices
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/ExsitingServices/5
        public string Get(int id)
        {
            return "value";
        }
        [HttpPost]
        [Route("api/ExsitingServices/AddService")]
        public void AddService([FromBody]ExistingServicesDTO serviceDTO)
        {
            new ExistingServicesBL().AddService(serviceDTO);
        }
        // POST: api/ExsitingServices
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/ExsitingServices/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/ExsitingServices/5
        public void Delete(int id)
        {
        }
    }
}
