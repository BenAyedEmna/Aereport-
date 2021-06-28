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
        public string altitude { get; set; }
        public string lattitude { get; set;  }
        public string longitude { get; set; }
        public DateTime temps {get; set;}
    }
}
