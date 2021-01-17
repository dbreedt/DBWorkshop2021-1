using Dapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Npgsql;
using orm1.Models;
using System.Collections.Generic;
using System.Data;
using System.Linq;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace orm1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExportController : ControllerBase
    {
        private readonly IConfiguration _config;

        public ExportController(IConfiguration config)
        {
            _config = config;
        }

        // GET: api/<ExportController>
        [HttpGet]
        public IEnumerable<Export> Get()
        {
            List<Export> exports = new List<Export>();
            using (IDbConnection db = new NpgsqlConnection(_config.GetValue<string>("ConnectionStrings:Exports")))
            {
                exports = db.Query<Export>("select * from exports").ToList();
            }
            return exports;
        }

        // GET api/<ExportController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ExportController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ExportController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ExportController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
