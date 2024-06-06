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
            this.btnAjouterDepense = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // navigationBar1
            // 
            this.navigationBar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.navigationBar1.Location = new System.Drawing.Point(-3, -4);
            this.navigationBar1.Name = "navigationBar1";
            this.navigationBar1.Size = new System.Drawing.Size(1044, 163);
            this.navigationBar1.TabIndex = 0;
            this.navigationBar1.AcceuilClicked += new System.EventHandler(this.navigationBar1_AcceuilClicked);
            this.navigationBar1.Load += new System.EventHandler(this.navigationBar1_Load);
            // 
            // btnAjouterDepense
            // 
            this.btnAjouterDepense.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(170)))), ((int)(((byte)(0)))));
            this.btnAjouterDepense.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouterDepense.ForeColor = System.Drawing.Color.Transparent;
            this.btnAjouterDepense.Location = new System.Drawing.Point(616, 165);
            this.btnAjouterDepense.Name = "btnAjouterDepense";
            this.btnAjouterDepense.Size = new System.Drawing.Size(393, 60);
            this.btnAjouterDepense.TabIndex = 1;
            this.btnAjouterDepense.Text = "Ajouter une dépense";
            this.btnAjouterDepense.UseVisualStyleBackColor = false;
            this.btnAjouterDepense.Click += new System.EventHandler(this.btnAjouterDepense_Click);
            // 
            // frmAcceuil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1021, 677);
            this.Controls.Add(this.btnAjouterDepense);
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
        private System.Windows.Forms.Button btnAjouterDepense;
    }
}

