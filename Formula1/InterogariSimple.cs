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
    public partial class InterogariSimple : Form
    {
        public InterogariSimple()
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

        private void btnInter1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(myconnstrng);
            string sql = "SELECT A.NumePilot, A.PrenumePiolt, S.NumeEchipa FROM Pilot A JOIN Echipa S ON A.EchipaID = S.EchipaID";
            SqlCommand cmd = new SqlCommand(sql, conn);
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            conn.Open();
            adapter.Fill(dt);
            dgvInterSimpla.DataSource = dt;
            conn.Close();
        }

        private void btnInter2_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(myconnstrng);
            string sql = "SELECT A.NumePilot, A.PrenumePiolt, Count(EtapaID)AS NumarParticipari FROM Pilot A INNER JOIN Participare P ON A.PilotID = P.PilotID GROUP BY A.PilotID, A.NumePilot, A.PrenumePiolt HAVING Count(EtapaID) >0 ORDER BY Count(EtapaID)DESC ";
            SqlCommand cmd = new SqlCommand(sql, conn);
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            conn.Open();
            adapter.Fill(dt);
            dgvInterSimpla.DataSource = dt;
            conn.Close();
        }

        private void btnInter3_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(myconnstrng);
            string sql = "SELECT E.NumeEchipa, CM.PutereDezvoltataMotor FROM Echipa E INNER JOIN ConstructorMotor CM ON E.ConstructorMotorID = CM.ConstructorMotorID WHERE CM.PutereDezvoltataMotor > "+txtPutere.Text+" ORDER BY PutereDezvoltataMotor";
            SqlCommand cmd = new SqlCommand(sql, conn);
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            conn.Open();
            adapter.Fill(dt);
            dgvInterSimpla.DataSource = dt;
            conn.Close();
        }

        private void btnInter4_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(myconnstrng);
            string sql = "SELECT E.NumeEchipa , SUM(P.Puncte) FROM Echipa E INNER JOIN Pilot P ON E.EchipaID = P.EchipaID GROUP BY E.NumeEchipa";
            SqlCommand cmd = new SqlCommand(sql, conn);
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            conn.Open();
            adapter.Fill(dt);
            dgvInterSimpla.DataSource = dt;
            conn.Close();
        }

        private void btnInter5_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(myconnstrng);
            string sql = "SELECT P.NumePilot, SUM(A.NumarMasiniDepasite) AS NrMasiniDepasite FROM Pilot P INNER JOIN Participare A ON P.PilotID = A.PilotID GROUP BY P.NumePilot ORDER BY SUM(A.NumarMasiniDepasite) DESC";
            SqlCommand cmd = new SqlCommand(sql, conn);
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            conn.Open();
            adapter.Fill(dt);
            dgvInterSimpla.DataSource = dt;
            conn.Close();
        }

        private void btnInter6_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(myconnstrng);
            string sql = "SELECT TOP 3 C.NumeConstructor, C.TipMotor, SUM(P.Puncte) AS Puncte FROM Pilot P INNER JOIN Echipa E ON E.EchipaID = P.EchipaID INNER JOIN ConstructorMotor C ON E.ConstructorMotorID = C.ConstructorMotorID GROUP BY C.NumeConstructor, C.TipMotor ORDER BY SUM(P.Puncte) DESC";
            SqlCommand cmd = new SqlCommand(sql, conn);
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            conn.Open();
            adapter.Fill(dt);
            dgvInterSimpla.DataSource = dt;
            conn.Close();
        }
    }
}
