using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Survivor.Context;
using Survivor.Dto;
using Survivor.Models;

namespace Survivor.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompetitorController : ControllerBase
    {
        private readonly CompetitorCategoryContext _db;

        public CompetitorController(CompetitorCategoryContext db)
        {
            _db = db;
        }

        [HttpGet]
        public IActionResult GetAllCompetitors()
        {
            var competitors = _db.Competitors.ToList();

            return Ok(competitors);


        }
        [HttpGet("{id}")]
        public IActionResult GetCompetitor(int id)
        {
            var competitor = _db.Competitors.Find(id);
            return Ok(competitor);
        }

        [HttpGet("categories/{categoryId}")]
        public IActionResult GetCompetitorsByCategory(int categoryId)
        {
            var competitors = _db.Competitors.Where(x => x.CategoryId == categoryId).ToList();
            return Ok(competitors);
        }

        [HttpPost]

        public ActionResult CreateCompetitor ([FromBody] CreateCompetitorDto createdto)
          
        {
            if (!ModelState.IsValid) 
                return BadRequest();

            Category? category = _db.Categories.Find(createdto.CategoryId);

            if(category == null)
                Console.WriteLine("böyle bir kategori bulunmuyor");

            Competitor competitor = new Competitor
            {
                FirstName = createdto.FirstName,
                LastName = createdto.LastName,
                CategoryId = createdto.CategoryId,
            



            };

            _db.Competitors.Add(competitor);

            _db.SaveChanges();

            return Created();



        
        }


        [HttpPut("{id}")]
        public IActionResult UpdateCompetitor(int id, Competitor updateCompetitorDto)
        {
            Competitor? competitor = _db.Competitors.Find(id);

            if (competitor == null)
                Console.WriteLine("böyle bir yarışmacı bulunmuyor");

            competitor.FirstName = updateCompetitorDto.FirstName;
            competitor.LastName = updateCompetitorDto.LastName;
            competitor.CategoryId = updateCompetitorDto.CategoryId;

            _db.Competitors.Update(competitor);
            _db.SaveChanges();
            return Ok("Güncelleme başarılı");
        }

        [HttpDelete("{id}")]
        public IActionResult RemoveCompetitor(int id)
        {
            var competitor = _db.Competitors.Find(id);
            _db.Remove(competitor);
            _db.SaveChanges();
            return Ok("Yarışmacı silindi.");
        }

    }
}
