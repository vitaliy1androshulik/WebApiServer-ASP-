using Data.Data;
using Data.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApiServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MercedesesController : ControllerBase
    {
        private readonly CatalogDbContext context;
        public MercedesesController(CatalogDbContext context)
        {
            this.context = context;
        }
        [HttpGet("all")]
        public IActionResult GetAll() 
        {
            return Ok(context.Mercedeses.ToList());
        }
        [HttpGet]
        public IActionResult Get(int id)
        {
            var mercedes = context.Mercedeses.Find(id);
            if (mercedes == null) return NotFound();

            return Ok(mercedes);
        }

        [HttpPost]
        public IActionResult Create(Mercedes model)
        {
            if (!ModelState.IsValid) return BadRequest();

            context.Mercedeses.Add(model);
            context.SaveChanges();

            return Ok();
        }

        [HttpPut]
        public IActionResult Edit(Mercedes model)
        {
            if (!ModelState.IsValid) return BadRequest();

            context.Mercedeses.Update(model);
            context.SaveChanges();

            return Ok();
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var mercedes = context.Mercedeses.Find(id);
            if (mercedes == null) return NotFound();

            context.Mercedeses.Remove(mercedes);
            context.SaveChanges();

            return Ok();
        }
    }
}
