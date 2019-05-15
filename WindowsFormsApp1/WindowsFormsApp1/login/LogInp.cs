using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace WindowsFormsApp1
{
   public class LogInp:DbConnection,IUserType
    {
       

        public void logInUser(TextBox userPassword,TextBox userId)
        {

            this.UserId = userId.Text;
            this.newPassword = userPassword.Text;

            try
            {
                string a = this.SingleValue("select * from playerregs where userId='" + UserId + "' and password='" + newPassword + "'");


                if (a.Length > 0)
                {
                    playerinfo newplayer = new playerinfo();
                    newplayer.Show();
                    MessageBox.Show("wellcome");

                }

                else
                {

                    MessageBox.Show("Please enter Correct Username and Password");
                }
            }catch(Exception e){
                MessageBox.Show(e.Message);

            }
           
           


        }
    }
}
