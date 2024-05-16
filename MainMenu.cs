using GuessTheArtist.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessTheArtist
{
    internal class MainMenu : IMenu
    {
        private List<Genre> _genres;

        public MainMenu(List<Genre> genres) { 
            _genres = genres;
        }
        public string print()
        {
            PrintHead();
            PrintGenre();
            PrintFoot();

            return ReadEntry();
        }

        private void PrintHead()
        {
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("///////  WELCOME TO GUESS THE ARTIST  ///////");
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("We'll see how well you know your favorite artists... :)");
            Console.WriteLine("---------------------------------------------");
        }

        private void PrintGenre()
        {
            Console.WriteLine("Enter the musical genre: ");

            foreach (Genre genre in _genres)
            {
                Console.WriteLine("- " + genre.Name);
            }
        }

        private void PrintFoot()
        {
            Console.WriteLine("- Press N to End Game");
        }

        private string ReadEntry()
        {
            string entry = Console.ReadLine();
            return entry;
        }
    }
}
