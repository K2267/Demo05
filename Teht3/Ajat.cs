using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht3
{
    class Ajat : Kisat
    {
        public string Lap { get; set; }
        public string Laptime { get; set; }

        //constructor
        public Ajat(string lap, string laptime)
        //: base()
        {
            Lap = lap;
            Laptime = laptime;
        }


        public override string ToString()
        {
            return base.ToString() + Lap + ", " + Laptime + " min";
        }

    }
}
