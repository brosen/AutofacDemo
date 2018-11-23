using System.Collections.Generic;
using AutofacDemo.Model;
using Microsoft.AspNetCore.Mvc;

namespace AutofacDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AutoFacTestController : ControllerBase
    {
        private readonly ISomeModel _someModel;

        public AutoFacTestController(ISomeModel someModel)
        {
            _someModel = someModel;
        }
        // GET: api/AutoFacTest
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { _someModel.GetSomeString(), "value1", "value2" };
        }

        // GET: api/AutoFacTest/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/AutoFacTest
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/AutoFacTest/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
