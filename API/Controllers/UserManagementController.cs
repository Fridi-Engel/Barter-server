using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BL;
using DTO;

namespace API.Controllers
{
    [System.Web.Http.Cors.EnableCors(origins:"*",headers:"*",methods:"*")]
    public class UserManagementController : ApiController
    {
        // GET: api/UserManagement
        [HttpGet]
        public IEnumerable<UserDTO> GetUsers()
        {
            return new UserBL().GetAllUsers();
        }

        [HttpGet]
        public UserDTO Login(string userEmail, string password)
        {
            return new UserBL().GetUser(userEmail, password);
        }
        // GET: api/UserManagement/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/UserManagement
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/UserManagement/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/UserManagement/5
        public void Delete(int id)
        {
        }
    }
}
