using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AP4
{
    public class entreprise
    {
        #region proprietes 
        private string nom;
        private string adresse;
        private int codeP;
        private int numTel;
        private int statut;
        List<entreprise> lesEntreprises;
        List<adherent> lesAdherents;
        entreprise uneEntreprise;
        adherent unAdherent;
        #endregion
        #region accesseurs 
        public string Nom { get => nom; set => nom = value; }
        public string Adresse { get => adresse; set => adresse = value; }
        public int CodeP { get => codeP; set => codeP = value; }
        public int NumTel { get => numTel; set => numTel = value; }
        public int Statut { get => statut; set => statut = value; }
        #endregion
        #region constructeur
        public entreprise(string nomE, string adresseE, int codePE, int numTelE, int unStatut)
        {
            nom = nomE;
            adresse = adresseE;
            codeP = codePE;
            numTel = numTelE;
            statut = unStatut;
        }
        public string Afficher()
        {
            return ("Entreprise enregistrée : " + nom + "\n Localisée à : " + adresse + codeP + "\n Joignable au " + numTel + " Statut : " + RetourneActiveOuPas());
        }
        public string RetourneActiveOuPas()
        {
            string activation = "";
            if (statut == 1)
            {
                activation = "Activé";
            }
            else
            {
                activation = "Désactivé";
            }
            return activation;
        }
        #endregion
    }
}
