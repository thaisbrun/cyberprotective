
namespace AP4
{
    partial class GestionQuestions
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.TB_question = new System.Windows.Forms.TextBox();
            this.TB_prop1 = new System.Windows.Forms.TextBox();
            this.CB_Art = new System.Windows.Forms.ComboBox();
            this.Btn_Valider = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TB_Prop2 = new System.Windows.Forms.TextBox();
            this.TB_Prop3 = new System.Windows.Forms.TextBox();
            this.TB_Prop4 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TB_BonneRep = new System.Windows.Forms.TextBox();
            this.BonneRep = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(208, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Gestion des Questions";
            // 
            // TB_question
            // 
            this.TB_question.Location = new System.Drawing.Point(172, 57);
            this.TB_question.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TB_question.Multiline = true;
            this.TB_question.Name = "TB_question";
            this.TB_question.Size = new System.Drawing.Size(393, 40);
            this.TB_question.TabIndex = 2;
            // 
            // TB_prop1
            // 
            this.TB_prop1.Location = new System.Drawing.Point(172, 104);
            this.TB_prop1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TB_prop1.Multiline = true;
            this.TB_prop1.Name = "TB_prop1";
            this.TB_prop1.Size = new System.Drawing.Size(393, 23);
            this.TB_prop1.TabIndex = 3;
            // 
            // CB_Art
            // 
            this.CB_Art.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_Art.FormattingEnabled = true;
            this.CB_Art.Location = new System.Drawing.Point(336, 278);
            this.CB_Art.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CB_Art.Name = "CB_Art";
            this.CB_Art.Size = new System.Drawing.Size(230, 21);
            this.CB_Art.TabIndex = 4;
            // 
            // Btn_Valider
            // 
            this.Btn_Valider.Location = new System.Drawing.Point(471, 326);
            this.Btn_Valider.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Btn_Valider.Name = "Btn_Valider";
            this.Btn_Valider.Size = new System.Drawing.Size(94, 33);
            this.Btn_Valider.TabIndex = 7;
            this.Btn_Valider.Text = "VALIDER";
            this.Btn_Valider.UseVisualStyleBackColor = true;
            this.Btn_Valider.Click += new System.EventHandler(this.Btn_Valider_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(41, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Intitulé Question : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(58, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Proposition 1 : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(260, 278);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Article lié : ";
            // 
            // TB_Prop2
            // 
            this.TB_Prop2.Location = new System.Drawing.Point(172, 133);
            this.TB_Prop2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TB_Prop2.Multiline = true;
            this.TB_Prop2.Name = "TB_Prop2";
            this.TB_Prop2.Size = new System.Drawing.Size(393, 23);
            this.TB_Prop2.TabIndex = 14;
            // 
            // TB_Prop3
            // 
            this.TB_Prop3.Location = new System.Drawing.Point(172, 167);
            this.TB_Prop3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TB_Prop3.Multiline = true;
            this.TB_Prop3.Name = "TB_Prop3";
            this.TB_Prop3.Size = new System.Drawing.Size(393, 23);
            this.TB_Prop3.TabIndex = 15;
            // 
            // TB_Prop4
            // 
            this.TB_Prop4.Location = new System.Drawing.Point(172, 197);
            this.TB_Prop4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TB_Prop4.Multiline = true;
            this.TB_Prop4.Name = "TB_Prop4";
            this.TB_Prop4.Size = new System.Drawing.Size(393, 23);
            this.TB_Prop4.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(58, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "Proposition 2 : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(58, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 16);
            this.label5.TabIndex = 18;
            this.label5.Text = "Proposition 3 : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(58, 202);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 16);
            this.label7.TabIndex = 19;
            this.label7.Text = "Proposition 4 : ";
            // 
            // TB_BonneRep
            // 
            this.TB_BonneRep.Location = new System.Drawing.Point(172, 229);
            this.TB_BonneRep.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TB_BonneRep.Multiline = true;
            this.TB_BonneRep.Name = "TB_BonneRep";
            this.TB_BonneRep.Size = new System.Drawing.Size(393, 23);
            this.TB_BonneRep.TabIndex = 20;
            // 
            // BonneRep
            // 
            this.BonneRep.AutoSize = true;
            this.BonneRep.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BonneRep.Location = new System.Drawing.Point(47, 229);
            this.BonneRep.Name = "BonneRep";
            this.BonneRep.Size = new System.Drawing.Size(109, 16);
            this.BonneRep.TabIndex = 21;
            this.BonneRep.Text = "Bonne réponse : ";
            // 
            // GestionQuestions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(587, 386);
            this.Controls.Add(this.BonneRep);
            this.Controls.Add(this.TB_BonneRep);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TB_Prop4);
            this.Controls.Add(this.TB_Prop3);
            this.Controls.Add(this.TB_Prop2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Btn_Valider);
            this.Controls.Add(this.CB_Art);
            this.Controls.Add(this.TB_prop1);
            this.Controls.Add(this.TB_question);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "GestionQuestions";
            this.Text = "GestionQuestions";
            this.Load += new System.EventHandler(this.GestionQuestions_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TB_question;
        private System.Windows.Forms.TextBox TB_prop1;
        private System.Windows.Forms.ComboBox CB_Art;
        private System.Windows.Forms.Button Btn_Valider;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TB_Prop2;
        private System.Windows.Forms.TextBox TB_Prop3;
        private System.Windows.Forms.TextBox TB_Prop4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TB_BonneRep;
        private System.Windows.Forms.Label BonneRep;
    }

}