using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationMedecin
{
    public class Chirurgien : Medecin,IComparable

    {
        public int NbreOperation { get; set; }
        public string Poste { get; set; }
        //le constructeur de la classe
        public Chirurgien(string Matricule,string Prenom,string Nom,int NbreAnneeService,
            int NbreOperation,string Poste) : base()
        {
            this.Matricule = Matricule;
            this.Prenom = Prenom;
            this.Nom = Nom;
            this.NbreAnneeService = NbreAnneeService;
            this.NbreOperation = NbreOperation;
            this.Poste = Poste;
        }
        //la methode ToString()
        public override string ToString()
        {
            return "Matricule: " + Matricule + "\nPrenom: " + Prenom + "\nNom: " + Nom +
                   "\nNombre Annee Service: " + NbreAnneeService + "\nNbreOperation: " + NbreOperation +
                     "\nPoste: " + Poste;
        }
        public override void Consultation()
        {
            Console.WriteLine("Je consulte en chirurgie");
        }

        public override void Soigner()
        {
            Console.WriteLine("Je soigne des chirugies");
        }

        public int CompareTo(object obj)
        {
            Chirurgien ch = obj as Chirurgien;
            if (ch != null)
            {
                return NbreOperation.CompareTo(ch.NbreOperation);
            }
            else 
            {
                throw new ArgumentException("objet is not a chirurgien");

            }
            
        }
    }
}
