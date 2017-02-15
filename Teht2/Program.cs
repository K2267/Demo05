using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht2
{
    class Program
    {
        static void Main(string[] args)
        {
            //create CD (collection)
            CD newCD = new CD();
            newCD.Artist = "Daft Punk";
            newCD.Price = 19.95;
            newCD.Name = "Discovery";

            //create new CD objects
            Biisit song1 = new Biisit ("One More Time", "5:20");
            newCD.AddBiisit(song1);
            Biisit song2 = new Biisit("Face To Face", "4:00");
            newCD.AddBiisit(song2);
            Biisit song3 = new Biisit("Too Long", "10:00");
            newCD.AddBiisit(song3);
            Biisit song4 = new Biisit("Harder, Better, Faster, Stronger", "3:45");
            newCD.AddBiisit(song4);

            newCD.PrintData();
            Console.ReadLine();
        }

    }
}
