using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenDylanForm.Classes
{
    public class Electeur : Individu
    {
        //Attributs
        private string numero_electeur;
        private string circoncription;

        //Constructeur param defaut
        public Electeur (string p_nom = "", string p_prenom = "", string p_courriel = "",
                            string p_numero_electeur="", string p_circoncription="") : base(p_nom, p_prenom, p_courriel)
        {
            this.numero_electeur = p_numero_electeur;
            this.circoncription = p_circoncription;
        }

        //propriéter des attributs
        public string NumeroElecteur
        {
            get { return numero_electeur; }
            set { numero_electeur = value; }
        }

        public string Circoncription
        {
            get { return circoncription; }
            set { circoncription = value; }
        }

        public override string ToString()
        {
            return base.ToString() + "Le numéro électeur est : " + this.numero_electeur + "/n"
                + "La circoncription est : " + this.circoncription;
        }
    }
}
