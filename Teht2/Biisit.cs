using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht2
{
    class Biisit : CD

    {
        public string TrackName { get; set; }
        public string Length { get; set; }

        //constructor
        public Biisit(string trackname, string length)
             //: base(Artist, Price)
        {
            TrackName = trackname;
            Length = length;
        }


        public override string ToString()
        {
            return base.ToString() + TrackName + ", " + Length + " min";
        }

    }
}