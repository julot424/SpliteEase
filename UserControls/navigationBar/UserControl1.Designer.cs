namespace navigationBar
{
    partial class navigationBar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(navigationBar));
            this.lblAcceuil = new System.Windows.Forms.Label();
            this.lblParticipant = new System.Windows.Forms.Label();
            this.lblEvenement = new System.Windows.Forms.Label();
            this.lblDepense = new System.Windows.Forms.Label();
            this.picBoxIndicator = new System.Windows.Forms.PictureBox();
            this.picBoxLogo = new System.Windows.Forms.PictureBox();
            this.AnimationTimer = new System.Windows.Forms.Timer();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxIndicator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAcceuil
            // 
            this.lblAcceuil.AutoSize = true;
            this.lblAcceuil.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAcceuil.Location = new System.Drawing.Point(258, 65);
            this.lblAcceuil.Name = "lblAcceuil";
            this.lblAcceuil.Size = new System.Drawing.Size(111, 32);
            this.lblAcceuil.TabIndex = 0;
            this.lblAcceuil.Text = "Accueil";
            this.lblAcceuil.Click += new System.EventHandler(this.lblAcceuil_Click);
            // 
            // lblParticipant
            // 
            this.lblParticipant.AutoSize = true;
            this.lblParticipant.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParticipant.Location = new System.Drawing.Point(409, 65);
            this.lblParticipant.Name = "lblParticipant";
            this.lblParticipant.Size = new System.Drawing.Size(171, 32);
            this.lblParticipant.TabIndex = 1;
            this.lblParticipant.Text = "Participants";
            this.lblParticipant.Click += new System.EventHandler(this.lblParticipant_Click);
            // 
            // lblEvenement
            // 
            this.lblEvenement.AutoSize = true;
            this.lblEvenement.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEvenement.Location = new System.Drawing.Point(628, 65);
            this.lblEvenement.Name = "lblEvenement";
            this.lblEvenement.Size = new System.Drawing.Size(176, 32);
            this.lblEvenement.TabIndex = 2;
            this.lblEvenement.Text = "Evènements";
            this.lblEvenement.Click += new System.EventHandler(this.lblEvenement_Click);
            // 
            // lblDepense
            // 
            this.lblDepense.AutoSize = true;
            this.lblDepense.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepense.Location = new System.Drawing.Point(844, 65);
            this.lblDepense.Name = "lblDepense";
            this.lblDepense.Size = new System.Drawing.Size(143, 32);
            this.lblDepense.TabIndex = 3;
            this.lblDepense.Text = "Dépenses";
            this.lblDepense.Click += new System.EventHandler(this.lblDepense_Click);
            // 
            // picBoxIndicator
            // 
            this.picBoxIndicator.Image = global::navigationBar.Properties.Resources.Indicator;
            this.picBoxIndicator.InitialImage = global::navigationBar.Properties.Resources.Indicator;
            this.picBoxIndicator.Location = new System.Drawing.Point(258, 100);
            this.picBoxIndicator.Name = "picBoxIndicator";
            this.picBoxIndicator.Size = new System.Drawing.Size(105, 17);
            this.picBoxIndicator.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxIndicator.TabIndex = 5;
            this.picBoxIndicator.TabStop = false;
            // 
            // picBoxLogo
            // 
            this.picBoxLogo.Image = global::navigationBar.Properties.Resources.logo;
            this.picBoxLogo.InitialImage = ((System.Drawing.Image)(resources.GetObject("picBoxLogo.InitialImage")));
            this.picBoxLogo.Location = new System.Drawing.Point(3, 3);
            this.picBoxLogo.Name = "picBoxLogo";
            this.picBoxLogo.Size = new System.Drawing.Size(249, 157);
            this.picBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxLogo.TabIndex = 4;
            this.picBoxLogo.TabStop = false;
            // 
            // AnimationTimer
            // 
            this.AnimationTimer.Interval = 5;
            this.AnimationTimer.Tick += new System.EventHandler(this.AnimationTimer_Tick);
            // 
            // navigationBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.picBoxIndicator);
            this.Controls.Add(this.picBoxLogo);
            this.Controls.Add(this.lblDepense);
            this.Controls.Add(this.lblEvenement);
            this.Controls.Add(this.lblParticipant);
            this.Controls.Add(this.lblAcceuil);
            this.Name = "navigationBar";
            this.Size = new System.Drawing.Size(1044, 163);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxIndicator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAcceuil;
        private System.Windows.Forms.Label lblParticipant;
        private System.Windows.Forms.Label lblEvenement;
        private System.Windows.Forms.Label lblDepense;
        private System.Windows.Forms.PictureBox picBoxLogo;
        private System.Windows.Forms.PictureBox picBoxIndicator;
        private System.Windows.Forms.Timer AnimationTimer;
    }
}
