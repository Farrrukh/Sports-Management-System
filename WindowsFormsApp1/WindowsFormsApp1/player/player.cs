using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.ComponentModel;
using System.IO;





namespace WindowsFormsApp1
{
    public class PlayerRegisteration : DbConnection
    {


        public void playerRegisteration(TextBox a)
        {
            this.newName = a.Text;
            try
            {
                if (newName == " ")
                {
                    MessageBox.Show("plzz inter username");
                }
                else
                {
                    this.SaveData("INSERT INTO playerregs(newName ) VALUES('" + newName + "')");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        public void playerRegisteration(TextBox a, TextBox b)
        {

            this.newName = a.Text;
            this.newLastName = b.Text;
            try
            {
                if (newName == " " && newLastName == " ")
                {
                    MessageBox.Show("plzz enter name and lastname");
                }
                else
                {
                    this.SaveData("INSERT INTO playerregs(name,lastname) VALUES('" + newName + "','" + newLastName + "')");
                }
            }
            catch(Exception e){
                MessageBox.Show(e.Message);
            }
           
        }
        public void playerRegisteration(TextBox a, TextBox b, TextBox c)
        {

            this.newName = a.Text;
            this.newLastName = b.Text;
            this.fatherName = c.Text;
            try
            { if(newName==" " && newLastName==" " && fatherName==" "){
                MessageBox.Show("plzz insert the name lastname and father name");
            }
            else{
                this.SaveData("INSERT INTO playerregs(name,lastname,fathername) VALUES('" + newName + "','" + newLastName + "','" + fatherName + "')");
            }
            }
            catch(Exception e){
                MessageBox.Show(e.Message);
            }
        }
        public void playerRegisteration(TextBox a, TextBox b, TextBox c, TextBox d)
        {

            this.newName = a.Text;
            this.newLastName = b.Text;
            this.fatherName = c.Text;
            try
            {
                
                this.SaveData("INSERT INTO playerregs(name,lastname,fathername,clubname) VALUES('" + newName + "','" + newLastName + "','" + fatherName + "','" + d.Text + "')");
            
            }
            catch(Exception e){
                MessageBox.Show(e.Message);
            }
        }
        public void playerRegisteration(TextBox a, TextBox b, TextBox c, TextBox d, DateTimePicker e)
        {

            this.newName = a.Text;
            this.newLastName = b.Text;
            this.fatherName = c.Text;
            this.UserId = d.Text;

            this.SaveData("INSERT INTO playerregs(name,lastname,fathername,clubname,dateofbirth) VALUES('" + newName + "','" + newLastName + "','" + fatherName + "','" + UserId + "','" + e.Text + "')");
            
        }

        public void playerRegisteration(TextBox a, TextBox b, TextBox c, TextBox d, DateTimePicker e, ComboBox f)
        {

            this.newName = a.Text;
            this.newLastName = b.Text;
            this.fatherName = c.Text;
            

            this.SaveData("INSERT INTO playerregs(name,lastname,fathername,clubname,dateofbirth,gender) VALUES('" + newName + "','" + newLastName + "','" + fatherName + "','" + d.Text + "','" + e.Text + "','" + f.Text + "')");
           
        }
        public void playerRegisteration(TextBox a, TextBox b, TextBox c, TextBox d, DateTimePicker e, ComboBox f,  TextBox z)
        {

            this.newName = a.Text;
            this.newLastName = b.Text;
            this.fatherName = c.Text;
            this.UserId = z.Text;
           
                if (newName == " " && newLastName == " " && fatherName == " " && UserId == " ")
                {
                    MessageBox.Show("Please Enter Correct");
                }
                else
                {
                    this.SaveData("INSERT INTO playerregs(name,lastname,fathername,clubname,dateofbirth,gender,userId) VALUES('" + newName + "','" + newLastName + "','" + fatherName + "','" + d.Text + "','" + e.Text + "','" + f.Text + "','" + UserId + "')");
                }
            
            

           

        }
        public void playerRegisteration(TextBox a, TextBox b, TextBox c, TextBox d, DateTimePicker e, ComboBox f, TextBox z, ComboBox g)
        {

            this.newName = a.Text;
            this.newLastName = b.Text;
            this.fatherName = c.Text;
            this.UserId = d.Text;

            this.SaveData("INSERT INTO playerregs(name,lastname,fathername,clubname,dateofbirth,gender,userId,province) VALUES('" + newName + "','" + newLastName + "','" + fatherName + "','" + UserId + "','" + e.Text + "','" + f.Text + "','" + g.Text + "')");
           

        }
        public void playerRegisteration(TextBox a, TextBox b, TextBox c, TextBox d, DateTimePicker e, ComboBox f, TextBox z, ComboBox g, ComboBox h)
        {

            this.newName = a.Text;
            this.newLastName = b.Text;
            this.fatherName = c.Text;
            this.UserId = d.Text;

            this.SaveData("INSERT INTO playerregs(name,lastname,fathername,clubname,dateofbirth,gender,userId,province,city) VALUES('" + newName + "','" + newLastName + "','" + fatherName + "','" + UserId + "','" + e.Text + "','" + f.Text + "','" + g.Text + "','" + h.Text + "')");
            
        }


        public void playerRegisteration(TextBox a, TextBox b, TextBox c, TextBox d, DateTimePicker e, ComboBox f, TextBox z, ComboBox g, ComboBox h, TextBox i, TextBox j)
        {

            this.newName = a.Text;
            this.newLastName = b.Text;
            this.fatherName = c.Text;
            this.UserId = z.Text;
            this.newPassword = i.Text;
            this.newConfirmPassword = j.Text;
           
            if(newName==" " && newLastName==" " && fatherName==" "&&UserId==" "&&newPassword==" "&&newConfirmPassword==" " ){
                MessageBox.Show("plzz correct");
            }
            else
            {
                this.SaveData("INSERT INTO playerregs(name,lastname,fathername,clubname,dateofbirth,gender,userId,province,city,password,confirmpassword) VALUES('" + newName + "','" + newLastName + "','" + fatherName + "','" + d.Text + "','" + e.Text + "','" + f.Text + "','" + z.Text + "','" + g.Text + "','" + h.Text + "','" + newPassword + "','" + newConfirmPassword + "')");
            }
           



        }
        public void playerRegisteration(TextBox a, TextBox b, TextBox c, TextBox d, DateTimePicker e, ComboBox f, TextBox z, ComboBox g, ComboBox h, TextBox i, TextBox j, ComboBox l)
        {

            this.newName = a.Text;
            this.newLastName = b.Text;
            this.fatherName = c.Text;
            this.UserId = z.Text;
            this.newPassword = i.Text;
            this.newConfirmPassword = j.Text;

           
                this.SaveData("INSERT INTO playerregs(name,lastname,fathername,clubname,dateofbirth,gender,userId,province,city,password,confirmpassword,selectac) VALUES('" + newName + "','" + newLastName + "','" + fatherName + "','" + d.Text + "','" + e.Text + "','" + f.Text + "','" + UserId + "','" + g.Text + "','" + h.Text + "','" + newPassword + "','" + newConfirmPassword + "','" + l.Text + "')");
            
           
        }
      
    }

}



