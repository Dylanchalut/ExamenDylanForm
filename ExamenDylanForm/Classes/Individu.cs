using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ExamenDylanForm.Classes
{
    public class Individu
    {
        //Attribut privée
        private string nom;
        private string prenom;
        private string courriel;

        //Constructeur avec parametre par defaut
        public Individu(string p_nom = "", string p_prenom = "", string p_courriel = "")
        {
            this.nom = p_nom;
            this.prenom = p_prenom;
            this.courriel = p_courriel;
        }

        //propriéter des attributs
        public string Nom
        {
            get { return this.nom; }
            set { Regex Reg = new Regex("^[A-Z]{1}[A-Za-z]{5,20}$");
                if (Reg.IsMatch(value)) this.nom = value; }
        }

        public string Prenom
        {
            get { return this.prenom; }
            set { Regex R = new Regex("^[A-Z]{1}[A-Za-z]{5,20}$");
            if (R.IsMatch(value)) this.prenom = value;}
        }

        public string Courriel
        {
            get { return this.courriel; }
            set { this.courriel = value; }              //Regex C = new Regex("^[a-z]{4,25}/@[a-z]{1,15}/.ca$");
                                                        //if (C.IsMatch(value)) this.courriel = value
        }


        public override string ToString()
        {
            return "Nom : " + this.nom + "/n"
                   + "Prénom : " + this.prenom + "/n"
                   + "Courriel : " + this.courriel;
        }
    }
}
