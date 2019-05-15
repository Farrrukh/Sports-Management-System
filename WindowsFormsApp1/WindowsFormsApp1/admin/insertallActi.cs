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
    public partial class insertallActi : MaterialSkin.Controls.MaterialForm
    {
        public insertallActi()
        {
            InitializeComponent();
        }

        private void insertallActi_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            tournamentup newtournament = new tournamentup();
            newtournament.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PlayerUpdate newplayer = new PlayerUpdate();
            newplayer.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TeamUpdate newteamUpdate = new TeamUpdate();
            newteamUpdate.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            machesup newmach = new machesup();
            newmach.Show();
        }
    }
}
