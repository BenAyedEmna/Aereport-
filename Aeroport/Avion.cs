using System;
using System.Collections.Generic;
using System.Text;

namespace aereport
{
    public class Avion
    {
        public string Nom { set; get; }
        public int AnneeConstruction { set; get; }
        public string HistoriqueDeMaintenance { set; get; }
        public string Type { set; get; }
        public int CapaciteMaximal { set; get; }
        public Categorie Categorie { set; get; }

        public Avion(string nom , int annee , string type , int max )
        {
            this.Nom = nom;
            this.AnneeConstruction = annee;
            this.Type = type;
            this.CapaciteMaximal = max; 
        }

    }
}
