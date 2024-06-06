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
    public partial class ajouterDepense: UserControl
    {
        private SQLiteConnection cx;
        

        public ajouterDepense()
        {
            InitializeComponent();

            chkTous.Checked = false;


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
            
        }

        private void txtMontant_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtCommentaire_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtMontant_Click(object sender, EventArgs e)
        {
            
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
            chkTous.Checked = true;


            int selectedIndex = cboEvenement.SelectedIndex + 1;

            string rqt = "SELECT p.codeParticipant, (p.nomPart ||' '|| p.prenomPart) AS fullName FROM Participants p INNER JOIN Invites i ON p.codeParticipant = i.codePart INNER JOIN Evenements e ON i.codeEvent = e.codeEvent WHERE e.codeEvent = " + selectedIndex;
            SQLiteDataAdapter da = new SQLiteDataAdapter(rqt, cx);
            DataTable dt = new DataTable();
            da.Fill(dt);

            cboPayePar.DataSource = dt;
            cboPayePar.DisplayMember = "fullName";
            cboPayePar.ValueMember = "p.codeParticipant";

            cboPayePar.Text = "Payé par";

            if (chkTous.Checked)
            {
                for (int i = 0; i < chkListBeneficiaire.Items.Count; i++)
                {
                    chkListBeneficiaire.SetItemChecked(i, true);
                }
            }

            else
            {
                for (int i = 0; i < chkListBeneficiaire.Items.Count; i++)
                {
                    chkListBeneficiaire.SetItemChecked(i, false);
                }
            }
        }

        private void chkListBeneficiaire_SelectedIndexChanged(object sender, EventArgs e)
        {
            chkListBeneficiaire.ClearSelected();
        }

        private void cboPayePar_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = cboEvenement.SelectedIndex + 1;

            string rqt = "SELECT codePart, (p.nomPart ||' '|| p.prenomPart) AS fullName FROM Participants p INNER JOIN Invites i ON p.codeParticipant = i.codePart INNER JOIN Evenements e ON i.codeEvent = e.codeEvent WHERE e.codeEvent = " + selectedIndex;
            SQLiteDataAdapter da = new SQLiteDataAdapter(rqt, cx);
            DataTable dt = new DataTable();
            da.Fill(dt);

            chkListBeneficiaire.DataSource = dt;
            chkListBeneficiaire.DisplayMember = "fullName";
            chkListBeneficiaire.ValueMember = "codePart";

        }

        private void chkTous_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTous.Checked)
            {
                for (int i = 0; i < chkListBeneficiaire.Items.Count; i++)
                {
                    chkListBeneficiaire.SetItemChecked(i, true);
                }
            }

            else
            {
                for (int i = 0; i < chkListBeneficiaire.Items.Count; i++)
                {
                    chkListBeneficiaire.SetItemChecked(i, false);
                }
            }
        }

        private void txtMontant_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !(e.KeyChar==','))
            {
                e.Handled = true;
            }
        }

        private void txtMontant_Enter(object sender, EventArgs e)
        {
            if (txtMontant.Text == "Montant")
            {
                txtMontant.Text = "";
                txtMontant.ForeColor = Color.Black;
            }
        }

        private void txtCommentaire_Enter(object sender, EventArgs e)
        {
            if (txtCommentaire.Text == "Commentaire")
            {
                txtCommentaire.Text = "";
                txtCommentaire.ForeColor = Color.Black;
            }
        }

        private void txtQuoi_Enter(object sender, EventArgs e)
        {
            if (txtQuoi.Text == "Quoi")
            {
                txtQuoi.Text = "";
                txtQuoi.ForeColor = Color.Black;
            }
        }

        private void btnValider_Click(object sender, EventArgs e)
        {

            int codePartSelectionne = int.Parse(cboPayePar.SelectedValue.ToString());
            

            
            int indexCodeEvent = cboEvenement.SelectedIndex + 1;

            string insertDepenseQuery = "INSERT INTO Depenses (description, montant, dateDepense, commentaire, codeEvent, codePart) VALUES (@description, @montant, @dateDepense, @commentaire, @codeEvent, @codePart)";
            using (SQLiteCommand cmd = new SQLiteCommand(insertDepenseQuery, cx))
            {
                // Ajout des paramètres avec les valeurs correspondantes
                cmd.Parameters.AddWithValue("@description", txtQuoi.Text);
                cmd.Parameters.AddWithValue("@montant", Convert.ToDouble(txtMontant.Text));
                cmd.Parameters.AddWithValue("@dateDepense", dateDeLajout.Value.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@commentaire", txtCommentaire.Text);
                cmd.Parameters.AddWithValue("@codeEvent", indexCodeEvent);
                cmd.Parameters.AddWithValue("@codePart", codePartSelectionne);

                // Exécution de la commande d'insertion
                cmd.ExecuteNonQuery();

                int numDepense;
                string queryGetNumDepense = "SELECT numDepense FROM Depenses ORDER BY numDepense DESC LIMIT 1";
                using (SQLiteCommand getNumDepenseCmd = new SQLiteCommand(queryGetNumDepense, cx))
                {
                    object result = getNumDepenseCmd.ExecuteScalar();
                    if (result != null && int.TryParse(result.ToString(), out int tempNumDepense))
                    {
                        numDepense = tempNumDepense;
                    }
                    else
                    {
                        throw new Exception("Impossible de récupérer le dernier numDepense.");
                    }
                }


                string insertBeneficiaireQuery = "INSERT INTO Beneficiaires (numDepense, codePart) VALUES (@numDepense, @codePart)";
                using (SQLiteCommand cmdInsertBenef = new SQLiteCommand(insertBeneficiaireQuery, cx))
                {
                    foreach (DataRowView item in chkListBeneficiaire.CheckedItems)
                    {
                        int codeBeneficiaire = Convert.ToInt32(item["codePart"]);
                        cmdInsertBenef.Parameters.Clear();
                        cmdInsertBenef.Parameters.AddWithValue("@numDepense", numDepense);
                        cmdInsertBenef.Parameters.AddWithValue("@codePart", codeBeneficiaire);
                        cmdInsertBenef.ExecuteNonQuery();
                    }
                }
            }

                MessageBox.Show("La dépense a bien été enregistrée");
            }
        }
}