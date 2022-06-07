using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace AP4
{
    public class Modele
    {
        #region proprietes
        private MySqlConnection myConnection; // objet de connexion
        private bool connopen = false; // test si la connexion est faite
        private bool chargement = false; // test si le chargement d'une requête est fait
        //déclaration des datatables 
        private DataTable dT1 = new DataTable();
        private DataTable dT2 = new DataTable();
        private DataTable dT3 = new DataTable();
        private DataTable dT4 = new DataTable();
        #endregion
        #region accesseurs
        public bool Connopen { get => connopen; }
        public bool Chargement { get => chargement; }
        public DataTable DT1 { get => dT1; set => dT1 = value; }
        public DataTable DT2 { get => dT2; set => dT2 = value; }
        public DataTable DT3 { get => dT3; set => dT3 = value; }
        public DataTable DT4 { get => dT4; set => dT4 = value; }
        #endregion
        #region constructeur
        public Modele() { }
        #endregion
        #region methodes
        /// <summary>
        /// Méthode pour se connecter à la BD
        /// </summary>
        public void seconnecter()
        {
            // paramètres de connexion à modifier selon sa BD et son serveur de BD
            string myConnectionString = "Database=AP4;Data Source=192.168.210.1;" +
                "User Id = tdauzon; Password =30Juin2002; ";
            myConnection = new MySqlConnection(myConnectionString);
            try // tentative 
            {
                myConnection.Open();
                connopen = true;
            }
            catch (Exception err)// gestion des erreurs
            {
                MessageBox.Show("Erreur ouverture bdd : " + err, "PBS connection",
               MessageBoxButtons.OK, MessageBoxIcon.Error);
                connopen = false;
            }
        }

        /// <summary>
        /// Méthode pour se déconnecter de la BD
        /// </summary>
        public void sedeconnecter()
        {
            if (!connopen)
                return;
            try
            {
                myConnection.Close();
                myConnection.Dispose();
                connopen = false;
            }
            catch (Exception err)
            {
                MessageBox.Show("Erreur fermeture bdd : " + err, "PBS deconnection",
               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Méthode générique pour charger les données issues d'une requête dans un dataTable
        /// </summary>
        /// <param name="requete"></param>
        /// <param name="DT"></param>
        public void charger(string requete, DataTable DT)
        {
            MySqlCommand command = myConnection.CreateCommand();
            MySqlDataReader reader;
            try
            {
                command.CommandText = requete;
                reader = command.ExecuteReader();
                DT.Load(reader);
                chargement = true;
            }
            catch (Exception err)
            {
                MessageBox.Show("Erreur chargement dataTable: " + err, "PBS table",
               MessageBoxButtons.OK, MessageBoxIcon.Error);
                chargement = false;
            }
        }
        public void charger_donnees(string table)
        {
            if (table == "ADHERENT") charger("select * from ADHERENT;", dT1);
            if (table == "ARTICLE") charger("select * from ARTICLE;", dT2);
            if (table == "ENTREPRISE") charger("select * from ENTREPRISE;", dT3);
            if (table == "QUESTION") charger("select * from QUESTION;", dT4);
        }
        /// <summary>
        /// Méthode qui permet d'ajouter un adherent avec l'ensemble de ses données
        /// </summary>
        /// <returns>bool</returns>
        public bool AjoutADHERENT(string nomA, string prenomA, string employeur, string mailA, string mdpA, int unStatut, int numE)
        {
            try
            {
                bool ok = false;
                // préparation de la requête avec des paramètres
                string requete = "insert into ADHERENT values (NULL, @nomAdherent, @prenomAdherent, @nomEmployeur, @login, @mdp, @statut, @numE)";
                MySqlCommand command = myConnection.CreateCommand();
                command.CommandText = requete;
                // mise à jour des paramètres de la requête préparée avec les infos passées en paramètre de la méthode
                command.Parameters.AddWithValue("nomAdherent", nomA);
                command.Parameters.AddWithValue("prenomAdherent", prenomA);
                command.Parameters.AddWithValue("nomEmployeur", employeur);
                command.Parameters.AddWithValue("login", mailA);
                command.Parameters.AddWithValue("mdp", mdpA);
                command.Parameters.AddWithValue("statut", unStatut);
                command.Parameters.AddWithValue("numE", numE);
                // Exécution de la requête
                int i = command.ExecuteNonQuery();
                // i est positif si l'insertion a pu avoir lieu
                return (i > 0);
            }
            catch
            {
                return false;
            }
        }
        public bool ModifADHERENT(int numAdherent, string nomA, string prenomA, string employeur, string mailA, string mdpA, int unStatut, int numE)
        {
            try
            {
                bool ok = false;
                string requete = "update ADHERENT set nomAdherent=@nomAdherent, prenomAdherent=@prenomAdherent, nomEmployeur=@nomEmployeur, login=@login, mdp=@mdp, statut=@statut, numE=@numE where num_Adherent = @numAdherent";
                MySqlCommand command = myConnection.CreateCommand();
                command.CommandText = requete;
                command.Parameters.AddWithValue("num_Adherent", numAdherent);
                command.Parameters.AddWithValue("nomAdherent", nomA);
                command.Parameters.AddWithValue("prenomAdherent", prenomA);
                command.Parameters.AddWithValue("nomEmployeur", employeur);
                command.Parameters.AddWithValue("login", mailA);
                command.Parameters.AddWithValue("mdp", mdpA);
                command.Parameters.AddWithValue("statut", unStatut);
                command.Parameters.AddWithValue("numE", numE);

                int i = command.ExecuteNonQuery();
                MessageBox.Show("L'adherent a bien été modifié");
                return (i > 0);
            }
            catch
            {
                MessageBox.Show("Erreur");
                return false;
            }
        }
        public bool SupprimerADHERENT(int numAdherent)
        {
            try
            {
                bool ok = false;
                string requete = "delete from question where num_Adherent = @numAdherent";
                MySqlCommand command = myConnection.CreateCommand();
                command.Parameters.AddWithValue("num_Adherent", numAdherent);
                int i = command.ExecuteNonQuery();
                MessageBox.Show("La question a bien été supprimée");
                return (i > 0);
            }
            catch
            {
                MessageBox.Show("Erreur");
                return false;
            }
        }
        public bool AjoutARTICLE(string unTitre, string unChapeau, DateTime uneDate, string unPrologue, string unTheme, string unNomA, string unPrenomA, string unLien)
        {
            try
            {
                bool ok = false;
                // préparation de la requête avec des paramètres
                string requete = "insert into ARTICLE values (NULL, @titre, @chapeau, @date, @prologue, @theme, @nomAuteur, @prenomAuteur, @lienArticle)";
                MySqlCommand command = myConnection.CreateCommand();
                command.CommandText = requete;
                // mise à jour des paramètres de la requête préparée avec les infos passées en paramètre de la méthode

                command.Parameters.AddWithValue("titre", unTitre);
                command.Parameters.AddWithValue("chapeau", unChapeau);
                command.Parameters.AddWithValue("date", uneDate);
                command.Parameters.AddWithValue("prologue", unPrologue);
                command.Parameters.AddWithValue("theme", unTheme);
                command.Parameters.AddWithValue("nomAuteur", unNomA);
                command.Parameters.AddWithValue("prenomAuteur", unPrenomA);
                command.Parameters.AddWithValue("lienArticle", unLien);
                // Exécution de la requête
                int i = command.ExecuteNonQuery();
                // i est positif si l'insertion a pu avoir lieu
                return (i > 0);
            }
            catch
            {
                return false;
            }
        }
        public bool ModifARTICLE(int numArticle, string unTitre, string unChapeau, DateTime uneDate, string unPrologue, string unTheme, string unNomA, string unPrenomA, string unLien)
        {
            try
            {
                bool ok = false;
                string requete = "update ARTICLE set titre=@titre, chapeau=@chapeau, date=@date, prologue=@prologue, theme=@theme, nomAuteur=@nomAuteur, prenomAuteur=@prenomAuteur, lienArticle=@lienArticle where num_Article = @num_Article";
                MySqlCommand command = myConnection.CreateCommand();
                command.CommandText = requete;
                command.Parameters.AddWithValue("num_Article", numArticle);
                command.Parameters.AddWithValue("titre", unTitre);
                command.Parameters.AddWithValue("chapeau", unChapeau);
                command.Parameters.AddWithValue("date", uneDate);
                command.Parameters.AddWithValue("prologue", unPrologue);
                command.Parameters.AddWithValue("theme", unTheme);
                command.Parameters.AddWithValue("nomAuteur", unNomA);
                command.Parameters.AddWithValue("prenomAuteur", unPrenomA);
                command.Parameters.AddWithValue("lienArticle", unLien);

                int i = command.ExecuteNonQuery();
                MessageBox.Show("L'article a bien été modifié");
                return (i > 0);
            }
            catch
            {
                MessageBox.Show("Erreur");
                return false;
            }
        }
        public bool SupprimerARTICLE(int numArticle)
        {
            try
            {
                bool ok = false;
                string requete = "delete from question where num_Article = @numArticle";
                MySqlCommand command = myConnection.CreateCommand();
                command.Parameters.AddWithValue("num_Article", numArticle);
                int i = command.ExecuteNonQuery();
                MessageBox.Show("L'article a bien été supprimé");
                return (i > 0);
            }
            catch
            {
                MessageBox.Show("Erreur");
                return false;
            }
        }
        public bool AjoutENTREPRISE(string nomE, string adresseE, int codePE, int numTelE, int unStatut)
        {
            try
            {
                bool ok = false;
                // préparation de la requête avec des paramètres
                string requete = "insert into ENTREPRISE values (NULL, @nomEntreprise, @adresseEntreprise, @CPEntreprise, @numTelEntreprise, @statut)";
                MySqlCommand command = myConnection.CreateCommand();
                command.CommandText = requete;
                // mise à jour des paramètres de la requête préparée avec les infos passées en paramètre de la méthode
                command.Parameters.AddWithValue("nomEntreprise", nomE);
                command.Parameters.AddWithValue("adresseEntreprise", adresseE);
                command.Parameters.AddWithValue("CPEntreprise", codePE);
                command.Parameters.AddWithValue("numTelEntreprise", numTelE);
                command.Parameters.AddWithValue("statut", unStatut);
                // Exécution de la requête
                int i = command.ExecuteNonQuery();
                // i est positif si l'insertion a pu avoir lieu
                return (i > 0);
            }
            catch
            {
                return false;
            }
        }
        public bool ModifENTREPRISE(int numEntreprise, string nomE, string adresseE, int codePE, int numTelE, int unStatut)
        {
            try
            {
                bool ok = false;
                string requete = "update ENTREPRISE set nomEntreprise=@nomEntreprise, adresseEntreprise=@adresseEntreprise, CPEntreprise=@CPEntreprise, numTelEntreprise=@numTelEntreprise, statut=@statut where num_Entreprise = @numE";
                MySqlCommand command = myConnection.CreateCommand();
                command.CommandText = requete;
                command.Parameters.AddWithValue("num_Entreprise", numEntreprise);
                command.Parameters.AddWithValue("nomEntreprise", nomE);
                command.Parameters.AddWithValue("adresseEntreprise", adresseE);
                command.Parameters.AddWithValue("CPEntreprise", codePE);
                command.Parameters.AddWithValue("numTelEntreprise", numTelE);
                command.Parameters.AddWithValue("statut", unStatut);

                int i = command.ExecuteNonQuery();
                MessageBox.Show("L'entreprise a bien été modifiée");
                return (i > 0);
            }
            catch
            {
                MessageBox.Show("Erreur");
                return false;
            }
        }
        public bool SupprimerENTREPRISE(int numEntreprise)
        {
            try
            {
                bool ok = false;
                string requete = "delete from ENTREPRISE where num_Entreprise = @numEntreprise";
                MySqlCommand command = myConnection.CreateCommand();
                command.Parameters.AddWithValue("num_Entreprise", numEntreprise);
                int i = command.ExecuteNonQuery();
                MessageBox.Show("L'article a bien été supprimé");
                return (i > 0);
            }
            catch
            {
                MessageBox.Show("Erreur");
                return false;
            }
        }

        public bool AjoutQUESTION(string nomQ, string uneProp1, string uneProp2, string uneProp3, string uneProp4, string uneBonneRep, string unArticle)
        {
            try
            {
                bool ok = false;
                // préparation de la requête avec des paramètres
                string requete = "insert into QUESTION values (NULL, @nomQuestion, @prop1, @prop2, @prop3, @prop4, @bonneReponse, @lienArticle)";
                MySqlCommand command = myConnection.CreateCommand();
                command.CommandText = requete;
                // mise à jour des paramètres de la requête préparée avec les infos passées en paramètre de la méthode
                command.Parameters.AddWithValue("nomQuestion", nomQ);
                command.Parameters.AddWithValue("prop1", uneProp1);
                command.Parameters.AddWithValue("prop2", uneProp2);
                command.Parameters.AddWithValue("prop3", uneProp3);
                command.Parameters.AddWithValue("prop4", uneProp4);
                command.Parameters.AddWithValue("bonneReponse", uneBonneRep);
                command.Parameters.AddWithValue("lienArticle", unArticle);
                // Exécution de la requête
                int i = command.ExecuteNonQuery();
                // i est positif si l'insertion a pu avoir lieu
                return (i > 0);
            }
            catch
            {
                return false;
            }
        }
        #endregion
    }
}

