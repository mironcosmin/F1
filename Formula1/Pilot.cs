using Formula1.Clase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formula1
{
    public partial class Pilot : Form
    {
        public Pilot()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(180, 100);
        }

        PilotClass c = new PilotClass();

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Autentificare f1 = new Autentificare();
            this.Hide();
            f1.ShowDialog();
            Application.Exit();
        }

        private void pbxClose_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void pbccBack_Click(object sender, EventArgs e)
        {
            Meniu f2 = new Meniu();
            this.Hide();
            f2.ShowDialog();
            Application.Exit();
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            txtPilotID.Text = dataGridView1.Rows[rowIndex].Cells[0].Value.ToString();
            txtNume.Text = dataGridView1.Rows[rowIndex].Cells[1].Value.ToString();
            txtPrenume.Text = dataGridView1.Rows[rowIndex].Cells[2].Value.ToString();
            txtData.Text = dataGridView1.Rows[rowIndex].Cells[3].Value.ToString();
            switch (dataGridView1.Rows[rowIndex].Cells[4].Value)
            {
                case 1:
                    cmbEchipa.Text = "Scuderia Ferari";
                    break;
                case 2:
                    cmbEchipa.Text = "Hass";
                    break;
                case 3:
                    cmbEchipa.Text = "McLaren";
                    break;
                case 4:
                    cmbEchipa.Text = "Mercedes";
                    break;
                case 5:
                    cmbEchipa.Text = "Racing Point";
                    break;
                case 6:
                    cmbEchipa.Text = "Red Bull Racing";
                    break;
                case 7:
                    cmbEchipa.Text = "Renault";
                    break;
                case 8:
                    cmbEchipa.Text = "Sauber";
                    break;
                case 9:
                    cmbEchipa.Text = "Scuderia Toro Rosso";
                    break;

            }
            txtPuncte.Text = dataGridView1.Rows[rowIndex].Cells[5].Value.ToString();
        }

        private void Pilot_Load(object sender, EventArgs e)
        {
            DataTable dt = c.Select();
            dataGridView1.DataSource = dt;
        }

        public void Clear()
        {
            txtPilotID.Text = "";
            txtNume.Text = "";
            txtPrenume.Text = "";
            txtData.Text = "";
            txtPuncte.Text = "";
            cmbEchipa.Text = "";
        }

        private void btnEliberare_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnSterge_Click(object sender, EventArgs e)
        {
            //get data from textbox
            c.PilotID = Convert.ToInt32(txtPilotID.Text);
            bool success = c.Delete(c);
            if (success == true)
            {
                MessageBox.Show("deleted successfulfy");
                //Refresh data grid view
                //load data on data grid view
                DataTable dt = c.Select();
                dataGridView1.DataSource = dt;
                Clear();
            }
            else
            {
                MessageBox.Show("failed to delete");
            }
        }

        private void btnAdaugare_Click(object sender, EventArgs e)
        {
            //Get Value from the imput fields
            
            c.NumePilot = txtNume.Text;
            c.PrenumePiolt = txtPrenume.Text;
            c.DataNasterii = txtData.Text;
            switch (cmbEchipa.Text)
            {
                case "Scuderia Ferrari":
                    c.EchipaID = 1;
                    break;
                case "Hass":
                    c.EchipaID = 2;
                    break;
                case "McLaren":
                    c.EchipaID = 3;
                    break;
                case "Mercedes":
                    c.EchipaID = 4;
                    break;
                case "Racing Point":
                    c.EchipaID = 5;
                    break;
                case "Red Bull Racing":
                    c.EchipaID = 6;
                    break;
                case "Renault":
                    c.EchipaID = 7;
                    break;
                case "Sauber":
                    c.EchipaID = 8;
                    break;
                case "Scuderia Roro Rosso":
                    c.EchipaID = 9;
                    break;
            }
            c.Puncte = int.Parse(txtPuncte.Text);

            //insert data into data base using methot created previously
            bool success = c.Insert(c);
            if (success == true)
            {
                //data inserted succesfully  
                MessageBox.Show("New contact successfully inserted");
                //Call the clear method here
                Clear();
            }
            else
            {
                //FAILED to add contact
                MessageBox.Show("failed to add new contact");
            }
            //load data on data grid view
            DataTable dt = c.Select();
            dataGridView1.DataSource = dt;

        }

        private void btnModificare_Click(object sender, EventArgs e)
        {
            //get the data from text boxes
            c.PilotID = int.Parse(txtPilotID.Text);
            c.NumePilot = txtNume.Text;
            c.PrenumePiolt = txtPrenume.Text;
            c.DataNasterii = txtData.Text;
            switch (cmbEchipa.Text)
            {
                case "Scuderia Ferrari":
                    c.EchipaID = 1;
                    break;
                case "Hass":
                    c.EchipaID = 2;
                    break;
                case "McLaren":
                    c.EchipaID = 3;
                    break;
                case "Mercedes":
                    c.EchipaID = 4;
                    break;
                case "Racing Point":
                    c.EchipaID = 5;
                    break;
                case "Red Bull Racing":
                    c.EchipaID = 6;
                    break;
                case "Renault":
                    c.EchipaID = 7;
                    break;
                case "Sauber":
                    c.EchipaID = 8;
                    break;
                case "Scuderia Roro Rosso":
                    c.EchipaID = 9;
                    break;
            }
            c.Puncte = int.Parse(txtPuncte.Text);
            //Update data in data base
            bool success = c.Update(c);
            if (success == true)
            {
                MessageBox.Show("update successfully");
                //load data on data grid view
                DataTable dt = c.Select();
                dataGridView1.DataSource = dt;
                //Call clear method
                Clear();

            }
            else
            {
                MessageBox.Show("update failed");
            }
        }
    }
}
