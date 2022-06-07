namespace AP4
{
    partial class GestionEntreprise
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
            this.GBentreprise = new System.Windows.Forms.GroupBox();
            this.RBDes = new System.Windows.Forms.RadioButton();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.RBAct = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TBNumTelEntreprise = new System.Windows.Forms.TextBox();
            this.tbCPEntreprise = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbAdresseEntreprise = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbNomEntreprise = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CB_ListeEntreprises = new System.Windows.Forms.ComboBox();
            this.BtnModifier = new System.Windows.Forms.Button();
            this.BtnSupp = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.GBentreprise.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GBentreprise
            // 
            this.GBentreprise.Controls.Add(this.RBDes);
            this.GBentreprise.Controls.Add(this.btnAjouter);
            this.GBentreprise.Controls.Add(this.RBAct);
            this.GBentreprise.Controls.Add(this.label4);
            this.GBentreprise.Controls.Add(this.label3);
            this.GBentreprise.Controls.Add(this.TBNumTelEntreprise);
            this.GBentreprise.Controls.Add(this.tbCPEntreprise);
            this.GBentreprise.Controls.Add(this.label2);
            this.GBentreprise.Controls.Add(this.tbAdresseEntreprise);
            this.GBentreprise.Controls.Add(this.label1);
            this.GBentreprise.Controls.Add(this.tbNomEntreprise);
            this.GBentreprise.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBentreprise.Location = new System.Drawing.Point(12, 25);
            this.GBentreprise.Name = "GBentreprise";
            this.GBentreprise.Size = new System.Drawing.Size(324, 270);
            this.GBentreprise.TabIndex = 0;
            this.GBentreprise.TabStop = false;
            this.GBentreprise.Text = "Ajout d\'une nouvelle entreprise";
            // 
            // RBDes
            // 
            this.RBDes.AutoSize = true;
            this.RBDes.Location = new System.Drawing.Point(198, 215);
            this.RBDes.Name = "RBDes";
            this.RBDes.Size = new System.Drawing.Size(87, 20);
            this.RBDes.TabIndex = 3;
            this.RBDes.TabStop = true;
            this.RBDes.Text = "Désactivé";
            this.RBDes.UseVisualStyleBackColor = true;
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(232, 241);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(86, 23);
            this.btnAjouter.TabIndex = 1;
            this.btnAjouter.Text = "AJOUTER";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.BtnAjouter_Click);
            // 
            // RBAct
            // 
            this.RBAct.AutoSize = true;
            this.RBAct.Location = new System.Drawing.Point(25, 216);
            this.RBAct.Name = "RBAct";
            this.RBAct.Size = new System.Drawing.Size(63, 20);
            this.RBAct.TabIndex = 2;
            this.RBAct.TabStop = true;
            this.RBAct.Text = "Activé";
            this.RBAct.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(175, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Code postal de l\'entreprise :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Numéro de tel de l\'entreprise : ";
            this.label3.UseMnemonic = false;
            // 
            // TBNumTelEntreprise
            // 
            this.TBNumTelEntreprise.Location = new System.Drawing.Point(218, 179);
            this.TBNumTelEntreprise.Name = "TBNumTelEntreprise";
            this.TBNumTelEntreprise.Size = new System.Drawing.Size(100, 22);
            this.TBNumTelEntreprise.TabIndex = 2;
            this.TBNumTelEntreprise.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBNumTelEntreprise_KeyPress);
            // 
            // tbCPEntreprise
            // 
            this.tbCPEntreprise.Location = new System.Drawing.Point(218, 128);
            this.tbCPEntreprise.Name = "tbCPEntreprise";
            this.tbCPEntreprise.Size = new System.Drawing.Size(100, 22);
            this.tbCPEntreprise.TabIndex = 1;
            this.tbCPEntreprise.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCPEntreprise_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Adresse postale de l\'entreprise : ";
            // 
            // tbAdresseEntreprise
            // 
            this.tbAdresseEntreprise.Location = new System.Drawing.Point(218, 78);
            this.tbAdresseEntreprise.Name = "tbAdresseEntreprise";
            this.tbAdresseEntreprise.Size = new System.Drawing.Size(100, 22);
            this.tbAdresseEntreprise.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nom de l\'entreprise : ";
            // 
            // tbNomEntreprise
            // 
            this.tbNomEntreprise.Location = new System.Drawing.Point(218, 31);
            this.tbNomEntreprise.Name = "tbNomEntreprise";
            this.tbNomEntreprise.Size = new System.Drawing.Size(100, 22);
            this.tbNomEntreprise.TabIndex = 1;
            this.tbNomEntreprise.TextChanged += new System.EventHandler(this.TbNomEntreprise_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CB_ListeEntreprises);
            this.groupBox1.Controls.Add(this.BtnModifier);
            this.groupBox1.Controls.Add(this.BtnSupp);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.groupBox1.Location = new System.Drawing.Point(448, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(324, 162);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Suppression d\'entreprise";
            // 
            // CB_ListeEntreprises
            // 
            this.CB_ListeEntreprises.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_ListeEntreprises.FormattingEnabled = true;
            this.CB_ListeEntreprises.Location = new System.Drawing.Point(9, 73);
            this.CB_ListeEntreprises.Name = "CB_ListeEntreprises";
            this.CB_ListeEntreprises.Size = new System.Drawing.Size(299, 24);
            this.CB_ListeEntreprises.TabIndex = 3;
            this.CB_ListeEntreprises.SelectedIndexChanged += new System.EventHandler(this.CB_ListeEntreprises_SelectedIndexChanged);
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
            this.label5.Size = new System.Drawing.Size(251, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "Sélectionner une entreprise à supprimer :";
            // 
            // GestionEntreprise
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(786, 317);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.GBentreprise);
            this.Name = "GestionEntreprise";
            this.Text = "GestionEntreprise";
            this.Load += new System.EventHandler(this.GestionEntreprise_Load);
            this.GBentreprise.ResumeLayout(false);
            this.GBentreprise.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GBentreprise;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TBNumTelEntreprise;
        private System.Windows.Forms.TextBox tbCPEntreprise;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbAdresseEntreprise;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNomEntreprise;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnSupp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CB_ListeEntreprises;
        private System.Windows.Forms.Button BtnModifier;
        private System.Windows.Forms.RadioButton RBDes;
        private System.Windows.Forms.RadioButton RBAct;
    }
}