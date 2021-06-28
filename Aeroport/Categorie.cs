using System;
using System.Collections.Generic;
using System.Text;

namespace aereport
{
    public class Categorie
    {
        public string nom { set; get; }
        public string description { set; get; }
        public Categorie CategorieGlobale { set; get; }
    }

}
