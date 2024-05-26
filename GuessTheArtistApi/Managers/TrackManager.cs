using GuessTheArtist;

namespace GuessTheArtistApi.Managers
{
    internal class TrackManager
    {
        private Artist _artist;

        public TrackManager(Artist artist)
        {
            _artist = artist;
        }

        public bool IsTheArtist(string nameArtiste)
        {
            return _artist.Name == nameArtiste;
        }
    }
}
