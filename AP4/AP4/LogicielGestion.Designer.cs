namespace AP4
{
    partial class logicielGestion
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.BtnEntreprise = new System.Windows.Forms.Button();
            this.BtnArticle = new System.Windows.Forms.Button();
            this.BtnAdhérant = new System.Windows.Forms.Button();
            this.BtnQuestion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(291, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Logiciel de gestion";
            // 
            // BtnEntreprise
            // 
            this.BtnEntreprise.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEntreprise.Location = new System.Drawing.Point(163, 134);
            this.BtnEntreprise.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnEntreprise.Name = "BtnEntreprise";
            this.BtnEntreprise.Size = new System.Drawing.Size(205, 64);
            this.BtnEntreprise.TabIndex = 1;
            this.BtnEntreprise.Text = "Gestion des entreprises clientes";
            this.BtnEntreprise.UseVisualStyleBackColor = true;
            this.BtnEntreprise.Click += new System.EventHandler(this.BtnEntreprise_Click);
            // 
            // BtnArticle
            // 
            this.BtnArticle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnArticle.Location = new System.Drawing.Point(521, 134);
            this.BtnArticle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnArticle.Name = "BtnArticle";
            this.BtnArticle.Size = new System.Drawing.Size(205, 64);
            this.BtnArticle.TabIndex = 2;
            this.BtnArticle.Text = "Gestion des articles";
            this.BtnArticle.UseVisualStyleBackColor = true;
            this.BtnArticle.Click += new System.EventHandler(this.BtnArticle_Click);
            // 
            // BtnAdhérant
            // 
            this.BtnAdhérant.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAdhérant.Location = new System.Drawing.Point(163, 308);
            this.BtnAdhérant.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnAdhérant.Name = "BtnAdhérant";
            this.BtnAdhérant.Size = new System.Drawing.Size(205, 64);
            this.BtnAdhérant.TabIndex = 3;
            this.BtnAdhérant.Text = "Gestion des adhérents ";
            this.BtnAdhérant.UseVisualStyleBackColor = true;
            this.BtnAdhérant.Click += new System.EventHandler(this.BtnAdhérant_Click);
            // 
            // BtnQuestion
            // 
            this.BtnQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnQuestion.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnQuestion.Location = new System.Drawing.Point(521, 308);
            this.BtnQuestion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnQuestion.Name = "BtnQuestion";
            this.BtnQuestion.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtnQuestion.Size = new System.Drawing.Size(205, 64);
            this.BtnQuestion.TabIndex = 4;
            this.BtnQuestion.Text = "Gestion du test";
            this.BtnQuestion.UseVisualStyleBackColor = true;
            this.BtnQuestion.Click += new System.EventHandler(this.BtnQuestion_Click);
            // 
            // logicielGestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(833, 490);
            this.Controls.Add(this.BtnQuestion);
            this.Controls.Add(this.BtnAdhérant);
            this.Controls.Add(this.BtnArticle);
            this.Controls.Add(this.BtnEntreprise);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "logicielGestion";
            this.Text = "Logiciel de gestion ";
            this.Load += new System.EventHandler(this.logicielGestion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnEntreprise;
        private System.Windows.Forms.Button BtnArticle;
        private System.Windows.Forms.Button BtnAdhérant;
        private System.Windows.Forms.Button BtnQuestion;
    }
}

