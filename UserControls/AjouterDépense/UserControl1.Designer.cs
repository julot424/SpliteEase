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
            this.lblPayerPar = new System.Windows.Forms.ComboBox();
            this.txtQuoi = new System.Windows.Forms.TextBox();
            this.txtMontant = new System.Windows.Forms.TextBox();
            this.dateDeLajout = new System.Windows.Forms.DateTimePicker();
            this.txtCommentaire = new System.Windows.Forms.TextBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.chkTous = new System.Windows.Forms.CheckBox();
            this.lblBeneficiaire = new System.Windows.Forms.Label();
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
            // lblPayerPar
            // 
            this.lblPayerPar.FormattingEnabled = true;
            this.lblPayerPar.Location = new System.Drawing.Point(326, 73);
            this.lblPayerPar.Name = "lblPayerPar";
            this.lblPayerPar.Size = new System.Drawing.Size(259, 21);
            this.lblPayerPar.TabIndex = 3;
            // 
            // txtQuoi
            // 
            this.txtQuoi.Location = new System.Drawing.Point(28, 129);
            this.txtQuoi.Name = "txtQuoi";
            this.txtQuoi.Size = new System.Drawing.Size(259, 20);
            this.txtQuoi.TabIndex = 4;
            // 
            // txtMontant
            // 
            this.txtMontant.Location = new System.Drawing.Point(326, 129);
            this.txtMontant.Name = "txtMontant";
            this.txtMontant.Size = new System.Drawing.Size(259, 20);
            this.txtMontant.TabIndex = 5;
            // 
            // dateDeLajout
            // 
            this.dateDeLajout.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateDeLajout.Location = new System.Drawing.Point(326, 187);
            this.dateDeLajout.Name = "dateDeLajout";
            this.dateDeLajout.Size = new System.Drawing.Size(259, 26);
            this.dateDeLajout.TabIndex = 6;
            // 
            // txtCommentaire
            // 
            this.txtCommentaire.Location = new System.Drawing.Point(326, 244);
            this.txtCommentaire.Multiline = true;
            this.txtCommentaire.Name = "txtCommentaire";
            this.txtCommentaire.Size = new System.Drawing.Size(259, 133);
            this.txtCommentaire.TabIndex = 7;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(28, 244);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(259, 184);
            this.checkedListBox1.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(326, 383);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(259, 45);
            this.button1.TabIndex = 9;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // chkTous
            // 
            this.chkTous.AutoSize = true;
            this.chkTous.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkTous.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTous.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.chkTous.Location = new System.Drawing.Point(207, 221);
            this.chkTous.Name = "chkTous";
            this.chkTous.Size = new System.Drawing.Size(66, 23);
            this.chkTous.TabIndex = 10;
            this.chkTous.Text = "Tous";
            this.chkTous.UseVisualStyleBackColor = true;
            // 
            // lblBeneficiaire
            // 
            this.lblBeneficiaire.AutoSize = true;
            this.lblBeneficiaire.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBeneficiaire.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblBeneficiaire.Location = new System.Drawing.Point(37, 222);
            this.lblBeneficiaire.Name = "lblBeneficiaire";
            this.lblBeneficiaire.Size = new System.Drawing.Size(108, 19);
            this.lblBeneficiaire.TabIndex = 11;
            this.lblBeneficiaire.Text = "Bénéficiaires";
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.lblBeneficiaire);
            this.Controls.Add(this.chkTous);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.txtCommentaire);
            this.Controls.Add(this.dateDeLajout);
            this.Controls.Add(this.txtMontant);
            this.Controls.Add(this.txtQuoi);
            this.Controls.Add(this.lblPayerPar);
            this.Controls.Add(this.cboEvenement);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNouvelleDepense);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(610, 450);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNouvelleDepense;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboEvenement;
        private System.Windows.Forms.ComboBox lblPayerPar;
        private System.Windows.Forms.TextBox txtQuoi;
        private System.Windows.Forms.TextBox txtMontant;
        private System.Windows.Forms.DateTimePicker dateDeLajout;
        private System.Windows.Forms.TextBox txtCommentaire;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox chkTous;
        private System.Windows.Forms.Label lblBeneficiaire;
    }
}
