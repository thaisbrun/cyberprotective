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
    public partial class GestionEntreprise : Form
    {
        //Accès au formulaire de la gestion des Entreprises. 
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
        public string getNom()
        {
            return nom;
        }
        public void setNom(string value)
        {
            nom = value;
        }
        public string getAdresse()
        {
            return adresse;
        }
        public void setAdresse(string value)
        {
            adresse = value;
        }
        public int getCodeP()
        {
            return codeP;
        }
        public void setCodeP(int value)
        {
            codeP = value;
        }
        public int getNumTel()
        {
            return numTel;
        }
        public void setNumTel(int value)
        {
            numTel = value;
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
        public GestionEntreprise()
        {
            InitializeComponent();
        }
        public GestionEntreprise(List<entreprise> lesEntreprises, List<adherent> lesAdherents)
        {
            this.lesEntreprises = lesEntreprises;
            this.lesAdherents = lesAdherents;
            InitializeComponent();
        }
        #endregion
        #region methodes
        //Méthode utilisée pour afficher le statut de l'entreprise
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
        private void BtnAjouter_Click(object sender, EventArgs e)
        {
            int statut = 1;// active par défaut
            // saisies  du nom, adresse, code postal, le numéro de téléphone et le statut obligatoires
            if (tbNomEntreprise.Text != "" && tbAdresseEntreprise.Text != "" && tbCPEntreprise.Text != "" && TBNumTelEntreprise.Text != "" && (RBAct.Checked || RBDes.Checked))
            {
                if (RBAct.Checked) statut = 1;

                // Instancier l'objet uneEntreprise avec les informations saisies (par le constructeur et les accesseurs si besoin)
                uneEntreprise = new entreprise(tbNomEntreprise.Text, tbAdresseEntreprise.Text, Convert.ToInt32(tbCPEntreprise.Text), Convert.ToInt32(TBNumTelEntreprise.Text), Convert.ToInt32(RBAct.Checked));

                // Afficher dans un MessageBox toutes les informations de l'entreprise
                MessageBox.Show(uneEntreprise.Afficher());
                // Ajouter cette entreprise à la collection lesEntreprises
                lesEntreprises.Add(uneEntreprise);

                GestionEntreprise_Load(sender, e); // pour mettre à jour la comboBox
            }
            else
            {
                MessageBox.Show("Erreur, il faut saisir au moins le nom de l'entreprise, l'adresse, le code postal, le numéro de téléphone et le statut pour valider", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // AJOUT DANS LA BD
            // appel de la méthode AjoutBD avec en paramètre les données saisies : nom, adresse, code postal, numéro de téléphone et statut. 
            bool rep = controleur.Vmodele.AjoutENTREPRISE(tbNomEntreprise.Text, tbAdresseEntreprise.Text, Convert.ToInt32(tbCPEntreprise.Text), Convert.ToInt32(TBNumTelEntreprise.Text), Convert.ToInt32(RBAct.Checked));
            if (rep)
            {
                MessageBox.Show("Entreprise inséré dans la BD");
            }
            else
            {
                MessageBox.Show("Pb dans l'insertion d’une entreprise");
            }
        }


        private void GestionEntreprise_Load(object sender, EventArgs e)
        {
            CB_ListeEntreprises.Items.Clear();
            foreach (entreprise GE in lesEntreprises)
            //Pour chaque objet GE de type Gestion Entreprise dans la collection lesEntreprises
            {
                CB_ListeEntreprises.Items.Add("Entreprise enregistrée : " + GE.Nom + "\n Localisée à : " + GE.Adresse + " " + GE.CodeP + "\n Joignable au " + GE.NumTel + " Statut : " + RetourneActiveOuPas());
                //ajout du nom, adresse, code postal, numéro de téléphone et activation. 
            }
        }
        //vérification de la validité des paramètres 
        private void tbCPEntreprise_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != Convert.ToChar(Keys.Back))
            {
                MessageBox.Show("Erreur, vous devez saisir des chiffres", "Erreur", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                e.Handled = true; // efface le dernier caractère saisi
            }
        }

        private void TBNumTelEntreprise_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != Convert.ToChar(Keys.Back))
            {
                MessageBox.Show("Erreur, vous devez saisir des chiffres", "Erreur", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                e.Handled = true; // efface le dernier caractère saisi
            }
        }

        private void CB_ListeEntreprises_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Cette méthode permet de récupérer toutes les données à stocker et à afficher dans la liste des entreprises. 
            int index = CB_ListeEntreprises.SelectedIndex;
            if (index != -1)
            {
                entreprise GE = lesEntreprises[index];
                tbNomEntreprise.Text = GE.Nom;
                tbAdresseEntreprise.Text = GE.Adresse;
                tbCPEntreprise.Text = GE.CodeP.ToString();
                TBNumTelEntreprise.Text = GE.NumTel.ToString();
                RBAct.Checked = (GE.Statut == 1);
                RBDes.Checked = (GE.Statut == 2);
            }
        }

        private void BtnModifier_Click(object sender, EventArgs e)
        {
            int index = CB_ListeEntreprises.SelectedIndex;
            if (index != -1)
            {
                int statut = 1; // active par défaut
                                // saisies  de statut, nom de l'entreprise, adresse, code postal, numéro de téléphone obligatoires
                if ((RBAct.Checked || RBDes.Checked) && tbNomEntreprise.Text != "" && tbAdresseEntreprise.Text != "" && tbCPEntreprise.Text != "" && TBNumTelEntreprise.Text != "")
                {
                    if (RBAct.Checked) statut = 1;
                    lesEntreprises[index].Statut = statut;

                    // Mettre à jour toutes les autres propriétés de l'entreprise sélectionnée à partir des informations saisies sur l'interface

                    lesEntreprises[index].Nom = tbNomEntreprise.Text;
                    lesEntreprises[index].Adresse = tbAdresseEntreprise.Text;
                    lesEntreprises[index].CodeP = Convert.ToInt32(tbCPEntreprise.Text);
                    lesEntreprises[index].NumTel = Convert.ToInt32(TBNumTelEntreprise.Text);
                    MessageBox.Show("Entreprise modifiée");
                    GestionEntreprise_Load(sender, e); // pour mettre à jour la comboBox
                }
            }
        }

        private void BtnSupp_Click(object sender, EventArgs e)
        {
            int index = CB_ListeEntreprises.SelectedIndex;
            if (index != -1)
            {
                DialogResult c = MessageBox.Show("Etes-vous sûr de vouloir supprimer cette entreprise ?", "CONFIRMATION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (c == DialogResult.Yes)
                {
                    // Supprimer l'entreprise sélectionnée de la collection lesEntreprises. 
                    lesEntreprises.RemoveAt(index);
                    
                    //Pour chaque adhérent présent dans l'entreprise, le compte est supprimé. 
                    foreach (adherent A in lesAdherents)
                    {
                        if (A.NomEmployeur == getNom())
                        {
                            lesAdherents.Remove(unAdherent);
                        }
                    }
                    GestionEntreprise_Load(sender, e); // pour mettre à jour la comboBox
                }
            }
        }
        #endregion

        private void TbNomEntreprise_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
