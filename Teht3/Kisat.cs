using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht3
{
    class Kisat
    {
        public string Driver { get; set; }
        public string TeamName { get; set; }
        public string Model { get; set; }
        private List<Ajat> laps;

        public Kisat(string driver, string model, string teamname)
        {
            Driver = driver;
            Model = model;
            TeamName = teamname;
        }

        public Kisat()
        {
            laps = new List<Ajat>();
        }
        /// <summary>
        /// Add song to collection
        /// </summary>
        /// <param name="Laps">Laps to add</param>
        public void AddLaps(Ajat lap)
        {
            laps.Add(lap);
        }

        public void PrintData()
        {
            Console.WriteLine("HAMULA Motocross: ");

            Console.WriteLine("- Driver: " + Driver + "\n- Team: " + TeamName + "\n- ´Motorbike: " + Model +  "\nLaps: ");
            foreach (Kisat laps in laps)
            {
                Console.WriteLine(laps.ToString());
            }
        }

        public override string ToString()
        {
            return " - "; 
        }
    }
}