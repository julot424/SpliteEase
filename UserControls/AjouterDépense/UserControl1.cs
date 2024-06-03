using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AjoutDépense
{
    public partial class UserControl1: UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private void txtQuoi_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtQuoi_Click(object sender, EventArgs e)
        {
            if(txtQuoi.Text == "Quoi")
            {
                txtQuoi.Text = "";
                txtQuoi.ForeColor = Color.Black;
            }
        }

        private void txtMontant_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtCommentaire_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtMontant_Click(object sender, EventArgs e)
        {
            if (txtMontant.Text == "Montant")
            {
                txtMontant.Text = "";
                txtMontant.ForeColor = Color.Black;
            }
        }

        private void txtCommentaire_Click(object sender, EventArgs e)
        {
            if (txtCommentaire.Text == "Commentaire")
            {
                txtCommentaire.Text = "";
                txtCommentaire.ForeColor = Color.Black;
            }
        }
    }
}
