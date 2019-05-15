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
    public partial class tournament : MaterialSkin.Controls.MaterialForm
    {
        public tournament()
        {
            InitializeComponent();
        }

        private void tournament_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TournamentShow newtr = new TournamentShow();
            newtr.shows(dataGridView1);
            newtr.show(dataGridView1);
           
        }
    }
}
