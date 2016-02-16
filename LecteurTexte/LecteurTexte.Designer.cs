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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LecteurTexte));
            this.listBoxMots = new System.Windows.Forms.ListBox();
            this.buttonChercher = new System.Windows.Forms.Button();
            this.labelRechercherMot = new System.Windows.Forms.Label();
            this.textBoxTexte = new System.Windows.Forms.TextBox();
            this.openFileDialogTexte = new System.Windows.Forms.OpenFileDialog();
            this.buttonOuvrir = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.printPreviewTexte = new System.Windows.Forms.PrintPreviewDialog();
            this.buttonApercu = new System.Windows.Forms.Button();
            this.buttonImprimer = new System.Windows.Forms.Button();
            this.printDialogTexte = new System.Windows.Forms.PrintDialog();
            this.SuspendLayout();
            // 
            // listBoxMots
            // 
            this.listBoxMots.FormattingEnabled = true;
            this.listBoxMots.Location = new System.Drawing.Point(12, 99);
            this.listBoxMots.Name = "listBoxMots";
            this.listBoxMots.Size = new System.Drawing.Size(141, 316);
            this.listBoxMots.TabIndex = 0;
            this.listBoxMots.SelectedIndexChanged += new System.EventHandler(this.listBoxMots_SelectedIndexChanged);
            // 
            // buttonChercher
            // 
            this.buttonChercher.Location = new System.Drawing.Point(369, 421);
            this.buttonChercher.Name = "buttonChercher";
            this.buttonChercher.Size = new System.Drawing.Size(75, 23);
            this.buttonChercher.TabIndex = 1;
            this.buttonChercher.Text = "Chercher";
            this.buttonChercher.UseVisualStyleBackColor = true;
            this.buttonChercher.Click += new System.EventHandler(this.buttonChercher_Click);
            // 
            // labelRechercherMot
            // 
            this.labelRechercherMot.AutoSize = true;
            this.labelRechercherMot.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRechercherMot.Location = new System.Drawing.Point(20, 431);
            this.labelRechercherMot.Name = "labelRechercherMot";
            this.labelRechercherMot.Size = new System.Drawing.Size(133, 16);
            this.labelRechercherMot.TabIndex = 2;
            this.labelRechercherMot.Text = "Recherche du Mot";
            // 
            // textBoxTexte
            // 
            this.textBoxTexte.Location = new System.Drawing.Point(170, 99);
            this.textBoxTexte.Multiline = true;
            this.textBoxTexte.Name = "textBoxTexte";
            this.textBoxTexte.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxTexte.Size = new System.Drawing.Size(274, 316);
            this.textBoxTexte.TabIndex = 3;
            // 
            // openFileDialogTexte
            // 
            this.openFileDialogTexte.FileName = "openFileDialogTexte";
            this.openFileDialogTexte.Filter = "Fichiers texte (*.txt)|*.txt";
            this.openFileDialogTexte.InitialDirectory = "@\"Y:\\\"";
            this.openFileDialogTexte.ReadOnlyChecked = true;
            // 
            // buttonOuvrir
            // 
            this.buttonOuvrir.Location = new System.Drawing.Point(12, 12);
            this.buttonOuvrir.Name = "buttonOuvrir";
            this.buttonOuvrir.Size = new System.Drawing.Size(78, 23);
            this.buttonOuvrir.TabIndex = 4;
            this.buttonOuvrir.Text = "Ouvrir Fichier";
            this.buttonOuvrir.UseVisualStyleBackColor = true;
            this.buttonOuvrir.Click += new System.EventHandler(this.buttonOuvrir_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(96, 14);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(348, 20);
            this.textBox1.TabIndex = 5;
            // 
            // printPreviewTexte
            // 
            this.printPreviewTexte.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewTexte.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewTexte.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewTexte.Enabled = true;
            this.printPreviewTexte.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewTexte.Icon")));
            this.printPreviewTexte.Name = "printPreviewTexte";
            this.printPreviewTexte.Visible = false;
            // 
            // buttonApercu
            // 
            this.buttonApercu.Location = new System.Drawing.Point(12, 60);
            this.buttonApercu.Name = "buttonApercu";
            this.buttonApercu.Size = new System.Drawing.Size(141, 23);
            this.buttonApercu.TabIndex = 6;
            this.buttonApercu.Text = "Aperçu avant impression";
            this.buttonApercu.UseVisualStyleBackColor = true;
            this.buttonApercu.Click += new System.EventHandler(this.buttonApercu_Click);
            // 
            // buttonImprimer
            // 
            this.buttonImprimer.Location = new System.Drawing.Point(351, 60);
            this.buttonImprimer.Name = "buttonImprimer";
            this.buttonImprimer.Size = new System.Drawing.Size(92, 23);
            this.buttonImprimer.TabIndex = 7;
            this.buttonImprimer.Text = "Imprimer";
            this.buttonImprimer.UseVisualStyleBackColor = true;
            this.buttonImprimer.Click += new System.EventHandler(this.buttonImprimer_Click);
            // 
            // printDialogTexte
            // 
            this.printDialogTexte.UseEXDialog = true;
            // 
            // LecteurTexte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 456);
            this.Controls.Add(this.buttonImprimer);
            this.Controls.Add(this.buttonApercu);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonOuvrir);
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
        private System.Windows.Forms.OpenFileDialog openFileDialogTexte;
        private System.Windows.Forms.Button buttonOuvrir;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewTexte;
        private System.Windows.Forms.Button buttonApercu;
        private System.Windows.Forms.Button buttonImprimer;
        private System.Windows.Forms.PrintDialog printDialogTexte;
    }
}

