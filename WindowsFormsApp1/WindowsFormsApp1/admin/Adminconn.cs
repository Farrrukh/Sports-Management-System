using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace WindowsFormsApp1
{
    class AdminConnection:DbConnection,IUserType
    {
        public void logInUser(TextBox newId,TextBox userPassword)
        {
            this.UserId = newId.Text;
            this.newPassword = userPassword.Text;
            try
            {

                string a = this.SingleValue("select * from Adminpan where userID='" + UserId + "' and password='" + newPassword + "'");


                if (a.Length > 0)
                {
                    insertallActi newinsertacti = new insertallActi();
                    newinsertacti.Show();
                    MessageBox.Show("wellcome");

                }

                else
                {

                    MessageBox.Show("Please enter Correct Username and Password");
                }
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
    }
}

