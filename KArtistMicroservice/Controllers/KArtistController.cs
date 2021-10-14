using KArtistMicroservice.Models;
using KArtistMicroservice.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace KArtistMicroservice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KArtistController : ControllerBase
    {
        private readonly IKArtistService _kArtistService;

        public KArtistController(IKArtistService kArtistService)
        {
            _kArtistService = kArtistService;
        }

        // GET: api/<KArtistController>
        [HttpGet]
        public IActionResult Get()
        {
            var result = _kArtistService.GetKArtists();
            return Ok(result);
        }

        // GET api/<KArtistController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var result = _kArtistService.GetKArtistById(id);
            return Ok(result);
        }

        // POST api/<KArtistController>
        [HttpPost]
        public IActionResult Post([FromBody] KArtist kArtist)
        {
            if (kArtist != null)
            {
                _kArtistService.AddKArtist(kArtist);
            }

            return Ok();
        }

        // PUT api/<KArtistController>
        [HttpPut]
        public IActionResult Put([FromBody] KArtist kArtist)
        {
            if (kArtist != null)
            {
                _kArtistService.UpdateKArtist(kArtist);
            }

            return Ok();
        }

        // DELETE api/<KArtistController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _kArtistService.DeleteKArtist(id);
            return Ok();
        }
    }
}
