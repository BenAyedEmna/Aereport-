using System;
using System.Collections.Generic;
using System.Text;

namespace aereport
{
    public class Aereport
    {
        public string NomAeroport { set; get; }
        public string Code_IATA;
        public string Code_ICAO;

        public Aereport(string nom )
        {
            this.NomAeroport = nom; 
        }
    }
}
