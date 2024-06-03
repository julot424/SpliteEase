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
    }
}
