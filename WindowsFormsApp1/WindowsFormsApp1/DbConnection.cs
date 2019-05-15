
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public  class DbConnection
    {
        private string name;
        private string lastname;
        private string fathername;
        private string userid;
        private string password;
        private string confirmpassword;
        public string a;
        public string sqlCommand;
        public string SqlConnecion = @"Data Source = LAPTOP-35OT9IE8\SQLEXPRESS; Initial Catalog = registerationform; Integrated Security = True";

       public DataTable _dt;
        public void SaveData(string Command)
        {
            using (SqlConnection sqlconnection = new SqlConnection(SqlConnecion))
            {
                sqlconnection.Open();
                SqlCommand command = new SqlCommand(Command, sqlconnection);
                command.ExecuteNonQuery();
                using (SqlDataAdapter SqlAdapter = new SqlDataAdapter(Command, sqlconnection))
                {

                }
            }
        }
        public DataTable GetData(string query)
        {
            if (query == "") return null;
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection cn = new SqlConnection(SqlConnecion))
                {
                    cn.Open();
                  
                    using (SqlDataAdapter sdapt = new SqlDataAdapter(query, cn))
                    {

                        sdapt.Fill(dt);
                        cn.Close();
                    }
                    
                }
               
            }
            catch (Exception ae)
            {

                MessageBox.Show(ae.Message);
            }
            return dt;
            
        }
        public string SingleValue(string Query)
        {
            string returnValue = "";
            DataTable dt = new DataTable("Table1");
            using (SqlConnection sqlConnection = new SqlConnection(SqlConnecion))
            {
                sqlConnection.Open();
                using (SqlDataAdapter sqlAdapter = new SqlDataAdapter(Query, SqlConnecion))
                {

                    sqlAdapter.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        DataRow row = dt.Rows[0];
                        returnValue = row[0].ToString();

                    }

                }

            }
            return returnValue;

        }



        public string UserId
        {
            set
            {
                if (a == " " || a==" abcdefghijklmnopqrstuvwxyz")
                {
                    MessageBox.Show("Your ID is empty OR wrong");
                }
                else
                {
                    userid = value;
                }
            }
            get { return userid; }
        }


        public string newName
        {

            set
            {
                if (a == " ")
                {
                    MessageBox.Show("Please enter your name");
                }
                else
                { name = value; }
            }
            get
            {
                return name;
            }
        }
        public string newLastName
        {
            get { return lastname; }
            set
            {
                if (a ==" ")
                {
                    MessageBox.Show("Please enter your last name");
                }
                else
                { lastname = value; }
            }
        }

        public string fatherName
        {
            get { return fathername; }
            set
            {
                if (a == " ")
                {
                    MessageBox.Show("Please enter your father name");
                }
                else
                { fathername = value; }
            }

        }
        public string newPassword
        {

            get { return password; }
            set
            {
                if (a == " ")
                {
                    MessageBox.Show("Please enter password");
                }
                else
                { password = value; }
            }

        }
        public string newConfirmPassword
        {
            get { return confirmpassword; }
            set
            {
                if (a == " ")
                {
                    MessageBox.Show("Please enter confirm password");
                }
                else
                { confirmpassword = value; }
            }
        }
    }
}
