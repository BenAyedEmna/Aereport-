using System;
using System.Collections.Generic;
using System.Text;

namespace aereport
{
    enum PositionSuivie
    {
        avion_sur_tapis,
        avion_en_cours_de_planner,
        avion_dans_le_ciel,
        avion_en_cours_atterissage
    }
    class Position
    {
        private PositionSuivie position_suivie;
        private DateTime temps ; 
    }
}
