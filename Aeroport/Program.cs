using System;
using System.Collections.Generic;



namespace aereport
{

    class Program
    {
        static void Main(string[] args)
        {

            Aereport aereport1, aereport2, aereport3;
            aereport1 = new Aereport("Aéroport international de Tunis-Carthage");
            aereport2 = new Aereport("Aéroport international de Djerba-Zarzis");
            aereport3 = new Aereport("Aéroport international de Djerba-Zarzis");
            
            Avion avion1, avion2;
            avion1 = new Avion("Airbus A330", 1992, "Avion d'affaires",440);
            avion2 = new Avion("Learjet 45", 1992, "Avion d'affaires", 200);

            PlanVolReel planR1, planR2;
            PlanVolPlanifiee planP1, planP2;







           

        }
    }
}
