using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace AP4
{
    public partial class GestionQuestions : Form
    {
        #region proprietes
        private string nom;
        private string prop1;
        private string prop2;
        private string prop3;
        private string prop4;
        private string bonneRep;
        private string article;
        List<question> lesQuestions;
        List<article> lesArticles;
        question uneQuestion;
        article unArticle;
        #endregion
        #region accesseurs 
        public string Article { get => article; set => article = value; }
        public string getNom()
        {
            return nom;
        } 
        public void setNom(string value)
        {
            nom = value;
        }
        public string getProp1()
        {
            return prop1;
        }
        public void setProp1(string value)
        {
            prop1 = value;
        }
        public string getProp2()
        {
            return prop2;
        }
        public void setProp2(string value)
        {
            prop2 = value;
        }
        public string getProp3()
        {
            return prop3;
        }
        public void setProp3(string value)
        {
            prop3 = value;
        }
        public string getProp4()
        {
            return prop4;
        }
        public void setProp4(string value)
        {
            prop4 = value;
        }
        public string getBonneRep()
        {
            return bonneRep;
        }
        public void setBonneRep(string value)
        {
            bonneRep = value;
        }
        #endregion
        #region constructeur 
        public GestionQuestions(List<question> lesQuestions, List<article> lesArticles)
        {
            this.lesQuestions = lesQuestions;
            this.lesArticles = lesArticles;
            InitializeComponent();
        }
        public GestionQuestions()
        {
            InitializeComponent();
        }
        #endregion
        #region methodes 

        private void Btn_Valider_Click(object sender, EventArgs e)
        {
            if (TB_question.Text != "" && TB_prop1.Text != "" && TB_Prop2.Text != "" && TB_Prop3.Text != "" && TB_Prop4.Text != "" && TB_BonneRep.Text != "" && CB_Art.SelectedIndex !=-1)
            {
                // Instancier l'objet uneQuestion avec les informations saisies
                uneQuestion = new question(TB_question.Text, TB_prop1.Text, TB_Prop2.Text, TB_Prop3.Text, TB_Prop4.Text, TB_BonneRep.Text, CB_Art.SelectedItem.ToString());

                // Afficher dans un MessageBox toutes les informations de la question
                MessageBox.Show(uneQuestion.Afficher());
                // Ajouter cette question à la collection lesQuestions
                lesQuestions.Add(uneQuestion);
            }
            else
            {
                MessageBox.Show("Erreur, il faut saisir au moins l'intitulé de la question, ses propositions; l'article lié ainsi que la bonne réponse", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // AJOUT DANS LA BD
            // appel de la méthode AjoutBD avec en paramètre les données saisies : la questions, ses propositions, la bonne réponse et le lien de l'article join. 
            bool rep = controleur.Vmodele.AjoutQUESTION(TB_question.Text, TB_prop1.Text, TB_Prop2.Text, TB_Prop3.Text, TB_Prop4.Text, TB_BonneRep.Text, CB_Art.SelectedItem.ToString());
            if (rep)
            {
                MessageBox.Show("Question insérée dans la BD");
            }
            else
            {
                MessageBox.Show("Pb dans l'insertion d’une question");
            }
        }
        

        private void GestionQuestions_Load(object sender, EventArgs e)
        {
            CB_Art.Items.Clear();
            foreach (article GA in lesArticles)
            //Pour chaque objet GA de type Gestion Article dans la collection lesArticles
            {
                CB_Art.Items.Add(GA.LienArticle);
                //ajout du lien de l'article. 
            }
        }
        #endregion
    }
}
