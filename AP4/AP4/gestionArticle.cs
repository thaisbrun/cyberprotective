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
    public partial class gestionArticle : Form
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
        public string Theme { get => theme; set => theme = value; }
        public string LienArticle { get => lienArticle; set => lienArticle = value; }

        public string getTitre()
        {
            return titre;
        }
        public void setTitre(string value)
        {
            titre = value;
        }
        public string getChapeau()
        {
            return chapeau;
        }
        public void setChapeau(string value)
        {
            chapeau = value;
        }
        public DateTime getDate()
        {
            return date;
        }
        public void setDate(DateTime value)
        {
            date = value;
        }
        public string getPrologue()
        {
            return prologue;
        }
        public void setPrologue(string value)
        {
            prologue = value;
        }
        public string getNomAuteur()
        {
            return nomAuteur;
        }
        public void setNomAuteur(string value)
        {
            nomAuteur = value;
        }
        public string getPrenomAuteur()
        {
            return prenomAuteur;
        }
        public void setPrenomAuteur(string value)
        {
            prenomAuteur = value;
        }
        #endregion
        #region constructeur 
        public gestionArticle()
        {
            InitializeComponent();
        }

        public gestionArticle(List<article> lesArticles)
        {
            this.lesArticles = lesArticles;
            InitializeComponent();
        }
        #endregion
        #region methodes
        private void BtnModifier3_Click(object sender, EventArgs e)
        {
            int index = cbListeArt.SelectedIndex;
            if (index != -1)
            {
               if (TBNomArt.Text != "" && TBChapArt.Text != "" && dateTimePicker1.Value.ToShortDateString() != "" && TBPrologueArticle.Text != "" && TB_theme.Text != "" && tbNAuteur.Text != "" && TBpAuteur.Text != "" && TB_lienArticle.Text != "")
                {
        
                    // Mettre à jour toutes les autres propriétés de l'article sélectionnée à partir des informations saisies sur l'interface

                    lesArticles[index].Titre = TBNomArt.Text;
                    lesArticles[index].Chapeau = TBChapArt.Text;
                    lesArticles[index].Date = dateTimePicker1.Value;
                    lesArticles[index].Prologue = TBPrologueArticle.Text;
                    lesArticles[index].Theme = TB_theme.Text;
                    lesArticles[index].NomAuteur = tbNAuteur.Text;
                    lesArticles[index].PrenomAuteur = TBpAuteur.Text;
                    lesArticles[index].LienArticle = TB_lienArticle.Text;
                    MessageBox.Show("Article modifié");
                    gestionArticle_Load(sender, e); // pour mettre à jour la comboBox
                }
            }
        }

        private void btnPublierArt_Click(object sender, EventArgs e)
        {
            // saisies  du titre, chapeau, prologue, thème, nom et prénom de l'auteur obligatoires
            if (TBNomArt.Text != "" && TBChapArt.Text != "" && dateTimePicker1.Value.ToShortDateString() !="" && TBPrologueArticle.Text != "" && TB_theme.Text != "" && tbNAuteur.Text != "" && TBpAuteur.Text != "" && TB_lienArticle.Text != "")
            {

                // Instancier l'objet unArticle avec les informations saisies (par le constructeur et les accesseurs si besoin)
                unArticle = new article(TBNomArt.Text, TBChapArt.Text, dateTimePicker1.Value, TBPrologueArticle.Text, TB_theme.Text, tbNAuteur.Text, TBpAuteur.Text, TB_lienArticle.Text);

                // Afficher dans un MessageBox toutes les informations de l'article
                MessageBox.Show(unArticle.Afficher());
                // Ajouter cet article à la collection lesArticles
                lesArticles.Add(unArticle);

                gestionArticle_Load(sender, e); // pour mettre à jour la comboBox
            }
            else
            {
                MessageBox.Show("Erreur, il faut saisir au moins titre, chapeau, prologue, thème et lien de l'article ainsi que le nom et prénom de l'auteur pour valider", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // AJOUT DANS LA BD
            // appel de la méthode AjoutBD avec en paramètre les données saisies : nom, chapeau, date, prologue, theme, nom et prénom de l'auteur. 
            bool rep = controleur.Vmodele.AjoutARTICLE(TBNomArt.Text, TBChapArt.Text, dateTimePicker1.Value, TBPrologueArticle.Text, TB_theme.Text, tbNAuteur.Text, TBpAuteur.Text, TB_lienArticle.Text); 
            if (rep)
            {
                MessageBox.Show("ARTICLE inséré dans la BD");
            }
            else
            {
                MessageBox.Show("Pb dans l'insertion d’un article");
            }
        }

        private void gestionArticle_Load(object sender, EventArgs e)
        {
       cbListeArt.Items.Clear();
            foreach (article GA in lesArticles)
            //Pour chaque objet GA de type Gestion Article dans la collection lesArticles
            {
                cbListeArt.Items.Add("Article publié: " + GA.Titre + "\n" + GA.Chapeau + "\n écrit le: " + GA.Date + "\n Classé dans: " + GA.Theme + "\n" + GA.Prologue + "\n Ecrit par: " + GA.NomAuteur + " " + GA.PrenomAuteur + "\n Lien : " + GA.LienArticle);
                //ajout du titre, chapeau, prologue, thème; lien de l'article ainsi que le nom et prénom de l'auteur. 
            }
        }

        private void BtnSupp3_Click(object sender, EventArgs e)
        {
            int index = cbListeArt.SelectedIndex;
            if (index != -1)
            {
                DialogResult c = MessageBox.Show("Etes-vous sûr de vouloir supprimer cet article ?", "CONFIRMATION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (c == DialogResult.Yes)
                {
                    // Supprimer l'article sélectionné de la collection lesArticles
                    lesArticles.RemoveAt(index);

                    gestionArticle_Load(sender, e); // pour mettre à jour la comboBox
                }
            }
        }

        private void cbListeArt_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Cette méthode permet de récupérer toutes les données à stocker et à afficher dans la liste des articles. 
            int index = cbListeArt.SelectedIndex;
            if (index != -1)
            {
                article GA = lesArticles[index];
                TBNomArt.Text = GA.Titre;
                TBChapArt.Text = GA.Chapeau;
                dateTimePicker1.Value = GA.Date;
                TBPrologueArticle.Text = GA.Prologue;
                TB_theme.Text = GA.Theme;
                tbNAuteur.Text = GA.NomAuteur;
                TBpAuteur.Text = GA.PrenomAuteur;
                TB_lienArticle.Text = GA.LienArticle;
            }
        }
        //Vérification de la saisie 
        private void tbNAuteur_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 'a' || e.KeyChar > 'z') && (e.KeyChar < 'A' || e.KeyChar > 'Z') && (e.KeyChar != '-') && (e.KeyChar != ' ') && e.KeyChar != Convert.ToChar(Keys.Back))
            {
                MessageBox.Show("Erreur, vous devez saisir des lettres", "Erreur", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                e.Handled = true; // efface le dernier caractère saisi 
            }
        }

        private void TBpAuteur_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 'a' || e.KeyChar > 'z') && (e.KeyChar < 'A' || e.KeyChar > 'Z') && (e.KeyChar != '-') && (e.KeyChar != ' ') && e.KeyChar != Convert.ToChar(Keys.Back))
            {
                MessageBox.Show("Erreur, vous devez saisir des lettres", "Erreur", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                e.Handled = true; // efface le dernier caractère saisi 
            }
        }

        private void TB_theme_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 'a' || e.KeyChar > 'z') && (e.KeyChar < 'A' || e.KeyChar > 'Z') && (e.KeyChar != '-') && (e.KeyChar != ' ') && e.KeyChar != Convert.ToChar(Keys.Back))
            {
                MessageBox.Show("Erreur, vous devez saisir des lettres", "Erreur", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                e.Handled = true; // efface le dernier caractère saisi 
            }
        }
        #endregion
    }
}
