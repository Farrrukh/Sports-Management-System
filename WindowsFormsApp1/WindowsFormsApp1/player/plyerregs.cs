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
    public partial class plyerregs : MaterialSkin.Controls.MaterialForm
    {
        public plyerregs()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (pass.Text == "" || cnfpass.Text == "")
            {
                MessageBox.Show("Please enter values");
                cnfpass.Focus();
                return;
            }
            else if (pass.Text != cnfpass.Text)
            {
                MessageBox.Show("Password not matching");
                cnfpass.Focus();
                return;
            }
                
            PlayerRegisteration newplayerreg = new PlayerRegisteration();
            //if(radioButton1.Checked )
            //{
            //    radioButton2.Visible = false;
            //}
            //else if (radioButton2.Checked)
            //{
            //    radioButton1.Visible = false;
            //}
            //else
            //{
            //    MessageBox.Show("plzz select the gender");
            //}
            //if (footballerr.Checked)
            //{
            //    crickterr.Visible = false;
            //    hockeyy.Visible = false;
            //}
            //else if (crickterr.Checked)
            //{
            //    footballerr.Visible = false;
            //    hockeyy.Visible = false;
            //}
            //else if (hockeyy.Checked)
            //{
            //    footballerr.Visible = false;
            //    crickterr.Visible = false;
            //}
            //else
            //{
            //    MessageBox.Show("plzz select the sport");
            //}



            newplayerreg.playerRegisteration(nam, lnam, fnam, clubnam, dateTimePicker1 ,comboBox1 ,userId, province, city, pass, cnfpass,comboBox2);
            MessageBox.Show("data inserted");
            this.Hide();
            LogIn tt = new LogIn();
            tt.Show();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pass_TextChanged(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(pass.Text))
            {
                errorProvider1.SetError(pass, "Password required!");
            }
            else if (!Regex.IsMatch(pass.Text, @"[A-Za-z][A-Za-z0-9]{2,7}"))
            {
                errorProvider1.SetError(pass, "Password invalid!");
            }
            else
            {
                errorProvider1.SetError(pass, null);
            }
        }

        private void cnfpass_TextChanged(object sender, EventArgs e)
        {
           

            if ((string.IsNullOrEmpty(pass.Text)) && (string.IsNullOrEmpty(cnfpass.Text)))
            {
                errorProvider1.SetError(cnfpass, "Password required!");
                cnfpass.Focus();
                return;
            }
            else if ((!Regex.IsMatch(pass.Text, @"[A-Za-z][A-Za-z0-9]{2,7}")) != (!Regex.IsMatch(cnfpass.Text, @"[A-Za-z][A-Za-z0-9]{2,7}")))
            {
                errorProvider1.SetError(cnfpass, "Password invalid!");
                cnfpass.Focus();
                return;
            }
            else
            {
                errorProvider1.SetError(cnfpass, null);
                cnfpass.Focus();
                return;
            }
        }

        private void userId_TextChanged(object sender, EventArgs e)
        {
            
             if (string.IsNullOrEmpty(userId.Text))
            {
                errorProvider1.SetError(userId, "UserId required!");
            }
            else if (!Regex.IsMatch(userId.Text, @"^[0-9]*$"))
            {
                errorProvider1.SetError(userId, "UserId invalid!");
            }
            else
            {
                errorProvider1.SetError(userId, null);
            }
        }

        private void nam_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(nam.Text))
            {
                errorProvider1.SetError(nam, "Name required!");
            }
            else if (!Regex.IsMatch(nam.Text, @"([a-zA-Z]{3,30}\s*)+"))
            {
                errorProvider1.SetError(nam, "Name invalid!");
            }
            else
            {
                errorProvider1.SetError(nam, null);
            }
        }

        private void lnam_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(lnam.Text))
            {
                errorProvider1.SetError(lnam, "Last Name is required!");
            }
            else if (!Regex.IsMatch(lnam.Text, @"([a-zA-Z]{3,30}\s*)+"))
            {
                errorProvider1.SetError(lnam, "Last Name is invalid!");
            }
            else
            {
                errorProvider1.SetError(lnam, null);
            }
        }

        private void fnam_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(fnam.Text))
            {
                errorProvider1.SetError(fnam, "Father Name is required!");
            }
            else if (!Regex.IsMatch(fnam.Text, @"([a-zA-Z]{3,30}\s*)+"))
            {
                errorProvider1.SetError(fnam, "Father Name is invalid!");
            }
            else
            {
                errorProvider1.SetError(fnam, null);
            }
        }

        private void nam_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }

        private void fnam_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void fnam_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }

        private void province_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void lnam_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }

        private void clubnam_TextChanged(object sender, EventArgs e)
        {

        }

        private void clubnam_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }
    }
}

