using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    class playershowinfo:DbConnection,IShowDataInGridview
    {
        public void show(DataGridView data)
        {
            try
            {

                data.DataSource = this.GetData("select name,lastname,fathername,clubname,dateofbirth,gender,province,city,selectac  from playerregs");
            }
            catch(Exception e) {
                MessageBox.Show(e.Message);
            }



        }
    }
}
