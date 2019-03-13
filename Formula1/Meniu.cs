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
    public partial class Meniu : Form
    {
        public Meniu()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(180, 100);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
                Autentificare f1 = new Autentificare();
                this.Hide();
                f1.ShowDialog();
                Application.Exit();

            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnPilot_Click(object sender, EventArgs e)
        {
            Pilot f3 = new Pilot();
            this.Hide();
            f3.ShowDialog();
            Application.Exit();
        }

        private void Meniu_Load(object sender, EventArgs e)
        {

        }

        private void btnCircuit_Click(object sender, EventArgs e)
        {
            Circuit f4 = new Circuit();
            this.Hide();
            f4.ShowDialog();
            Application.Exit();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            InterogariSimple f5 = new InterogariSimple();
            this.Hide();
            f5.ShowDialog();
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            InterogariComplexe f7 = new InterogariComplexe();
            this.Hide();
            f7.ShowDialog();
            Application.Exit();
        }
    }
}
