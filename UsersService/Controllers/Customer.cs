using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using UsersService.Entity;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace UsersService.Controllers
{
    [Route("api/[controller]")]
    public class Customer : Controller
    {
        // GET: api/values
        [HttpGet]
        public IEnumerable<Entity.User> Get()
        {
            return new MockEntity().GetMockUsers()
                .Where( o => o.TypeOfUser == UserType.Customer);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public Entity.User Get(int id)
        {
            return new MockEntity().GetMockUsers()
                .Where( o => o.TypeOfUser == UserType.Customer).ToList().FirstOrDefault();
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
            throw new NotImplementedException();
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
            throw new NotImplementedException();
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
