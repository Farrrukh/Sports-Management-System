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
    public partial class Maches :  MaterialSkin.Controls.MaterialForm
    {
        public Maches()
        {
            InitializeComponent();
        }

        private void Maches_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TeamInsertUpdateDelete newma = new TeamInsertUpdateDelete();
            newma.show(dataGridView1);
        }
    }
}
