using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenDylanForm.Classes
{
    public static class Election
    {
        //Attributs privée
        private static string nom_election;
        private static DateTime date_election;
        private static List<Electeur> list_electeurs;

        //propriéter
        public static string NomElection
        {
            get { return nom_election; }
            set { nom_election = value; }
        }

        public static DateTime DateElection
        {
            get { return date_election; }
            set { date_election = value; }
        }

        public static List<Electeur> listElecteurs
        {
            get { return list_electeurs; }
            set { list_electeurs = value; }
        }


        //constructeur static
        static Election()
        {
            listElecteurs = new List<Electeur>();
        }

        //methode ajouter electeur
        public static  string ajouter_electeur(Electeur p_elect)
        {
            //p_elect.(listElecteurs);
        }

        public static string rechercher_electeurs_ciconscription(string ciconscription)
        {
            int count = 0;
            foreach (Electeur e in listElecteurs)
                if (e.Circoncription == ciconscription) count++;
            return ciconscription;
        }

        public static

    }
}
