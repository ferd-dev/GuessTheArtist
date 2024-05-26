namespace GuessTheArtistApi.Managers
{
    internal class PointsManajer
    {
        private int _score;
        public PointsManajer()
        {
            _score = 0;
        }

        public void AddScore()
        {
            _score++;
        }

        public int GetScore()
        {
            return _score;
        }
    }
}
