using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bookss.Bl;
using Domains;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Bookss.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryApiController : ControllerBase
    {
        /// <summary>
        /// we inject the ICategoryService that we created in ClsCategories.
        /// </summary>
        ICategoryService CategoryService;
        public CategoryApiController(ICategoryService categoryService)
        {
            CategoryService = categoryService;
        }
        // GET: api/<CategoryApi>
        [HttpGet]
        public IEnumerable<TbCategory> Get()
        {
            return CategoryService.GetAll();
        }

        // GET api/<CategoryApi>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<CategoryApi>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<CategoryApi>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<CategoryApi>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
