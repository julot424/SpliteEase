namespace SpliteEase
{
    partial class frmAcceuil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAcceuil));
            this.navigationBar1 = new navigationBar.navigationBar();
            this.SuspendLayout();
            // 
            // navigationBar1
            // 
            this.navigationBar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.navigationBar1.Location = new System.Drawing.Point(-3, -4);
            this.navigationBar1.Name = "navigationBar1";
            this.navigationBar1.Size = new System.Drawing.Size(1044, 163);
            this.navigationBar1.TabIndex = 0;
            this.navigationBar1.Load += new System.EventHandler(this.navigationBar1_Load);
            // 
            // frmAcceuil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1021, 677);
            this.Controls.Add(this.navigationBar1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAcceuil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SplitEase : Acceuil";
            this.Load += new System.EventHandler(this.frmAcceuil_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private navigationBar.navigationBar navigationBar1;
    }
}

