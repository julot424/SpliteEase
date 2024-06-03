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
using System.Configuration;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace SpliteEase
{
    public partial class frmAcceuil : Form
    {
        private SQLiteConnection cx;
        private SQLiteConnection conn;
        string chaine = "Data Source=Events.sqlite";
        public frmAcceuil()
        {
            InitializeComponent();

            try
            {
                this.cx = new SQLiteConnection(chaine);
                cx.Open();
                SQLiteCommand comm = new SQLiteCommand("Select * from Depenses", cx);
                using (SQLiteDataReader read = comm.ExecuteReader())
                {
                    dataGridView1.Columns["dateDepense"].DefaultCellStyle.Format = "dd-MM-yyyy"
                    //dataGridView1.Columns["dateDepense"]
                    while (read.Read())
                    {
                        dataGridView1.Rows.Add(new object[] {
                        read.GetValue(read.GetOrdinal("description")),
                        read.GetValue(read.GetOrdinal("montant")),
                        read.GetValue(read.GetOrdinal("dateDepense"))
                        });
                    }
                }
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

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
        

        }
    }
}
