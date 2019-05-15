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
    public partial class tournamentup : MaterialSkin.Controls.MaterialForm
    {
        public tournamentup()
        {
            InitializeComponent();
        }

        private void tournamentup_Load(object sender, EventArgs e)
        {

        }

        private void tournamentup_Load_1(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            TournamentUpdate newtr = new TournamentUpdate();
            newtr.tournamentUpdate(tname, noteam, nomatches, prov);
            MessageBox.Show("Tournament updated Successfully");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TournamentUpdate newtr = new TournamentUpdate();
            newtr.tournamentInsert(tname, noteam, nomatches, prov);
            MessageBox.Show("Tournament Insert Successfully");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TournamentUpdate newtr = new TournamentUpdate();
            newtr.delete(noteam);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            TournamentUpdate newtr = new TournamentUpdate();
            newtr.show(dataGridView1);
        }

        private void noteam_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void nomatches_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void noteam_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
