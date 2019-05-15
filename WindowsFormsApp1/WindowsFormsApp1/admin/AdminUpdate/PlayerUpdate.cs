using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class PlayerUpdate : MaterialSkin.Controls.MaterialForm
    {
        public PlayerUpdate()
        {
            InitializeComponent();
        }

        private void PlayerUpdate_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            playerUpDelet newdel = new playerUpDelet();
            newdel.playerUpdate(name, lastnam, fname, clubnames, dateTimePicker1, comboBox1, userId, province, city, pass, cnfpass, comboBox2);
            MessageBox.Show("data updated");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PlayerRegisteration newplayerreg = new PlayerRegisteration();
            newplayerreg.playerRegisteration(name, lastnam, fname, clubnames, dateTimePicker1, comboBox1, userId, province, city, pass, cnfpass,comboBox2 );
            MessageBox.Show("data inserted");
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            playerUpDelet newpl = new playerUpDelet();
            //newupdatedet.playerDelet(name, lastnam, fname, clubnames, dateTimePicker1, males, userId, province, city, pass, cnfpass, footballerr);
            //MessageBox.Show("data deleted");
            newpl.delete(userId);
            MessageBox.Show("data delete successfully");

        }

        private void button4_Click(object sender, EventArgs e)
        {
            playerUpDelet newpl = new playerUpDelet();
            newpl.show(dataGridView1);
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void name_TextChanged(object sender, EventArgs e)
        {

        }

        private void name_KeyPress(object sender, KeyPressEventArgs e)
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

        private void fname_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void fname_KeyPress(object sender, KeyPressEventArgs e)
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

        private void lastnam_KeyPress(object sender, KeyPressEventArgs e)
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
