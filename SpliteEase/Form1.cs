using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;


namespace SpliteEase
{
   
        public partial class frmAcceuil : Form
        {
            private SQLiteConnection cx;
            public frmAcceuil()
            {
                InitializeComponent();

                string chaine = "Data Source=Events.sqlite";

                try
                {
                    this.cx = new SQLiteConnection(chaine);
                    this.cx.Open();
                }
                catch (SQLiteException err)
                {
                    MessageBox.Show(err.Message);
                }
            }


        private void frmAcceuil_Load(object sender, EventArgs e)
        {
            
        }

        private void AnimationTimer_Tick(object sender, EventArgs e)
        {
           
        }

        private void navigationBar1_Load(object sender, EventArgs e)
        {

        }
    }
}
