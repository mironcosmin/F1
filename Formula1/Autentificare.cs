using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formula1
{
    public partial class Autentificare : Form
    {


        public Autentificare()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(180, 100);
            txtboxUtilizator.Text = "admin";
            txtboxParola.Text = "admin";
        }
        public void Clear()
        {
            txtboxUtilizator.Text = "";
            txtboxParola.Text = "";
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void txtboxUtilizator_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBoxLogo_Click(object sender, EventArgs e)
        {

        }

        private void lblUtilizator_Click(object sender, EventArgs e)
        {

        }

        private void btnAutentificare_Click(object sender, EventArgs e)
        {
            string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;
            SqlConnection conn = new SqlConnection(myconnstrng);
            SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM Autentificare WHERE Utilizator='" + txtboxUtilizator.Text + "' AND Parola='" + txtboxParola.Text + "' ", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            if(dt.Rows[0][0].ToString() == "1")
            {
                Meniu f2 = new Meniu();
                this.Hide();
                f2.ShowDialog();
                Application.Exit();

            }
            else
            {
                MessageBox.Show("Ati introdus utilizator sau parola gresit!");
                Clear();
            }

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtboxParola_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
