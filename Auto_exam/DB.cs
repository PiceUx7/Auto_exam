using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auto_exam
{
    class DB
    {
        //  SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\CarPartsDB.mdf;Integrated Security=True;");
        SqlConnection con = new SqlConnection("Data Source=(localdb)\\mssqllocaldb;Initial Catalog=auto_exam;Integrated Security=True;");
        public void OpenConnection()
        {
            if (con.State == System.Data.ConnectionState.Closed)
                con.Open();
        }
        public void CloseConnection()
        {
            if (con.State == System.Data.ConnectionState.Open)
                con.Close();
        }
        public SqlConnection GetConnection()
        {
            return con;
        }

        public bool ExistInDB(string s)
        {
            OpenConnection();
            SqlCommand com1 = new SqlCommand(s, GetConnection());
            SqlDataReader reader = com1.ExecuteReader();
            string target = "";
            while (reader.Read())
            {
                target = reader[0].ToString();
            }
            reader.Close();
            if (target != "") return true;
            else return false;
        }

        public string ReturnFromDB(string s)
        {
            OpenConnection();
            SqlCommand com1 = new SqlCommand(s, GetConnection());
            SqlDataReader reader = com1.ExecuteReader();
            string target = "";
            while (reader.Read())
            {
                target = reader[0].ToString();
            }
            reader.Close();
            CloseConnection();
            return target;
        }

        public void NonQueryDB(string s)
        {
            OpenConnection();
            SqlCommand com1 = new SqlCommand(s, GetConnection());
            com1.ExecuteNonQuery();
            CloseConnection();
        }
    }
}
