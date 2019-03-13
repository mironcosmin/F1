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
    public partial class InterogariComplexe : Form
    {
        public InterogariComplexe()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(180, 100);
        }

        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Autentificare f1 = new Autentificare();
            this.Hide();
            f1.ShowDialog();
            Application.Exit();
        }

        private void pbccBack_Click(object sender, EventArgs e)
        {
            Meniu f2 = new Meniu();
            this.Hide();
            f2.ShowDialog();
            Application.Exit();
        }

        private void pbxClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(myconnstrng);
            string sql = "SELECT NumePilot, PrenumePiolt, Puncte FROM Pilot Where Puncte > (SELECT AVG(Puncte) FROM Pilot)";
            SqlCommand cmd = new SqlCommand(sql, conn);
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            conn.Open();
            adapter.Fill(dt);
            dgvintComp.DataSource = dt;
            conn.Close();
        }

        private void btnInter2_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(myconnstrng);
            string sql = "SELECT E.NumeEchipa FROM Echipa E INNER JOIN ConstructorMotor CM ON E.ConstructorMotorID = CM.ConstructorMotorID WHERE CM.PutereDezvoltataMotor >(SELECT AVG(CM.PutereDezvoltataMotor) FROM ConstructorMotor CM) ORDER BY PutereDezvoltataMotor";
            SqlCommand cmd = new SqlCommand(sql, conn);
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            conn.Open();
            adapter.Fill(dt);
            dgvintComp.DataSource = dt;
            conn.Close();
        }

        private void btnInter3_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(myconnstrng);
            string sql = "SELECT E.NumeEtapa FROM Etapa E WHERE E.CircuitID IN (SELECT CircuitID from Circuit WHERE NumarViraje = "+int.Parse(txtInterogare.Text)+")";
            SqlCommand cmd = new SqlCommand(sql, conn);
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            conn.Open();
            adapter.Fill(dt);
            dgvintComp.DataSource = dt;
            conn.Close();
        }

        private void btnInter4_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(myconnstrng);
            string sql = "SELECT A.NumePilot, A.PrenumePiolt FROM Pilot A INNER JOIN Participare B ON B.PilotID = A.PilotID WHERE B.ParticipareID IN (SELECT B.ParticipareID FROM Participare B INNER JOIN Etapa C ON C.EtapaID = B.EtapaID WHERE C.NumeEtapa = '"+comboBox1.Text+"')";
            SqlCommand cmd = new SqlCommand(sql, conn);
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            conn.Open();
            adapter.Fill(dt);
            dgvintComp.DataSource = dt;
            conn.Close();
        }
    }
}
