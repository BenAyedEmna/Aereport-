using System;
using System.Collections.Generic;
using System.Text;

namespace aereport
{
    public class Avion
    {
        public string Nom;
        public int AnneeConstruction;
        public string HistoriqueDeMaintenance;
        public string TypeAvion;
        public int CapaciteMaximal;
        public Categorie Categorie;     

        public Avion(string nom, int annee , string type , int max )
        {
            this.Nom=nom;
            this.AnneeConstruction = annee;
            this.TypeAvion = type;
            this.CapaciteMaximal = max; 
        }

    }
}
