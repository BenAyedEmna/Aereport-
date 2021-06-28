using System;
using System.Collections.Generic;
using System.Text;

namespace aereport
{
    public class Aereport
    {
        public string NomAeroport { set; get; }
        public string CodeIATA { set; get; }
        public string CodeICAO { set; get; }

        public Aereport(string nom)
        {
            this.NomAeroport = nom; 
        }
    }
}
