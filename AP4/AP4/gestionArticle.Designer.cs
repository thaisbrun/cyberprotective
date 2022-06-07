
using System.Windows.Forms;

namespace AP4
{
    partial class gestionArticle
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
            this.GBAd2 = new System.Windows.Forms.GroupBox();
            this.cbListeArt = new System.Windows.Forms.ComboBox();
            this.BtnModifier3 = new System.Windows.Forms.Button();
            this.BtnSupp3 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.GBadhérent = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tbNAuteur = new System.Windows.Forms.TextBox();
            this.TBpAuteur = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TB_theme = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.btnPublierArt = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TBPrologueArticle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TBChapArt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TBNomArt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TB_lienArticle = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.GBAd2.SuspendLayout();
            this.GBadhérent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // GBAd2
            // 
            this.GBAd2.Controls.Add(this.cbListeArt);
            this.GBAd2.Controls.Add(this.BtnModifier3);
            this.GBAd2.Controls.Add(this.BtnSupp3);
            this.GBAd2.Controls.Add(this.label5);
            this.GBAd2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.GBAd2.Location = new System.Drawing.Point(591, 63);
            this.GBAd2.Margin = new System.Windows.Forms.Padding(4);
            this.GBAd2.Name = "GBAd2";
            this.GBAd2.Padding = new System.Windows.Forms.Padding(4);
            this.GBAd2.Size = new System.Drawing.Size(420, 199);
            this.GBAd2.TabIndex = 8;
            this.GBAd2.TabStop = false;
            this.GBAd2.Text = "Suppression d\'article ";
            // 
            // cbListeArt
            // 
            this.cbListeArt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbListeArt.FormattingEnabled = true;
            this.cbListeArt.Location = new System.Drawing.Point(12, 90);
            this.cbListeArt.Margin = new System.Windows.Forms.Padding(4);
            this.cbListeArt.Name = "cbListeArt";
            this.cbListeArt.Size = new System.Drawing.Size(397, 28);
            this.cbListeArt.TabIndex = 3;
            this.cbListeArt.SelectedIndexChanged += new System.EventHandler(this.cbListeArt_SelectedIndexChanged);
            // 
            // BtnModifier3
            // 
            this.BtnModifier3.Location = new System.Drawing.Point(39, 156);
            this.BtnModifier3.Margin = new System.Windows.Forms.Padding(4);
            this.BtnModifier3.Name = "BtnModifier3";
            this.BtnModifier3.Size = new System.Drawing.Size(125, 28);
            this.BtnModifier3.TabIndex = 2;
            this.BtnModifier3.Text = "MODIFIER";
            this.BtnModifier3.UseVisualStyleBackColor = true;
            this.BtnModifier3.Click += new System.EventHandler(this.BtnModifier3_Click);
            // 
            // BtnSupp3
            // 
            this.BtnSupp3.Location = new System.Drawing.Point(272, 156);
            this.BtnSupp3.Margin = new System.Windows.Forms.Padding(4);
            this.BtnSupp3.Name = "BtnSupp3";
            this.BtnSupp3.Size = new System.Drawing.Size(139, 28);
            this.BtnSupp3.TabIndex = 2;
            this.BtnSupp3.Text = "SUPPRIMER";
            this.BtnSupp3.UseVisualStyleBackColor = true;
            this.BtnSupp3.Click += new System.EventHandler(this.BtnSupp3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 52);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(280, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Sélectionner un article à supprimer :";
            // 
            // GBadhérent
            // 
            this.GBadhérent.Controls.Add(this.label9);
            this.GBadhérent.Controls.Add(this.TB_lienArticle);
            this.GBadhérent.Controls.Add(this.label11);
            this.GBadhérent.Controls.Add(this.label10);
            this.GBadhérent.Controls.Add(this.tbNAuteur);
            this.GBadhérent.Controls.Add(this.TBpAuteur);
            this.GBadhérent.Controls.Add(this.label8);
            this.GBadhérent.Controls.Add(this.TB_theme);
            this.GBadhérent.Controls.Add(this.pictureBox1);
            this.GBadhérent.Controls.Add(this.dateTimePicker1);
            this.GBadhérent.Controls.Add(this.label7);
            this.GBadhérent.Controls.Add(this.btnPublierArt);
            this.GBadhérent.Controls.Add(this.label4);
            this.GBadhérent.Controls.Add(this.label1);
            this.GBadhérent.Controls.Add(this.TBPrologueArticle);
            this.GBadhérent.Controls.Add(this.label2);
            this.GBadhérent.Controls.Add(this.TBChapArt);
            this.GBadhérent.Controls.Add(this.label6);
            this.GBadhérent.Controls.Add(this.TBNomArt);
            this.GBadhérent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBadhérent.Location = new System.Drawing.Point(13, 44);
            this.GBadhérent.Margin = new System.Windows.Forms.Padding(4);
            this.GBadhérent.Name = "GBadhérent";
            this.GBadhérent.Padding = new System.Windows.Forms.Padding(4);
            this.GBadhérent.Size = new System.Drawing.Size(569, 630);
            this.GBadhérent.TabIndex = 7;
            this.GBadhérent.TabStop = false;
            this.GBadhérent.Text = "Ajout d\'un nouvel article";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(16, 222);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(108, 20);
            this.label11.TabIndex = 13;
            this.label11.Text = "Nom Auteur :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(267, 222);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(131, 20);
            this.label10.TabIndex = 12;
            this.label10.Text = "Prénom Auteur :";
            // 
            // tbNAuteur
            // 
            this.tbNAuteur.Location = new System.Drawing.Point(136, 218);
            this.tbNAuteur.Margin = new System.Windows.Forms.Padding(4);
            this.tbNAuteur.Name = "tbNAuteur";
            this.tbNAuteur.Size = new System.Drawing.Size(100, 26);
            this.tbNAuteur.TabIndex = 10;
            this.tbNAuteur.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNAuteur_KeyPress);
            // 
            // TBpAuteur
            // 
            this.TBpAuteur.Location = new System.Drawing.Point(411, 218);
            this.TBpAuteur.Margin = new System.Windows.Forms.Padding(4);
            this.TBpAuteur.Name = "TBpAuteur";
            this.TBpAuteur.Size = new System.Drawing.Size(120, 26);
            this.TBpAuteur.TabIndex = 10;
            this.TBpAuteur.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBpAuteur_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(216, 178);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 20);
            this.label8.TabIndex = 10;
            this.label8.Text = "Thème choisi : ";
            // 
            // TB_theme
            // 
            this.TB_theme.Location = new System.Drawing.Point(355, 172);
            this.TB_theme.Margin = new System.Windows.Forms.Padding(4);
            this.TB_theme.Name = "TB_theme";
            this.TB_theme.Size = new System.Drawing.Size(193, 26);
            this.TB_theme.TabIndex = 9;
            this.TB_theme.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_theme_KeyPress);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(75, 121);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(77, 43);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(312, 130);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(236, 26);
            this.dateTimePicker1.TabIndex = 7;
            this.dateTimePicker1.Value = new System.DateTime(2021, 3, 22, 22, 23, 17, 0);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 143);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 20);
            this.label7.TabIndex = 3;
            this.label7.Text = "Image  : ";
            this.label7.UseMnemonic = false;
            // 
            // btnPublierArt
            // 
            this.btnPublierArt.Location = new System.Drawing.Point(447, 594);
            this.btnPublierArt.Margin = new System.Windows.Forms.Padding(4);
            this.btnPublierArt.Name = "btnPublierArt";
            this.btnPublierArt.Size = new System.Drawing.Size(115, 28);
            this.btnPublierArt.TabIndex = 1;
            this.btnPublierArt.Text = "PUBLIER";
            this.btnPublierArt.UseVisualStyleBackColor = true;
            this.btnPublierArt.Click += new System.EventHandler(this.btnPublierArt_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 308);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(172, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Prologue de l\'article : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(164, 137);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Date de création : ";
            this.label1.UseMnemonic = false;
            // 
            // TBPrologueArticle
            // 
            this.TBPrologueArticle.Location = new System.Drawing.Point(12, 332);
            this.TBPrologueArticle.Margin = new System.Windows.Forms.Padding(4);
            this.TBPrologueArticle.Multiline = true;
            this.TBPrologueArticle.Name = "TBPrologueArticle";
            this.TBPrologueArticle.Size = new System.Drawing.Size(536, 254);
            this.TBPrologueArticle.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 63);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Chapeau de l\'article :";
            // 
            // TBChapArt
            // 
            this.TBChapArt.Location = new System.Drawing.Point(8, 87);
            this.TBChapArt.Margin = new System.Windows.Forms.Padding(4);
            this.TBChapArt.Name = "TBChapArt";
            this.TBChapArt.Size = new System.Drawing.Size(540, 26);
            this.TBChapArt.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 33);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Titre de l\'article : ";
            // 
            // TBNomArt
            // 
            this.TBNomArt.Location = new System.Drawing.Point(156, 33);
            this.TBNomArt.Margin = new System.Windows.Forms.Padding(4);
            this.TBNomArt.Name = "TBNomArt";
            this.TBNomArt.Size = new System.Drawing.Size(392, 26);
            this.TBNomArt.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(345, 9);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(273, 31);
            this.label3.TabIndex = 6;
            this.label3.Text = "Gestion des articles";
            // 
            // TB_lienArticle
            // 
            this.TB_lienArticle.Location = new System.Drawing.Point(12, 278);
            this.TB_lienArticle.Margin = new System.Windows.Forms.Padding(4);
            this.TB_lienArticle.Name = "TB_lienArticle";
            this.TB_lienArticle.Size = new System.Drawing.Size(540, 26);
            this.TB_lienArticle.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 254);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(138, 20);
            this.label9.TabIndex = 15;
            this.label9.Text = "Lien de l\'article : ";
            // 
            // gestionArticle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1023, 689);
            this.Controls.Add(this.GBAd2);
            this.Controls.Add(this.GBadhérent);
            this.Controls.Add(this.label3);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "gestionArticle";
            this.Text = "gestionArticle";
            this.Load += new System.EventHandler(this.gestionArticle_Load);
            this.GBAd2.ResumeLayout(false);
            this.GBAd2.PerformLayout();
            this.GBadhérent.ResumeLayout(false);
            this.GBadhérent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox GBAd2;
        private System.Windows.Forms.ComboBox cbListeArt;
        private System.Windows.Forms.Button BtnModifier3;
        private System.Windows.Forms.Button BtnSupp3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox GBadhérent;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnPublierArt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TBPrologueArticle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TBChapArt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TBNomArt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TB_theme;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbNAuteur;
        private System.Windows.Forms.TextBox TBpAuteur;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TB_lienArticle;

        public TextBox TB_lienArticle1 { get => TB_lienArticle; set => TB_lienArticle = value; }
        public TextBox TbNAuteur { get => tbNAuteur; set => tbNAuteur = value; }
        public TextBox TBpAuteur1 { get => TBpAuteur; set => TBpAuteur = value; }
        public TextBox TB_theme1 { get => TB_theme; set => TB_theme = value; }
        public DateTimePicker DateTimePicker1 { get => dateTimePicker1; set => dateTimePicker1 = value; }
        public TextBox TBChapArt1 { get => TBChapArt; set => TBChapArt = value; }
        public TextBox TBNomArt1 { get => TBNomArt; set => TBNomArt = value; }
        public TextBox TBPrologueArticle1 { get => TBPrologueArticle; set => TBPrologueArticle = value; }
    }
}