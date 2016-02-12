namespace LecteurTexte
{
    partial class LecteurTexte
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
            this.listBoxMots = new System.Windows.Forms.ListBox();
            this.buttonChercher = new System.Windows.Forms.Button();
            this.labelRechercherMot = new System.Windows.Forms.Label();
            this.textBoxTexte = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listBoxMots
            // 
            this.listBoxMots.FormattingEnabled = true;
            this.listBoxMots.Location = new System.Drawing.Point(12, 55);
            this.listBoxMots.Name = "listBoxMots";
            this.listBoxMots.Size = new System.Drawing.Size(141, 316);
            this.listBoxMots.TabIndex = 0;
            // 
            // buttonChercher
            // 
            this.buttonChercher.Location = new System.Drawing.Point(369, 12);
            this.buttonChercher.Name = "buttonChercher";
            this.buttonChercher.Size = new System.Drawing.Size(75, 23);
            this.buttonChercher.TabIndex = 1;
            this.buttonChercher.Text = "Chercher";
            this.buttonChercher.UseVisualStyleBackColor = true;
            // 
            // labelRechercherMot
            // 
            this.labelRechercherMot.AutoSize = true;
            this.labelRechercherMot.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRechercherMot.Location = new System.Drawing.Point(12, 17);
            this.labelRechercherMot.Name = "labelRechercherMot";
            this.labelRechercherMot.Size = new System.Drawing.Size(133, 16);
            this.labelRechercherMot.TabIndex = 2;
            this.labelRechercherMot.Text = "Recherche du Mot";
            // 
            // textBoxTexte
            // 
            this.textBoxTexte.Location = new System.Drawing.Point(170, 55);
            this.textBoxTexte.Multiline = true;
            this.textBoxTexte.Name = "textBoxTexte";
            this.textBoxTexte.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxTexte.Size = new System.Drawing.Size(274, 316);
            this.textBoxTexte.TabIndex = 3;
            // 
            // LecteurTexte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 387);
            this.Controls.Add(this.textBoxTexte);
            this.Controls.Add(this.labelRechercherMot);
            this.Controls.Add(this.buttonChercher);
            this.Controls.Add(this.listBoxMots);
            this.Name = "LecteurTexte";
            this.Text = "Editeur de Texte";
            this.Load += new System.EventHandler(this.LecteurTexte_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxMots;
        private System.Windows.Forms.Button buttonChercher;
        private System.Windows.Forms.Label labelRechercherMot;
        private System.Windows.Forms.TextBox textBoxTexte;
    }
}

