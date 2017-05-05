using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RapportVisite
{
    public partial class MEDECIN
    {
        public string Patronyme
        {
           get   
                { return nom.Trim() + " " + prenom.Trim() ;}
            
        }
    }
}
