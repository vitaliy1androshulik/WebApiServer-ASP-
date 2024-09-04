using AutoMapper;
using Core.Dto;
using Core.Models;
using Data.Data;
using Data.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace WebApiServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MercedesesController : ControllerBase
    {
        private readonly CatalogDbContext context;
        private readonly IMapper mapper;

        public MercedesesController(CatalogDbContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }
        [HttpGet("all")]
        public IActionResult GetAll() 
        {
            var mercedes = mapper.Map<List<MercedesDto>>(context.Mercedeses.ToList());
            return Ok(mercedes.ToList());
        }
        [HttpGet]
        public IActionResult Get(int id)
        {
            var mercedes = context.Mercedeses.Find(id);
            if (mercedes == null) return NotFound();

            context.Entry(mercedes).Reference(x => x.BrandOfCar).Load();
            return Ok(mapper.Map<MercedesDto>(mercedes));
        }

        [HttpPost]
        public IActionResult Create(CreateMercedesModel model)
        {
            if (!ModelState.IsValid) return BadRequest();

            context.Mercedeses.Add(mapper.Map<Mercedes>(model));
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
