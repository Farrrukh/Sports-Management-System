using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    class TournamentUpdate:DbConnection,IDataDelete,IShowDataInGridview
    {
        public void tournamentInsert(TextBox tournamentName,TextBox noOfTeam,TextBox noOfMatches,ComboBox provice)
        {
            try
            {
                this.SaveData("INSERT INTO Tournament(TournamentName,NoOfTeams,NoOfMatches,Province) VALUES('" + tournamentName.Text + "','" + noOfTeam.Text + "','" + noOfMatches.Text + "','" + provice.Text + "')");
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        public void tournamentUpdate(TextBox tournamentName, TextBox noOfTeam, TextBox noOfMatches, ComboBox provice)
        {
            try
            {
                this.SaveData("UPDATE Tournament set TournamentName='" + tournamentName.Text + "',NoOfMatches='" + noOfMatches.Text + "',Province='" + provice.Text + "' where NoOfTeams=" + noOfTeam.Text + "");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        public void delete(TextBox idDelete)
        {
            try
            {
                this.SaveData("DELETE  FROM Tournament  where NoOfTeams= '" + idDelete.Text + "'");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        public void show(DataGridView dataShow)
        {
            try
            {
                dataShow.DataSource = this.GetData("select TournamentName,NoOfTeams,NoOfMatches,Province from Tournament");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
    }
}
