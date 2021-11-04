using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationMedecin
{ //classe abstraite qui implemente un Medecin
    // avec deux methodes abstraites
    public abstract class Medecin
    {
        public string Matricule { get; set; }
        public string Prenom { get; set; }
        public string Nom { get; set; }
        public int NbreAnneeService { get; set; } 
        public abstract void Consultation();
        public abstract void Soigner();
    }
}
