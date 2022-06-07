
namespace AP4
{
    partial class AdherentGestion
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
            this.label3 = new System.Windows.Forms.Label();
            this.GBAd2 = new System.Windows.Forms.GroupBox();
            this.cbListeAd = new System.Windows.Forms.ComboBox();
            this.BtnModifier = new System.Windows.Forms.Button();
            this.BtnSupp = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.GBadhérent = new System.Windows.Forms.GroupBox();
            this.RBdesactiveAd = new System.Windows.Forms.RadioButton();
            this.rbActiveAd = new System.Windows.Forms.RadioButton();
            this.TBmdpAd = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnAjouterAd = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TBMailAd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TBPrenomAd = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TBNomAd = new System.Windows.Forms.TextBox();
            this.CB_Entreprise = new System.Windows.Forms.ComboBox();
            this.GBAd2.SuspendLayout();
            this.GBadhérent.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(269, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(250, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Gestion des adhérents";
            // 
            // GBAd2
            // 
            this.GBAd2.Controls.Add(this.cbListeAd);
            this.GBAd2.Controls.Add(this.BtnModifier);
            this.GBAd2.Controls.Add(this.BtnSupp);
            this.GBAd2.Controls.Add(this.label5);
            this.GBAd2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.GBAd2.Location = new System.Drawing.Point(424, 88);
            this.GBAd2.Name = "GBAd2";
            this.GBAd2.Size = new System.Drawing.Size(324, 162);
            this.GBAd2.TabIndex = 4;
            this.GBAd2.TabStop = false;
            this.GBAd2.Text = "Suppression d\'adhérent";
            // 
            // cbListeAd
            // 
            this.cbListeAd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbListeAd.FormattingEnabled = true;
            this.cbListeAd.Location = new System.Drawing.Point(9, 73);
            this.cbListeAd.Name = "cbListeAd";
            this.cbListeAd.Size = new System.Drawing.Size(299, 24);
            this.cbListeAd.TabIndex = 3;
            this.cbListeAd.SelectedIndexChanged += new System.EventHandler(this.cbListeAd_SelectedIndexChanged);
            // 
            // BtnModifier
            // 
            this.BtnModifier.Location = new System.Drawing.Point(29, 127);
            this.BtnModifier.Name = "BtnModifier";
            this.BtnModifier.Size = new System.Drawing.Size(94, 23);
            this.BtnModifier.TabIndex = 2;
            this.BtnModifier.Text = "MODIFIER";
            this.BtnModifier.UseVisualStyleBackColor = true;
            this.BtnModifier.Click += new System.EventHandler(this.BtnModifier_Click);
            // 
            // BtnSupp
            // 
            this.BtnSupp.Location = new System.Drawing.Point(204, 127);
            this.BtnSupp.Name = "BtnSupp";
            this.BtnSupp.Size = new System.Drawing.Size(104, 23);
            this.BtnSupp.TabIndex = 2;
            this.BtnSupp.Text = "SUPPRIMER";
            this.BtnSupp.UseVisualStyleBackColor = true;
            this.BtnSupp.Click += new System.EventHandler(this.BtnSupp_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(236, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "Sélectionner un adhérent à supprimer :";
            // 
            // GBadhérent
            // 
            this.GBadhérent.Controls.Add(this.CB_Entreprise);
            this.GBadhérent.Controls.Add(this.RBdesactiveAd);
            this.GBadhérent.Controls.Add(this.rbActiveAd);
            this.GBadhérent.Controls.Add(this.TBmdpAd);
            this.GBadhérent.Controls.Add(this.label8);
            this.GBadhérent.Controls.Add(this.btnAjouterAd);
            this.GBadhérent.Controls.Add(this.label4);
            this.GBadhérent.Controls.Add(this.label1);
            this.GBadhérent.Controls.Add(this.TBMailAd);
            this.GBadhérent.Controls.Add(this.label2);
            this.GBadhérent.Controls.Add(this.TBPrenomAd);
            this.GBadhérent.Controls.Add(this.label6);
            this.GBadhérent.Controls.Add(this.TBNomAd);
            this.GBadhérent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBadhérent.Location = new System.Drawing.Point(20, 56);
            this.GBadhérent.Name = "GBadhérent";
            this.GBadhérent.Size = new System.Drawing.Size(324, 331);
            this.GBadhérent.TabIndex = 3;
            this.GBadhérent.TabStop = false;
            this.GBadhérent.Text = "Ajout d\'un nouvel adhérent";
            // 
            // RBdesactiveAd
            // 
            this.RBdesactiveAd.AutoSize = true;
            this.RBdesactiveAd.Location = new System.Drawing.Point(219, 246);
            this.RBdesactiveAd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RBdesactiveAd.Name = "RBdesactiveAd";
            this.RBdesactiveAd.Size = new System.Drawing.Size(87, 20);
            this.RBdesactiveAd.TabIndex = 8;
            this.RBdesactiveAd.TabStop = true;
            this.RBdesactiveAd.Text = "Désactivé";
            this.RBdesactiveAd.UseVisualStyleBackColor = true;
            // 
            // rbActiveAd
            // 
            this.rbActiveAd.AutoSize = true;
            this.rbActiveAd.Location = new System.Drawing.Point(91, 246);
            this.rbActiveAd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbActiveAd.Name = "rbActiveAd";
            this.rbActiveAd.Size = new System.Drawing.Size(63, 20);
            this.rbActiveAd.TabIndex = 7;
            this.rbActiveAd.TabStop = true;
            this.rbActiveAd.Text = "Activé";
            this.rbActiveAd.UseVisualStyleBackColor = true;
            // 
            // TBmdpAd
            // 
            this.TBmdpAd.Location = new System.Drawing.Point(206, 184);
            this.TBmdpAd.Name = "TBmdpAd";
            this.TBmdpAd.Size = new System.Drawing.Size(100, 22);
            this.TBmdpAd.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 188);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(180, 16);
            this.label8.TabIndex = 5;
            this.label8.Text = "Mot de passe de l\'adhérent : ";
            this.label8.UseMnemonic = false;
            // 
            // btnAjouterAd
            // 
            this.btnAjouterAd.Location = new System.Drawing.Point(219, 301);
            this.btnAjouterAd.Name = "btnAjouterAd";
            this.btnAjouterAd.Size = new System.Drawing.Size(86, 23);
            this.btnAjouterAd.TabIndex = 1;
            this.btnAjouterAd.Text = "AJOUTER";
            this.btnAjouterAd.UseVisualStyleBackColor = true;
            this.btnAjouterAd.Click += new System.EventHandler(this.btnAjouterAd_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Fait parti de la société :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Adresse mail de l\'adhérent : ";
            this.label1.UseMnemonic = false;
            // 
            // TBMailAd
            // 
            this.TBMailAd.Location = new System.Drawing.Point(206, 145);
            this.TBMailAd.Name = "TBMailAd";
            this.TBMailAd.Size = new System.Drawing.Size(100, 22);
            this.TBMailAd.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Prénom de l\'adhérent : ";
            // 
            // TBPrenomAd
            // 
            this.TBPrenomAd.Location = new System.Drawing.Point(206, 68);
            this.TBPrenomAd.Name = "TBPrenomAd";
            this.TBPrenomAd.Size = new System.Drawing.Size(100, 22);
            this.TBPrenomAd.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(37, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 16);
            this.label6.TabIndex = 1;
            this.label6.Text = "Nom de l\'adhérent : ";
            // 
            // TBNomAd
            // 
            this.TBNomAd.Location = new System.Drawing.Point(206, 27);
            this.TBNomAd.Name = "TBNomAd";
            this.TBNomAd.Size = new System.Drawing.Size(100, 22);
            this.TBNomAd.TabIndex = 1;
            // 
            // CB_Entreprise
            // 
            this.CB_Entreprise.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_Entreprise.FormattingEnabled = true;
            this.CB_Entreprise.Location = new System.Drawing.Point(206, 109);
            this.CB_Entreprise.Name = "CB_Entreprise";
            this.CB_Entreprise.Size = new System.Drawing.Size(100, 24);
            this.CB_Entreprise.TabIndex = 5;
            this.CB_Entreprise.SelectedIndexChanged += new System.EventHandler(this.CB_Entreprise_SelectedIndexChanged);
            // 
            // AdherentGestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(767, 404);
            this.Controls.Add(this.GBAd2);
            this.Controls.Add(this.GBadhérent);
            this.Controls.Add(this.label3);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AdherentGestion";
            this.Text = "AdhérentGestion";
            this.Load += new System.EventHandler(this.AdherentGestion_Load);
            this.GBAd2.ResumeLayout(false);
            this.GBAd2.PerformLayout();
            this.GBadhérent.ResumeLayout(false);
            this.GBadhérent.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox GBAd2;
        private System.Windows.Forms.ComboBox cbListeAd;
        private System.Windows.Forms.Button BtnModifier;
        private System.Windows.Forms.Button BtnSupp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox GBadhérent;
        private System.Windows.Forms.Button btnAjouterAd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TBMailAd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TBPrenomAd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TBNomAd;
        private System.Windows.Forms.TextBox TBmdpAd;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton rbActiveAd;
        private System.Windows.Forms.RadioButton RBdesactiveAd;
        private System.Windows.Forms.ComboBox CB_Entreprise;
    }
}