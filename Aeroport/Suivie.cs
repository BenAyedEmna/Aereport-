using System;
using System.Collections.Generic;
using System.Text;

namespace aereport
{
    public class Suivie
    {
        public double Altitude { get; set; }
        public double Lattitude { get; set;  }
        public double Longitude { get; set; }
        public DateTime Temps {get; set;}

        public Suivie(double alt, double lat, double longit , DateTime time )
        {
            this.Altitude = alt;
            this.Lattitude = lat;
            this.Longitude = longit;
            this.Temps = time; 
        }

        public bool Egale(Suivie position)
        {
            if ((Math.Abs(this.Lattitude - position.Lattitude)) < 0.00001 && (Math.Abs(this.Longitude - position.Longitude)) < 0.00001 && (Math.Abs(this.Altitude - position.Altitude)) < 0.00001 && (Math.Abs((this.Temps - position.Temps).TotalSeconds)) < 0.00001)
                return true; 
            else
                return false; 
        }

    }
}
