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
    public partial class playerinfo : MaterialSkin.Controls.MaterialForm
    {
        public playerinfo()
        {
            InitializeComponent();
        }

        private void playerinfo_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            playerinf newpr = new playerinf();
            newpr.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tournament newtourn = new tournament();
            newtourn.Show();
        }

        private void matches_Click(object sender, EventArgs e)
        {
            Maches newmach = new Maches();
            newmach.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
