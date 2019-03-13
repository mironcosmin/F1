using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formula1.Clase
{
    class PilotClass
    {
        //Getter Setter Properties
        //Acts as Data Carier in Our Application

        public int PilotID { get; set; }

        public string NumePilot { get; set; }

        public string PrenumePiolt { get; set; }

        public string DataNasterii { get; set; }

        public int EchipaID { get; set; }

        public int Puncte { get; set; }

        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

        //Selecting data from database
        public DataTable Select()
        {
            //Step1 DataBase Connection
            SqlConnection conn = new SqlConnection(myconnstrng);
            DataTable dt = new DataTable();
            try
            {
                //step2 writing sql query
                string sql = "SELECT * FROM Pilot";
                //creating cmd using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);
                //creating sql data adapter using cmd
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);
            }
            catch (Exception)
            {

            }
            finally
            {
                conn.Close();
            }
            return dt;
        }

        public bool Insert(PilotClass c)
        {
            //creating default return type ans seting its value to false
            bool isSuccess = false;

            //Step1 Connect database
            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                //Step 2 creat a sql qurey to insert data
                string sql = "INSERT INTO Pilot(NumePilot, PrenumePiolt, DataNasterii, EchipaID, Puncte) VALUES (@NumePilot, @PrenumePiolt, @DataNasterii, @EchipaID, @Puncte)";
                //creating sql comand usind sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);
                //create parameters to add data
                cmd.Parameters.AddWithValue("@NumePilot", c.NumePilot);
                cmd.Parameters.AddWithValue("@PrenumePiolt", c.PrenumePiolt);
                cmd.Parameters.AddWithValue("@DataNasterii", c.DataNasterii);
                cmd.Parameters.AddWithValue("@EchipaID", c.EchipaID);
                cmd.Parameters.AddWithValue("@Puncte", c.Puncte);

                //conection open here
                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                //if the query runs succsesfully then the value of rowswill be greater than zero else its value is zero
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }

            }
            catch (Exception)
            {

            }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }

        //method to update data in database from our application
        public bool Update(PilotClass c)
        {
            //Create a default return type and set its default value to false 
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                //sql to update data in our database
                string sql = "UPDATE Pilot SET NumePilot=@NumePilot, PrenumePiolt=@PrenumePiolt, DataNasterii=@DataNasterii, EchipaID=@EchipaID, Puncte=@Puncte WHERE PilotID=@PilotID";
                //create sql command
                SqlCommand cmd = new SqlCommand(sql, conn);
                //Create parametres to add value
                cmd.Parameters.AddWithValue("@NumePilot", c.NumePilot);
                cmd.Parameters.AddWithValue("@PrenumePiolt", c.PrenumePiolt);
                cmd.Parameters.AddWithValue("@DataNasterii", c.DataNasterii);
                cmd.Parameters.AddWithValue("@EchipaID", c.EchipaID);
                cmd.Parameters.AddWithValue("@Puncte", c.Puncte);
                cmd.Parameters.AddWithValue("PilotID", c.PilotID);
                //open data base connection
                conn.Open();

                int row = cmd.ExecuteNonQuery();
                if (row > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch (Exception)
            {

            }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }

        //method to delete data from our data base
        public bool Delete(PilotClass c)
        {
            bool isSuccess = false;
            //Create sql connection
            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                //sql to delete data
                string sql = "DELETE FROM Pilot WHERE PilotID=@PilotID";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@PilotID", c.PilotID);
                //open connection
                conn.Open();
                int row = cmd.ExecuteNonQuery();
                if (row > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch (Exception)
            {

            }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }
    }
}
