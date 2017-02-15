using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht2
{
    class CD
    {
        public string Artist { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        private List <Biisit> songs;

        public CD(string artist, double price, string name)
        {
            Artist = artist;
            Price = price;
            Name = name;
        }

        public CD()
        {
            songs = new List<Biisit>();
        }
        /// <summary>
        /// Add song to collection
        /// </summary>
        /// <param name="Biisit">Biisit to add</param>
        public void AddBiisit(Biisit song)
        {
            songs.Add(song);
        }

        public void PrintData()
        {
            Console.WriteLine("CD data: ");
            
            Console.WriteLine("- Artist: " + Artist + "\n- Album name: " + Name + "\n- price: " + Price + " euros \n" + "\nSongs: ");
            foreach (CD songs in songs)
            {
                Console.WriteLine(songs.ToString());
            }
        }

        public override string ToString()
        {
            return " - "; //Tulostetaan "-" ennen kappaletta --korvaa List<Biisit> aiheuttaman nimen
        }
    }
}
