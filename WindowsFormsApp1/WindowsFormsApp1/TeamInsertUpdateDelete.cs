using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    class TeamInsertUpdateDelete : DbConnection, IShowDataInGridview, IDataDelete
    {

        public void TeamInsert(TextBox teamName,TextBox id)
        {
            try
            {
                this.SaveData("INSERT INTO TeamInsert(TeamtName,id) VALUES('" + teamName.Text + "','" + id.Text + "')");
            }catch(Exception e){
                MessageBox.Show(e.Message);

                
            }

        }
        public void TeamUpdate(TextBox teamName, TextBox id)
        {
            try
            {
                this.SaveData("UPDATE TeamInsert set TeamName='" + teamName.Text + "' where id=" + id.Text + "");
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
                this.SaveData("DELETE  FROM TeamInsert  where id= '" + idDelete.Text + "'");
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
                dataShow.DataSource = this.GetData("select TeamtName from TeamInsert");
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
            }
        }
    }
}
