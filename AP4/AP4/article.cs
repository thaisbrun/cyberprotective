using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AP4
{
    public class article
    {
        #region proprietes
        private string titre;
        private string chapeau;
        private DateTime date;
        private string prologue;
        private string theme;
        private string nomAuteur;
        private string prenomAuteur;
        private string lienArticle;
        List<article> lesArticles;
        article unArticle;
        #endregion
        #region accesseurs 
        public string Titre { get => titre; set => titre = value; }
        public string Chapeau { get => chapeau; set => chapeau = value; }
        public DateTime Date { get => date; set => date = value; }
        public string Prologue { get => prologue; set => prologue = value; }
        public string Theme { get => theme; set => theme = value; }
        public string NomAuteur { get => nomAuteur; set => nomAuteur = value; }
        public string PrenomAuteur { get => prenomAuteur; set => prenomAuteur = value; }
        public string LienArticle { get => lienArticle; set => lienArticle = value; }
        #endregion
        #region constructeur
        public article(string unTitre, string unChapeau, DateTime uneDate, string unPrologue, string unTheme, string unNomA, string unPrenomA, string unLien)
        {
            titre = unTitre;
            chapeau = unChapeau;
            date = uneDate;
            prologue = unPrologue;
            theme = unTheme;
            nomAuteur = unNomA;
            prenomAuteur = unPrenomA;
            lienArticle = unLien;
        }
        #endregion
        #region methodes
        public string Afficher()
        {
            return ("Article publié : " + titre + "\n" + chapeau + "\n écrit le : " + date + "\n Classé dans : " + theme + "\n" + prologue + "\n Ecrit par : " + nomAuteur + " " + prenomAuteur + "\n Lien : " + lienArticle);
        }
        #endregion

    }
}
