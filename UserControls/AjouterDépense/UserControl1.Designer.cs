namespace AjoutDépense
{
    partial class ajouterDepense
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
            this.cboEvenement = new System.Windows.Forms.ComboBox();
            this.cboPayePar = new System.Windows.Forms.ComboBox();
            this.txtQuoi = new System.Windows.Forms.TextBox();
            this.txtMontant = new System.Windows.Forms.TextBox();
            this.dateDeLajout = new System.Windows.Forms.DateTimePicker();
            this.txtCommentaire = new System.Windows.Forms.TextBox();
            this.chkListBeneficiaire = new System.Windows.Forms.CheckedListBox();
            this.btnValider = new System.Windows.Forms.Button();
            this.chkTous = new System.Windows.Forms.CheckBox();
            this.lblBeneficiaire = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
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
            // cboEvenement
            // 
            this.cboEvenement.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboEvenement.FormattingEnabled = true;
            this.cboEvenement.Location = new System.Drawing.Point(28, 73);
            this.cboEvenement.Name = "cboEvenement";
            this.cboEvenement.Size = new System.Drawing.Size(259, 27);
            this.cboEvenement.TabIndex = 2;
            this.cboEvenement.Text = "Evènement";
            this.cboEvenement.SelectedIndexChanged += new System.EventHandler(this.cboEvenement_SelectedIndexChanged);
            this.cboEvenement.Click += new System.EventHandler(this.cboEvenement_Click);
            this.cboEvenement.Leave += new System.EventHandler(this.cboEvenement_Leave);
            // 
            // cboPayePar
            // 
            this.cboPayePar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPayePar.FormattingEnabled = true;
            this.cboPayePar.Location = new System.Drawing.Point(326, 73);
            this.cboPayePar.Name = "cboPayePar";
            this.cboPayePar.Size = new System.Drawing.Size(259, 27);
            this.cboPayePar.TabIndex = 3;
            this.cboPayePar.Text = "Payé par";
            this.cboPayePar.SelectedIndexChanged += new System.EventHandler(this.cboPayePar_SelectedIndexChanged);
            // 
            // txtQuoi
            // 
            this.txtQuoi.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuoi.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.txtQuoi.Location = new System.Drawing.Point(28, 129);
            this.txtQuoi.Multiline = true;
            this.txtQuoi.Name = "txtQuoi";
            this.txtQuoi.Size = new System.Drawing.Size(259, 34);
            this.txtQuoi.TabIndex = 4;
            this.txtQuoi.Text = "Quoi";
            this.txtQuoi.Click += new System.EventHandler(this.txtQuoi_Click);
            this.txtQuoi.TextChanged += new System.EventHandler(this.txtQuoi_TextChanged);
            this.txtQuoi.Enter += new System.EventHandler(this.txtQuoi_Enter);
            // 
            // txtMontant
            // 
            this.txtMontant.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMontant.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.txtMontant.Location = new System.Drawing.Point(326, 129);
            this.txtMontant.Multiline = true;
            this.txtMontant.Name = "txtMontant";
            this.txtMontant.Size = new System.Drawing.Size(259, 34);
            this.txtMontant.TabIndex = 5;
            this.txtMontant.Text = "Montant";
            this.txtMontant.Click += new System.EventHandler(this.txtMontant_Click);
            this.txtMontant.TextChanged += new System.EventHandler(this.txtMontant_TextChanged);
            this.txtMontant.Enter += new System.EventHandler(this.txtMontant_Enter);
            this.txtMontant.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMontant_KeyPress);
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
            this.txtCommentaire.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCommentaire.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.txtCommentaire.Location = new System.Drawing.Point(326, 244);
            this.txtCommentaire.Multiline = true;
            this.txtCommentaire.Name = "txtCommentaire";
            this.txtCommentaire.Size = new System.Drawing.Size(259, 133);
            this.txtCommentaire.TabIndex = 7;
            this.txtCommentaire.Text = "Commentaire";
            this.txtCommentaire.Click += new System.EventHandler(this.txtCommentaire_Click);
            this.txtCommentaire.TextChanged += new System.EventHandler(this.txtCommentaire_TextChanged);
            this.txtCommentaire.Enter += new System.EventHandler(this.txtCommentaire_Enter);
            // 
            // chkListBeneficiaire
            // 
            this.chkListBeneficiaire.CheckOnClick = true;
            this.chkListBeneficiaire.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkListBeneficiaire.FormattingEnabled = true;
            this.chkListBeneficiaire.Location = new System.Drawing.Point(28, 218);
            this.chkListBeneficiaire.Name = "chkListBeneficiaire";
            this.chkListBeneficiaire.Size = new System.Drawing.Size(259, 214);
            this.chkListBeneficiaire.TabIndex = 8;
            this.chkListBeneficiaire.SelectedIndexChanged += new System.EventHandler(this.chkListBeneficiaire_SelectedIndexChanged);
            // 
            // btnValider
            // 
            this.btnValider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(170)))), ((int)(((byte)(0)))));
            this.btnValider.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValider.ForeColor = System.Drawing.Color.White;
            this.btnValider.Location = new System.Drawing.Point(326, 387);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(259, 45);
            this.btnValider.TabIndex = 9;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = false;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // chkTous
            // 
            this.chkTous.AutoSize = true;
            this.chkTous.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkTous.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTous.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.chkTous.Location = new System.Drawing.Point(182, 10);
            this.chkTous.Name = "chkTous";
            this.chkTous.Size = new System.Drawing.Size(66, 23);
            this.chkTous.TabIndex = 10;
            this.chkTous.Text = "Tous";
            this.chkTous.UseVisualStyleBackColor = true;
            this.chkTous.CheckedChanged += new System.EventHandler(this.chkTous_CheckedChanged);
            // 
            // lblBeneficiaire
            // 
            this.lblBeneficiaire.AutoSize = true;
            this.lblBeneficiaire.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBeneficiaire.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblBeneficiaire.Location = new System.Drawing.Point(6, 12);
            this.lblBeneficiaire.Name = "lblBeneficiaire";
            this.lblBeneficiaire.Size = new System.Drawing.Size(108, 19);
            this.lblBeneficiaire.TabIndex = 11;
            this.lblBeneficiaire.Text = "Bénéficiaires";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lblBeneficiaire);
            this.panel1.Controls.Add(this.chkTous);
            this.panel1.Location = new System.Drawing.Point(28, 179);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(259, 39);
            this.panel1.TabIndex = 12;
            // 
            // ajouterDepense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.chkListBeneficiaire);
            this.Controls.Add(this.txtCommentaire);
            this.Controls.Add(this.dateDeLajout);
            this.Controls.Add(this.txtMontant);
            this.Controls.Add(this.txtQuoi);
            this.Controls.Add(this.cboPayePar);
            this.Controls.Add(this.cboEvenement);
            this.Controls.Add(this.lblNouvelleDepense);
            this.Name = "ajouterDepense";
            this.Size = new System.Drawing.Size(610, 450);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNouvelleDepense;
        private System.Windows.Forms.ComboBox cboEvenement;
        private System.Windows.Forms.ComboBox cboPayePar;
        private System.Windows.Forms.TextBox txtQuoi;
        private System.Windows.Forms.TextBox txtMontant;
        private System.Windows.Forms.DateTimePicker dateDeLajout;
        private System.Windows.Forms.TextBox txtCommentaire;
        private System.Windows.Forms.CheckedListBox chkListBeneficiaire;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.CheckBox chkTous;
        private System.Windows.Forms.Label lblBeneficiaire;
        private System.Windows.Forms.Panel panel1;
    }
}
