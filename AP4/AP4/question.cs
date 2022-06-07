using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AP4
{
    public class question
    {
        #region proprietes 
        private string nom;
        private string prop1;
        private string prop2;
        private string prop3;
        private string prop4;
        private string bonneRep;
        private string article;
        #endregion
        #region accesseurs 
        public string Nom { get => nom; set => nom = value; }
        public string Prop1 { get => prop1; set => prop1 = value; }
        public string Prop2 { get => prop2; set => prop2 = value; }
        public string Prop3 { get => prop3; set => prop3 = value; }
        public string Prop4 { get => prop4; set => prop4 = value; }
        public string BonneRep { get => bonneRep; set => bonneRep = value; }
        public string Article { get => article; set => article = value; }
        #endregion
        #region constructeur
        public question(string nomQ, string uneProp1, string uneProp2, string uneProp3, string uneProp4, string uneBonneRep, string unArticle)
        {
            nom = nomQ;
            prop1 = uneProp1;
            prop2 = uneProp2;
            prop3 = uneProp3;
            prop4 = uneProp4;
            bonneRep = uneBonneRep;
            article = unArticle;
        }
        #endregion
        #region methodes
        public string Afficher()
        {
            return ("Question enregistrée : " + nom + "\n Proposition 1 : " + prop1 + "\n Proposition 2 : " + prop2 + "\n Proposition 3 : " + prop3 + "\n Proposition 4 : " + prop4 + "\n La bonne réponse est : " + bonneRep + "\n Référence : " + article);
        }
        #endregion
    }
}
