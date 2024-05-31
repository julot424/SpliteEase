namespace AjoutDépense
{
    partial class UserControl1
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

        #region Code généré par le Concepteur de composants

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNouvelleDepense = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboEvenement = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblNouvelleDepense
            // 
            this.lblNouvelleDepense.AutoSize = true;
            this.lblNouvelleDepense.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNouvelleDepense.Location = new System.Drawing.Point(23, 20);
            this.lblNouvelleDepense.Name = "lblNouvelleDepense";
            this.lblNouvelleDepense.Size = new System.Drawing.Size(231, 29);
            this.lblNouvelleDepense.TabIndex = 0;
            this.lblNouvelleDepense.Text = "Nouvelle dépense :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(576, 445);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // cboEvenement
            // 
            this.cboEvenement.FormattingEnabled = true;
            this.cboEvenement.Location = new System.Drawing.Point(28, 73);
            this.cboEvenement.Name = "cboEvenement";
            this.cboEvenement.Size = new System.Drawing.Size(259, 21);
            this.cboEvenement.TabIndex = 2;
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cboEvenement);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNouvelleDepense);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(800, 450);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNouvelleDepense;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboEvenement;
    }
}
