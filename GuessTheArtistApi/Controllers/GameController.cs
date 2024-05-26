using GuessTheArtist.DataAccess;
using GuessTheArtistApi.Managers;
using Microsoft.AspNetCore.Mvc;

namespace GuessTheArtistApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GameController : ControllerBase
    {
        private DataManager _dataManager = new DataManager();
        private PointsManajer _score = new PointsManajer();

        [HttpGet("GetData")]
        public ActionResult<IEnumerable<string>> GetData()
        {
            var data = _dataManager.GetData();
            return Ok(data);
        }

        [HttpGet("GetGenres")]
        public ActionResult<IEnumerable<string>> GetGenres()
        {
            var data = _dataManager.GetGenres();
            return Ok(data);
        }

        [HttpGet("GetRandomArtistsByGenre/{genre}")]
        public ActionResult<IEnumerable<string>> GetRandomArtistsByGenre(string genre)
        {
            var data = _dataManager.GetRandomArtistsByGenre(genre);
            return Ok(data);
        }

        [HttpGet("GetArtistsByGenre/{genre}")]
        public ActionResult<IEnumerable<string>> GetArtistsByGenre(string genre)
        {
            var data = _dataManager.GetArtistsByGenre(genre);
            return Ok(data);
        }

        [HttpGet("GetArtistByName")]
        public ActionResult<IEnumerable<string>> GetArtistByName(string artist)
        {
            var data = _dataManager.GetArtistByName(artist);
            return Ok(data);
        }
    }
}
