using CrazyMusicians.Dto;
using CrazyMusicians.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace CrazyMusicians.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MusiciansController : ControllerBase
    {

        //tüm listeyi getiriyoruz.
        [HttpGet]
        public List<Musician> Get()
        {
            return Data.Musicians();
        }

        // id ye göre geliyor.

        [HttpGet("{id}")]
        public ActionResult<Musician> Get(int id)
        {

            Musician? musician = Data.Musicians().FirstOrDefault(x => x.Id == id);
            if (musician == null)
                return NotFound();

            return musician;


        }

        // yeni bir kişi ekliyoruz. İd yi kendimiz atayamıyoruz. Bu yüzden yeni bir class oluşturdum. İd yi otomatik en yüksek veriyoruz ve ismi de kullanıcı belirliyor.

        [HttpPost]

        public ActionResult<Musician> Post(NewDto dto)
        {
            Musician musician = new Musician()
            {
                Id = Data.Musicians().Max(x => x.Id) + 1,

                Name = dto.Name,

                FunFeature = dto.FunFeature,
                Profession = dto.Profession,


            };

            Data.Musicians().Add(musician);


            return CreatedAtAction("Get", new { id = musician.Id }, musician);


        }

        // id ye göre güncelleme işlemi

        [HttpPut("{id}")]
        public IActionResult PutKisi(int id, Musician musician)
        {
            if (id != musician.Id)
                return BadRequest();

            Musician? musician1 = Data.Musicians().FirstOrDefault(x => x.Id == id);

            if (musician1 == null)
                return NotFound();

            musician1.Name = musician.Name;
            musician1.Profession = musician.Profession;
            musician1.FunFeature = musician.FunFeature;

            return NoContent();
        }


        //id ye göre silme işlemi

        [HttpDelete("{id:int:min(1)}")]
        public IActionResult DeleteMusician(int id)
        {
            var musicianToRemove = Data.Musicians().FirstOrDefault(m => m.Id == id);
            if (musicianToRemove == null)
            {
                return NotFound($"Müzisyen Id {id} bulunamadı.");
            }
            Data.Musicians().Remove(musicianToRemove);
            return Ok("Musician Deleted Succesfully");
        }


        // fromquery search sorgusu

        [HttpGet("Search")]
        public ActionResult<IEnumerable<Musician>> GetMusiciansBySearch([FromQuery] string search = null)
        {
            var musicians = Data.Musicians();

            if (!string.IsNullOrEmpty(search))
            {

                return BadRequest();

            }

            musicians = musicians.Where(m => m.Name.Contains(search, StringComparison.OrdinalIgnoreCase) ||
                                                 m.Profession.Contains(search, StringComparison.OrdinalIgnoreCase)).ToList();

            return Ok(musicians);
        }












    }
}
