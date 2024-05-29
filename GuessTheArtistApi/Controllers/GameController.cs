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

        [HttpGet("Data")]
        public ActionResult<IEnumerable<string>> Data()
        {
            var data = _dataManager.GetData();
            return Ok(data);
        }

        [HttpGet("Genres")]
        public ActionResult<IEnumerable<string>> Genres()
        {
            var data = _dataManager.GetGenres();
            return Ok(data);
        }

        [HttpGet("RandomArtistsByGenre/{genre}")]
        public ActionResult<IEnumerable<string>> RandomArtistsByGenre(string genre)
        {
            var data = _dataManager.GetRandomArtistsByGenre(genre);
            return Ok(data);
        }

        [HttpGet("ArtistsByGenre/{genre}")]
        public ActionResult<IEnumerable<string>> ArtistsByGenre(string genre)
        {
            var data = _dataManager.GetArtistsByGenre(genre);
            return Ok(data);
        }

        [HttpGet("ArtistByName")]
        public ActionResult<IEnumerable<string>> ArtistByName(string artist)
        {
            var data = _dataManager.GetArtistByName(artist);
            return Ok(data);
        }
    }
}
