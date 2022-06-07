using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AP4
{
    public class adherent
    {
        #region proprietes
        private string nomAd;
        private string prenomAd;
        private string nomEmployeur;
        private string mailAd;
        private string mdpAd;
        private int statut;
        List<adherent> lesAdherents;
        List<entreprise> lesEntreprises;
        adherent unAdherent;
        entreprise uneEntreprise;
        #endregion
        #region accesseurs 
        public string NomAd { get => nomAd; set => nomAd = value; }
        public string PrenomAd { get => prenomAd; set => prenomAd = value; }
        public string NomEmployeur { get => nomEmployeur; set => nomEmployeur = value; }
        public string MailAd { get => mailAd; set => mailAd = value; }
        public string MdpAd { get => mdpAd; set => mdpAd = value; }
        public int Statut { get => statut; set => statut = value; }
        #endregion
        #region constructeur
        public adherent(string nomA, string prenomA, string employeur, string mailA, string mdpA, int unStatut)
        {
            nomAd = nomA;
            prenomAd = prenomA;
            nomEmployeur = employeur;
            mailAd = mailA;
            mdpAd = mdpA;
            statut = unStatut;
        }
        #endregion
        #region methodes
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
        public string Afficher()
        {
            return ("Adhérent enregistré : " + nomAd + " " + prenomAd + "\n Employé chez : " + nomEmployeur + "\n Login : " + mailAd + " a renseigné son mot de passe \n" + RetourneActiveOuPas());
        }
        #endregion
    }
}
