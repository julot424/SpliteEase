using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;

namespace AjoutDépense
{
    public partial class UserControl1: UserControl
    {
        private SQLiteConnection cx;

        public UserControl1()
        {
            InitializeComponent();


            string chaine =@"Data Source=C:\Users\julot\Desktop\BUTS2\SpliteEase\SpliteEase\bin\Debug\Events.sqlite";

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

        private void UserControl1_Load(object sender, EventArgs e)
        {
            string rqt = "SELECT titreEvent FROM Evenements";
            SQLiteDataAdapter da = new SQLiteDataAdapter(rqt, cx);
            DataTable dt = new DataTable();
            da.Fill(dt);

            cboEvenement.DataSource = dt;
            cboEvenement.DisplayMember = "Nom événement";
            cboEvenement.ValueMember = "titreEvent";

            cboEvenement.Text = "Evénement";
        }

        private void cboEvenement_Click(object sender, EventArgs e)
        {

        }

        private void cboEvenement_Leave(object sender, EventArgs e)
        {

            
        }

        private void cboEvenement_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = cboEvenement.SelectedIndex + 1;

            string rqt = "SELECT (p.nomPart ||' '|| p.prenomPart) AS fullName FROM Participants p INNER JOIN Invites i ON p.codeParticipant = i.codePart INNER JOIN Evenements e ON i.codeEvent = e.codeEvent WHERE e.codeEvent = " + selectedIndex;
            SQLiteDataAdapter da = new SQLiteDataAdapter(rqt, cx);
            DataTable dt = new DataTable();
            da.Fill(dt);

            cboPayePar.DataSource = dt;
            cboPayePar.DisplayMember = "Nom participant";
            cboPayePar.ValueMember = "fullName";

            cboPayePar.Text = "Payé par";
        }
    }
}
