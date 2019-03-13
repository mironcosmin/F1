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
    public partial class Circuit : Form
    {
        public Circuit()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(180, 100);
        }

        CircuitClass c = new CircuitClass();

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

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Autentificare f1 = new Autentificare();
            this.Hide();
            f1.ShowDialog();
            Application.Exit();
        }

        private void Circuit_Load(object sender, EventArgs e)
        {
            //load data on data grid view
            DataTable dt = c.Select();
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            txtboxCircuitID.Text = dataGridView1.Rows[rowIndex].Cells[0].Value.ToString();
            txtboxAdresa.Text = dataGridView1.Rows[rowIndex].Cells[1].Value.ToString();
            txtboxNume.Text = dataGridView1.Rows[rowIndex].Cells[2].Value.ToString();
            txtboxNrVir.Text = dataGridView1.Rows[rowIndex].Cells[3].Value.ToString();
            txtboxLungime.Text = dataGridView1.Rows[rowIndex].Cells[4].Value.ToString();
        }

        public void Clear()
        {
            txtboxCircuitID.Text = "";
            txtboxNume.Text = "";
            txtboxAdresa.Text = "";
            txtboxNrVir.Text = "";
            txtboxLungime.Text = "";
        }

        private void btnEliberare_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnAdaugare_Click(object sender, EventArgs e)
        {
            //Get Value from the imput fields
            c.Adresa = txtboxAdresa.Text;
            c.Nume = txtboxNume.Text;
            c.NumarViraje = int.Parse(txtboxNrVir.Text);
            c.Lungime = int.Parse(txtboxLungime.Text);

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
            c.CircuitID = int.Parse(txtboxCircuitID.Text);
            c.Adresa = txtboxAdresa.Text;
            c.Nume = txtboxNume.Text;
            c.NumarViraje = int.Parse(txtboxNrVir.Text);
            c.Lungime = int.Parse(txtboxLungime.Text);
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

        private void btnSterge_Click(object sender, EventArgs e)
        {
            //get data from textbox
            c.CircuitID = Convert.ToInt32(txtboxCircuitID.Text);
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
    }
    
}
