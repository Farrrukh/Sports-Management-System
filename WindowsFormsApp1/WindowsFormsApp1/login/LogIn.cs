using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class LogIn : MaterialSkin.Controls.MaterialForm
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void LogIn_Load(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            if(radioButton1.Checked==true){
               LogInp newlogin = new LogInp();
                newlogin.logInUser(password,userID);
               
                

            }
            //else if (radioButton2.Checked == true)
            //{
                //userlogin newuserlogin = new userlogin();
                //newuserlogin.log(username, password);
                //MessageBox.Show("wellcome");
              


            //}
            else if(radioButton3.Checked==true)
            {
                AdminConnection newadmin = new AdminConnection();
                newadmin.logInUser(userID, password);
                
                
                
            }
            else
            {
                MessageBox.Show("plzz choice anyone");
            }
        }

        private void password_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(password.Text))
            {
                errorProvider1.SetError(password, "Password required!");
            }
            else if (!Regex.IsMatch(password.Text, @"[A-Za-z][A-Za-z0-9]{2,7}"))
            {
                errorProvider1.SetError(password, "Password invalid!");
            }
            else
            {
                errorProvider1.SetError(password, null);
            }
        }

        private void userID_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(userID.Text))
            {
                errorProvider1.SetError(userID, "User Id required!");
            }
            else if (!Regex.IsMatch(userID.Text, @"^[0-9]*$"))
            {
                errorProvider1.SetError(userID, "User Id invalid!");
            }
            else
            {
                errorProvider1.SetError(userID, null);
            }
        }
    }
}
