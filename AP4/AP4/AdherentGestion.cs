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
    public partial class AdherentGestion : Form
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
        public string getNomAd()
        {
            return nomAd;
        }
        public void setNomAd(string value)
        {
            nomAd = value;
        }
        public string getPrenomAd()
        {
            return prenomAd;
        }
        public void setPrenomAd(string value)
        {
            prenomAd = value;
        }
        public string getNomEmployeur()
        {
            return nomEmployeur;
        }
        public void setNomEmployeur(string value)
        {
            nomEmployeur = value;
        }
        public string getMailAd()
        {
            return mailAd;
        }
        public void setMailAd(string value)
        {
            mailAd = value;
        }
        public string getMdpAd()
        {
            return mdpAd;
        }
        public void setMdpAd(string value)
        {
            mdpAd = value;
        }
        public int getStatut()
        {
            return statut;
        }
        public void setStatut(int value)
        {
            statut = value;
        }
        #endregion
        #region constructeur
        public AdherentGestion(List<adherent> lesAdherents, List<entreprise> lesEntreprises)
        {
            this.lesAdherents = lesAdherents;
            this.lesEntreprises = lesEntreprises;
            InitializeComponent();
        }
        public AdherentGestion()
        {
            InitializeComponent();
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
        private void btnAjouterAd_Click(object sender, EventArgs e)
        {
            int statut = 1;// active par défaut
            // saisies  du nom, prénom, employeur, mail, login, mdp et statut obligatoires
            if (TBNomAd.Text != "" && TBPrenomAd.Text != "" && CB_Entreprise.SelectedIndex != -1 && TBMailAd.Text != "" && TBmdpAd.Text != "" && (rbActiveAd.Checked || RBdesactiveAd.Checked))
            {
                if (rbActiveAd.Checked) statut = 1;

                // instancier l'objet unAdherent avec les informations saisies 
                unAdherent = new adherent(TBNomAd.Text, TBPrenomAd.Text, Convert.ToString(CB_Entreprise.SelectedItem), TBMailAd.Text, TBmdpAd.Text, Convert.ToInt32(rbActiveAd.Checked));

                // Afficher dans un MessageBox toutes les informations de l'adhérent 
                MessageBox.Show(unAdherent.Afficher());
                // Ajouter cet adherent à la collection lesAdherents
                lesAdherents.Add(unAdherent);

            }
            // AJOUT DANS LA BD
            // appel de la méthode AjoutBD avec en paramètre les données saisies : le nom, le prénom, l'employeur, le mail, le mdp et le statut
            int numAdherent = -1;
            int numE = -1;
            for (int i = 0; i < controleur.Vmodele.DT1.Rows.Count; i++)
            {
                numAdherent = Convert.ToInt32(controleur.Vmodele.DT1.Rows[i]["num_Adherent"]);
            }
            for (int i = 0; i < controleur.Vmodele.DT3.Rows.Count; i++)
            {
                if (Convert.ToString(CB_Entreprise.SelectedItem) == controleur.Vmodele.DT3.Rows[i]["nom_Entreprise"].ToString())
                {
                    numE = Convert.ToInt32(controleur.Vmodele.DT3.Rows[i]["num_Entreprise"]);
                }
            }
            if (numAdherent !=-1 && numE != -1)
            {
                bool rep = controleur.Vmodele.AjoutADHERENT(TBNomAd.Text, TBPrenomAd.Text, Convert.ToString(CB_Entreprise.SelectedItem), TBMailAd.Text, TBmdpAd.Text, Convert.ToInt32(rbActiveAd.Checked), numE); // paramètres à compléter dans l’ordre d’appel de la méthode….); 
                if (rep)
                {
                    MessageBox.Show("ADHERENT inséré dans la BD");
                }
                else
                {
                    MessageBox.Show("Pb dans l'insertion d’un adhérent", numAdherent.ToString());
                } 
            }
            else
            {
                MessageBox.Show("L'entreprise n'existe pas." + numE);
            }                
            AdherentGestion_Load(sender, e); // pour mettre à jour la comboBox

        }

        private void AdherentGestion_Load(object sender, EventArgs e)
        {
            CB_Entreprise.Items.Clear();
            controleur.Vmodele.charger_donnees("ENTREPRISE");
            foreach (entreprise E in lesEntreprises)
            //Pour chaque objet GA de type Gestion Article dans la collection lesArticles
            {
                CB_Entreprise.Items.Add(E.Nom);
                //ajout du nom de l'entreprise. 
            }
            cbListeAd.Items.Clear();
            foreach (adherent AG in lesAdherents)
            //Pour chaque objet AG de type AdherentGestion dans la collection lesAdherents
            {
                cbListeAd.Items.Add("Adhérent enregistré : " + AG.NomAd + " " + AG.PrenomAd + "\n Employé chez : " + AG.NomEmployeur + "\n Login : " + AG.MailAd + " a renseigné son mot de passe \n" + AG.RetourneActiveOuPas());
                //ajout du nom, prénom, employeur, mail et statut. 
            }
        }

        private void BtnModifier_Click(object sender, EventArgs e)
        {
            int numAdherent = -1;
            int numE = -1;
            int statut = 1;
            int index = cbListeAd.SelectedIndex;
            for (int i = 0; i < controleur.Vmodele.DT3.Rows.Count; i++)
            {
                if (Convert.ToString(CB_Entreprise.SelectedItem) == controleur.Vmodele.DT3.Rows[i]["nom_Entreprise"].ToString())
                {
                    numE = Convert.ToInt32(controleur.Vmodele.DT3.Rows[i]["num_Entreprise"]);
                }
            }
            for (int i = 0; i < controleur.Vmodele.DT1.Rows.Count; i++)
            {
                numAdherent = Convert.ToInt32(controleur.Vmodele.DT1.Rows[i]["num_Adherent"]);
            }
            
            if (numAdherent != -1 && numE != -1)
            {
                bool rep = controleur.Vmodele.ModifADHERENT(numAdherent, TBNomAd.Text, TBPrenomAd.Text, Convert.ToString(CB_Entreprise.SelectedItem), TBMailAd.Text, TBmdpAd.Text, Convert.ToInt32(rbActiveAd.Checked), numE); // paramètres à compléter dans l’ordre d’appel de la méthode….); 
                if (rep)
                {
                    MessageBox.Show("ADHERENT modifié dans la BD");
                    if (rbActiveAd.Checked) statut = 1;
                    lesAdherents[index].Statut = statut;

                    // Mettre à jour toutes les autres propriétés de l'adhérent sélectionné à partir des informations saisies sur l'interface
                   
                    lesAdherents[index].NomAd = TBNomAd.Text;
                    lesAdherents[index].PrenomAd = TBPrenomAd.Text;
                    lesEntreprises[index].Nom = Convert.ToString(CB_Entreprise.SelectedItem);
                    lesAdherents[index].MailAd = TBMailAd.Text;
                    lesAdherents[index].MdpAd = TBmdpAd.Text;
                }
                else
                {
                    MessageBox.Show("Pb dans la modification d’un adhérent");
                }
            }
            else
            {
                MessageBox.Show("L'adhérent n'existe pas." + numAdherent);
            }
            AdherentGestion_Load(sender, e); // pour mettre à jour la comboBox
        }
            

        private void BtnSupp_Click(object sender, EventArgs e)
        {
            int index = cbListeAd.SelectedIndex;
            if (index != -1)
            {
                DialogResult c = MessageBox.Show("Etes-vous sûr de vouloir supprimer cet adherent ?", "CONFIRMATION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (c == DialogResult.Yes)
                {
                    // Supprimer l'adhérent sélectionné de la collection lesAdherents
                    lesAdherents.RemoveAt(index);

                    AdherentGestion_Load(sender, e); // pour mettre à jour la comboBox
                }
            }

        }

        private void cbListeAd_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Cette méthode permet de récupérer toutes les données à stocker et à afficher dans la liste des adhérents. 
            int index = cbListeAd.SelectedIndex;
            if (index != -1)
            {
                adherent AG = lesAdherents[index];
                TBNomAd.Text = AG.NomAd;
                TBPrenomAd.Text = AG.PrenomAd;
                CB_Entreprise.SelectedItem = AG.NomEmployeur;
                TBMailAd.Text = AG.MailAd;
                TBmdpAd.Text = AG.MdpAd;
                rbActiveAd.Checked = (AG.Statut == 1);
                RBdesactiveAd.Checked = (AG.Statut == 2);
            }
        }
        #endregion

        private void CB_Entreprise_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
