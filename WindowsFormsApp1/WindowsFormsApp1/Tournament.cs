using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    class TournamentShow : DbConnection
    {
        public void shows(DataGridView dataShow)
        {

            dataShow.DataSource = this.GetData("select TournamentName,NoOfTeams,NoOfMatches,Province from Tournament");

        }
        public void show(DataGridView dataShow)
        {
            dataShow.DataSource = this.GetData("select TeamVS1TeamVS2 from MatchesInsert");
        }
       
    }
}
