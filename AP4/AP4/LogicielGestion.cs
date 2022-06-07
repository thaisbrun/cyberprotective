using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AP4
{
    public partial class logicielGestion : Form
    {
        //Bienvenue sur l'interface d'accueil. 
        #region proprietes
        List<entreprise> lesEntreprises = new List<entreprise>();
        List<question> lesQuestions = new List<question>();
        List<article> lesArticles = new List<article>();
        List<adherent> lesAdherents = new List<adherent>();
        #endregion
        #region constructeur
        public logicielGestion() => InitializeComponent();
        #endregion
        #region methodes
        //Lors du clic d'un bouton, celui ci redirige l'utilisateur vers l'interface quémandée. 
        private void BtnEntreprise_Click(object sender, EventArgs e)
        {
            GestionEntreprise GE = new GestionEntreprise(lesEntreprises, lesAdherents);
            GE.Show();
        }

        private void BtnArticle_Click(object sender, EventArgs e)
        {
            gestionArticle GA = new gestionArticle(lesArticles);
            GA.Show();
        }

        private void BtnAdhérant_Click(object sender, EventArgs e)
        {
            AdherentGestion AG = new AdherentGestion(lesAdherents, lesEntreprises);
            AG.Show();
        }

        private void BtnQuestion_Click(object sender, EventArgs e)
        {
            GestionQuestions GQ = new GestionQuestions(lesQuestions, lesArticles);
            GQ.Show();
        }
        //Sur l'évenement load, la connexion de la BDD a lieu 
        private void logicielGestion_Load(object sender, EventArgs e)
        {
            controleur.init();
            controleur.Vmodele.seconnecter();
            if (controleur.Vmodele.Connopen == false)
            {
                MessageBox.Show("Erreur de connexion");
            }
            else
            {
                MessageBox.Show("BDD connectée");
                controleur.Vmodele.charger_donnees("ADHERENT");
                controleur.Vmodele.charger_donnees("ARTICLE");
                controleur.Vmodele.charger_donnees("ENTREPRISE");
                controleur.Vmodele.charger_donnees("QUESTION");
                // si le chargement s’est bien passé
                if (controleur.Vmodele.Chargement)
                {
                    DataTable dt1 = controleur.Vmodele.DT1;
                    DataTable dt2 = controleur.Vmodele.DT2;
                    DataTable dt3 = controleur.Vmodele.DT3;
                    DataTable dt4 = controleur.Vmodele.DT4;
                
                // remplissage de la collection à partir des datatables chargés 
                // on parcourt chaque datatable
                for (int i = 0; i < controleur.Vmodele.DT1.Rows.Count; i++)
                {
                    // on ajoute chaque tuple du dataTable dans la collection lesAdherents 
                    lesAdherents.Add(new adherent(
                        dt1.Rows[i]["nomAdherent"].ToString(), 
                        dt1.Rows[i]["prenomAdherent"].ToString(),
                        dt1.Rows[i]["nomEmployeur"].ToString(),
                        dt1.Rows[i]["Login"].ToString(),
                        dt1.Rows[i]["mdp"].ToString(),
                        Convert.ToInt32(dt1.Rows[i]["statut"])));
                }
                    for (int i = 0; i < controleur.Vmodele.DT2.Rows.Count; i++)
                    {
                        // on ajoute chaque tuple du dataTable dans la collection lesArticles
                           lesArticles.Add(new article(
                            dt2.Rows[i]["titre_Article"].ToString(),
                            dt2.Rows[i]["chapeau_Article"].ToString(),
                            Convert.ToDateTime(dt2.Rows[i]["datePubli_Article"]),
                            dt2.Rows[i]["prologue_Article"].ToString(),
                            dt2.Rows[i]["nom_theme"].ToString(),
                            dt2.Rows[i]["nom_Auteur"].ToString(),
                            dt2.Rows[i]["prenom_Auteur"].ToString(),
                            dt2.Rows[i]["lien_Article"].ToString()));
                    }
                    for (int i = 0; i < controleur.Vmodele.DT3.Rows.Count; i++)
                    {
                        // on ajoute chaque tuple du dataTable dans la collection lesEntreprises
                            lesEntreprises.Add(new entreprise(
                            dt3.Rows[i]["nom_Entreprise"].ToString(),
                            dt3.Rows[i]["adresseEntreprise"].ToString(), 
                            Convert.ToInt32(dt3.Rows[i]["codePostalEntreprise"]),
                            Convert.ToInt32(dt3.Rows[i]["numeroTelEntreprise"]),
                            Convert.ToInt32(dt3.Rows[i]["statut"])));
                    }
                    for (int i = 0; i < controleur.Vmodele.DT4.Rows.Count; i++)
                    {
                        // on ajoute chaque tuple du dataTable dans la collection lesQuestions
                        lesQuestions.Add(new question(
                            dt4.Rows[i]["nomQuestion"].ToString(),
                            dt4.Rows[i]["Prop1"].ToString(),
                            dt4.Rows[i]["Prop2"].ToString(),
                            dt4.Rows[i]["Prop3"].ToString(),
                            dt4.Rows[i]["Prop4"].ToString(),
                            dt4.Rows[i]["bonneReponse"].ToString(),
                            dt4.Rows[i]["lien_Article"].ToString()));
                    }
                }
            }
        }
        //méthode pour effectuer la déconnexion à la BDD
        private static void logicielGestion_FormClosed(object sender, FormClosedEventArgs e)
        {
            controleur.Vmodele.sedeconnecter();
        }
        #endregion
    }
}
