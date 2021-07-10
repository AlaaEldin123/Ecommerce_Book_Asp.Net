using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bookss.Bl;
using Microsoft.AspNetCore.Mvc;
using Domains;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Bookss.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemsApiController : ControllerBase
    {
        IItemService ItemService;
        public ItemsApiController(IItemService itemService)
        {
            ItemService = itemService;  
        }
        // GET: api/<ItemsApiController>
        [HttpGet]
        public IEnumerable<VwItemCategories> Get()
        {
            return  ItemService.GetAllItems();
        }

        // GET api/<ItemsApiController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ItemsApiController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ItemsApiController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ItemsApiController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
