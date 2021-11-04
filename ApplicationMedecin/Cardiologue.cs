using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationMedecin
{
    public class Cardiologue : Medecin,IComparable

    {
        public int NbrePatients { get; set; }
        public string Poste { get; set; }
        // constructeur de la classe
        public Cardiologue(string Matricule,string Prenom,string Nom,
            int NbreAnneeService,int NbrePatients,string Poste):base()
        {
            this.Matricule = Matricule;
            this.Prenom = Prenom;
            this.Nom = Nom;
            this.NbreAnneeService = NbreAnneeService;
            this.NbrePatients = NbrePatients;
            this.Poste = Poste;

        }
        //la methode ToString()
        public override string ToString()
        {
            return "Matricule: " + Matricule + "\nPrenom: " + Prenom + "\nNom: " + Nom+
                   "\nNombre Annee Service: "+NbreAnneeService+"\nNbrePatients: "+NbrePatients+
                     "\nPoste: "+Poste;
        }
        public override void Consultation()
        {
            Console.WriteLine("je consulte en cardiologie");
        }

        public override void Soigner()
        {
            Console.WriteLine("Je diagnostique des problemes cardiaques,operations....");
        }

        public int CompareTo(object obj)
        {
            Cardiologue c = obj as Cardiologue;
            if (c != null)
            {
                return NbreAnneeService.CompareTo(c.NbreAnneeService);
            }
            else
            {
                throw new ArgumentException("objet is not a Cardiologue");
            }
        }
    }
}
