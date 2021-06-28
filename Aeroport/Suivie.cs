using System;
using System.Collections.Generic;
using System.Text;

namespace aereport
{
   public enum PositionSuivie
    {
        avion_sur_tapis,
        avion_en_cours_de_planner,
        avion_dans_le_ciel,
        avion_en_cours_atterissage
    }

    public class Suivie
    {
        public PositionSuivie position { get; set; }
        public string Altitude { get; set; }
        public string Lattitude { get; set;  }
        public string Longitude { get; set; }
        public DateTime Temps {get; set;}
    }
}
