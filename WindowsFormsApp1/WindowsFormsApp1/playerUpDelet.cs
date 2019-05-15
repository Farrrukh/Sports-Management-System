using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;


namespace WindowsFormsApp1
{
    public class playerUpDelet:DbConnection,IShowDataInGridview,IDataDelete
    {


        internal  void  playerUpdate(TextBox name, TextBox lastName, TextBox fatherName, TextBox clubName, DateTimePicker dateOfBirth, ComboBox gender, TextBox playerId, ComboBox province, ComboBox city, TextBox password, TextBox confirmPass, ComboBox selectPlayer)
        {
            try
            {

                this.SaveData("UPDATE playerregs set name='" + name.Text + "',lastname='" + lastName.Text + "',fathername='" + fatherName.Text + "',clubname='" + clubName.Text + "',dateofbirth ='" + dateOfBirth.Text + "',gender='" + gender.Text + "',province='" + province.Text + "',city='" + city.Text + "',password='" + password.Text + "',confirmpassword='" + confirmPass.Text + "',selectac='" + selectPlayer.Text + "' where userId=" + playerId.Text + "");
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        public void delete(TextBox playerId)
        {

            this.SaveData("DELETE  FROM playerregs  where userId= '" + playerId.Text + "'");

        }
        public void show(DataGridView data)
        {

            data.DataSource = this.GetData("select name,lastname,fathername,clubname,dateofbirth,gender,userId,province,city,selectac  from playerregs");




        }

    }


   
}

