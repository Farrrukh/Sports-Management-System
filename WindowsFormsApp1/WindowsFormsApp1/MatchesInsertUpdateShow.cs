using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    class MatchesInsertUpdateShow : DbConnection, IShowDataInGridview, IDataDelete
    {
        public void matchesInsert(TextBox team1vsteam2,TextBox id,DateTimePicker date)
        {
            try
            {
                this.SaveData("INSERT INTO MatchesInsert(TeamVS1TeamVS2,id,date) VALUES('" + team1vsteam2.Text + "','" + id.Text + "','" + date.Text + "')");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }
        public void matchesUpdate(TextBox team1vsteam2,TextBox id, DateTimePicker date){
            try{
        
            this.SaveData("UPDATE MatchesInsert set TeamVS1TeamVS2='" + team1vsteam2.Text + "',date='" + date.Text + "' where id=" + id.Text + "");
    }
    catch(Exception e){
        MessageBox.Show(e.Message);

}
        }
        public void delete(TextBox idDelete)
        {
            try
            {
                this.SaveData("DELETE  FROM MatchesInsert  where id= '" + idDelete.Text + "'");
            }
            catch(Exception e){
                MessageBox.Show(e.Message);
            }
        }
        public void show(DataGridView dataShow)
        {
            try
            {
                dataShow.DataSource = this.GetData("select TeamVS1TeamVS2,date from MatchesInsert");
            }
            catch(Exception e){
                MessageBox.Show(e.Message);
            }
        }
    }
}
