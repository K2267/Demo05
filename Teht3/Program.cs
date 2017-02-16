using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht3
{
    class Program
    {
        static void Main(string[] args)
        {
            //create CD (collection)
            Kisat newLap = new Kisat();
            newLap.Driver = "Mauno Hermunen";
            newLap.Model = "KTM";
            newLap.TeamName = "RuffRiders";

            //create new CD objects
            Ajat lap1 = new Ajat("Lap 1", "3:20.102");
            newLap.AddLaps(lap1);
            Ajat lap2 = new Ajat("Lap 2", "3:18.123");
            newLap.AddLaps(lap2);
            Ajat lap3 = new Ajat("Lap 3", "3:17.089");
            newLap.AddLaps(lap3);
            Ajat lap4 = new Ajat("Lap 4", "3:18.002");
            newLap.AddLaps(lap4);

            newLap.PrintData();
            Console.ReadLine();
        }

    }
}
