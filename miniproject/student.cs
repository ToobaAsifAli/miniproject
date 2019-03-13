using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace miniproject
{
    public partial class student : MaterialSkin.Controls.MaterialForm
    {

       SqlConnection con = new SqlConnection("Data Source=DESKTOP-R6RA1PL\\TOOBAASIF;Initial Catalog=ProjectA;Persist Security Info=True;User ID=sa;Password=1212");

        public student()
        {
            InitializeComponent();
        }

        private void Savebutton_Click(object sender, EventArgs e)
        {
            con.Open();




            string congo = comboBox1.SelectedItem.ToString();

            string genderValue = "select Id FROM Lookup WHERE Category = 'Gender' AND value ='" + congo + "'";
            SqlCommand genderInt = new SqlCommand(genderValue, con);
            int value = 0;
            SqlDataReader reader = genderInt.ExecuteReader();
            // genderInt.ExecuteNonQuery();
            while (reader.Read())
            {
                value = int.Parse(reader[0].ToString());
            }

            //int gender = Convert.ToInt32(genderInt.ExecuteScalar ());

            string per = "INSERT into Person(FirstName , LastName , Contact , Email , DateOfBirth , Gender) values ('" + textBox1.Text + "' , '" + textBox2.Text + "' , '" + textBox3.Text + "' , '" + textBox4.Text + "' , '" + textBox5.Text + "' , '" + value + "')";
            con.Close();
            con.Open();
            SqlCommand persi = new SqlCommand(per, con);
            int i = persi.ExecuteNonQuery();

            int value1 = 0;
            //----------------------------------------------------------------------------------------
            string query = "Select Id from Person where (Id = SCOPE_IDENTITY())";
            SqlCommand cmd = new SqlCommand(query, con);
            var val = cmd.ExecuteScalar().ToString();
            value1 = int.Parse(val);
            //---------------------------------------------------------------------------------------------
            string q = "insert into Student values('" + value1 + "','" + textBox7.Text.ToString() + "')";
            SqlCommand cmd1 = new SqlCommand(q, con);
            int j = cmd1.ExecuteNonQuery();
            //  string S_ID = string.Format("Select Id FROM Person where Email ='{0}'", email);
            // SqlCommand StuID = new SqlCommand(S_ID, conn);
            // int Id = Convert.ToInt32(StuID.ExecuteScalar());
            // string st = "Insert into Student values( '" + Id + "' ,'" + textBox1.Text + "')";
            // SqlCommand std = new SqlCommand(st, conn);
            // int ii = std.ExecuteNonQuery();


            con.Close();
            disp_data();
           
            MessageBox.Show("Data Inserted");
        

        //--------------------------------------------------------
        //con.Open();
        //SqlCommand cmd = con.CreateCommand();
        //cmd.CommandType = CommandType.Text;
        //cmd.CommandText = "insert into Person values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + comboBox1.Text + "')";// + "insert into Student values('" + textBox7.Text + "')";
        //cmd.ExecuteNonQuery();
        ////con.Close();
        //textBox1.Text = "";
        //textBox2.Text = "";
        //textBox3.Text = "";
        //textBox4.Text = "";
        //textBox5.Text = "";

        //comboBox1.Text = "";
        ////   textBox7.Text = "";
        ////disp_data();
        //MessageBox.Show("Record inserted successfully");




        //cmd.CommandType = CommandType.Text;
        //cmd.CommandText = "select Id from Person where FirstName ='" + textBox1.Text + "'";

        //cmd.ExecuteNonQuery();
        //con.Close();
        //---------------------------------------------------
        //cmd.CommandType = CommandType.Text;


        //  cmd.CommandText = "Insert into student ='" + textBox5.Text + "' where FirstName = '" + textBox1.Text + "'";
        //cmd.CommandText = "Insert into student ='" + textBox7.Text + "' where FirstName = '" + textBox1.Text + "'";
        //cmd.ExecuteNonQuery();

        //con.Close();


        //getting project id from project table
        //string sid = string.format("select id from person where firstname = '" + textbox1.text + "'");
        //SqlCommand siddd = new sqlcommand(sid, con);
        //int studentid = convert.toint32(siddd.executescalar());
        //getting advisorid from advisor table
        //string adid = String.Format("SELECT Id FROM Advisor Where Salary ='{0}'", textBox4.Text);
        //SqlCommand adidd = new SqlCommand(adid, con);
        //int advisoridd = Convert.ToInt32(piddd.ExecuteScalar());

        //inserting data into in project advisor table
        //string Insertproadvisor = "Insert into Student (Id,RegistrationNo) VALUES('" + textBox1.Text + "','" + textBox7.Text+ "')";
        //SqlCommand cmd1 = new SqlCommand(Insertproadvisor, con);
        //cmd1.ExecuteNonQuery();
        //con.Close();


        //SqlConnection con = new SqlConnection();
        //con.ConnectionString = ConfigurationManager.ConnectionStrings["ProjectA"].ToString();
        //con.Open();
        //SqlCommand cmd1 = new SqlCommand("Insert into Person(FirstName,LastName,Contact,Email,DateOfBirth,Gender) values (@FirstName,@LastName,@Contact,@Email,@DateOfBirth,@Gender)", con);
        //cmd1.Parameters.AddWithValue("@FirstName", textBox1.Text);
        //cmd1.Parameters.AddWithValue("@LastName", textBox2.Text);
        //cmd1.Parameters.AddWithValue("@Contact", textBox3.Text);
        //cmd1.Parameters.AddWithValue("@Email", textBox4.Text);
        //cmd1.Parameters.AddWithValue("@DateOfBirth", textBox5.Text);
        //cmd1.Parameters.AddWithValue("@Gender", comboBox1.Text);

        //cmd1.ExecuteNonQuery();
        //cmd1.Parameters.Clear();


        //SqlCommand cmd2 = new SqlCommand("Insert into Student(RegistrationNo) values (@RegistrationNo)", con);
        //cmd2.Parameters.AddWithValue("@RegistrationNo", textBox7.Text);

        //cmd2.ExecuteNonQuery();
        //cmd2.Parameters.Clear();
        //MessageBox.Show("data in inserted successfully");


        //if(con.State == ConnectionState.Closed)
        //{
        //    con.Open();
        //}

        //string cmd  ="select Person.Id as ID"
        //    sql command = new SqlCommand(cmd, con);


        //con.Open();
        //SqlCommand cmd1 = con.CreateCommand();
        //cmd1.CommandType = CommandType.Text;
        //cmd1.CommandText = "SELECT Person.Id ,Person.FirstName, Person.LastName, Person.Contact, Person.Email, Person.DateOfBirth, Person.Gender, Student.RegistrationNo FROM Person JOIN Student ON Student.Id = Person.Id";
        //cmd1.ExecuteNonQuery();
        //DataTable dt = new DataTable();
        //SqlDataAdapter dat = new SqlDataAdapter(cmd1);
        //dat.Fill(dt);
        //dataGridView1.DataSource = dt;
        //con.Close();
        //string InsertregistrationNo = "SELECT Person.Id ,Person.FirstName, Person.LastName, Person.Contact, Person.Email, Person.DateOfBirth, Person.Gender, Student.RegistrationNo FROM Person JOIN Student ON Student.Id = Person.Id";
        //SqlCommand pidd = new SqlCommand(InsertregistrationNo, con);
        //pidd.ExecuteNonQuery();
        //con.Close();




    }
        public void disp_data()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT Person.Id ,Person.FirstName, Person.LastName, Person.Contact, Person.Email, Person.DateOfBirth, Person.Gender, Student.RegistrationNo FROM Person JOIN Student ON Student.Id = Person.Id";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void student_Load(object sender, EventArgs e)
        {
            disp_data();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Searchbutton_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Person where FirstName ='"+textBox1.Text+"'";
            textBox4.Text = "";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
         
            con.Close();
            disp_data();
        }

        private void Deletebutton_Click(object sender, EventArgs e)
        {
            //con.Open();
            //SqlCommand cmd = con.CreateCommand();
            //cmd.CommandType = CommandType.Text;
            //// cmd.CommandText = "delete from Person where values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "')";
            //cmd.CommandText = "delete from Person where FirstName ='"+textBox1.Text+"'";

            //cmd.ExecuteNonQuery();
            //con.Close();

            //disp_data();


            ////dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
            //MessageBox.Show("Record deleted successfully");


            //string del = string.Format("Delete From Person Where Id = '{0}'", Id);
            //SqlCommand delete = new SqlCommand(del);
            //if (MessageBox.Show("Do You want to delete it", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            //{
            //    MessageBox.Show("DATA IS DELETED");
            //}
            //else
            //{
            //    MessageBox.Show("Row not deleted", "Remove row", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            //disp_data();


        
            con.Open();
            string display = String.Format("DELETE FROM Student WHERE RegistrationNo = '{0}'", textBox7.Text);
            SqlCommand cmd = new SqlCommand(display, con);
            cmd.ExecuteNonQuery();

            //cmd.CommandText = string.Format("DELETE FROM Person WHERE Email = '{0}'", email);
            //cmd.ExecuteNonQuery();
            con.Close();
            disp_data();





        }

        private void Updatebutton_Click(object sender, EventArgs e)
        {
            //con.Open();
            //SqlCommand cmd = con.CreateCommand();
            //cmd.CommandType = CommandType.Text;
            //// cmd.CommandText = "delete from Person where values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "')";
            //cmd.CommandText = "delete from Person where FirstName ='" + textBox4.Text + "'";
            //cmd.ExecuteNonQuery();
            //cmd.CommandText = "insert into Person values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "')";
            //cmd.ExecuteNonQuery();
            //con.Close();
            //disp_data();
            //MessageBox.Show("Record Updated successfully");
            //con.Open();
            //string query = "delete from Person where FirstName = '" + textBox4.Text + "'";
            //SqlDataAdapter sda = new SqlDataAdapter(query, con);
            //sda.SelectCommand.ExecuteNonQuery();
            //con.Close();

            //      con.Open();
            //      SqlCommand cmd = con.CreateCommand();
            //      cmd.CommandType = CommandType.Text;
            //      // cmd.CommandText = "delete from Person where values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "')";
            //    //  cmd.CommandText = "update Person set name ='" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text +"' where FirstName = '"+textBox1.Text+"'";

            ////      cmd.CommandText = "update Person set LastName ='" + textBox2.Text + "' where FirstName = '" + textBox1.Text + "'";
            ////      cmd.CommandText = "update Person set Contact ='" + textBox3.Text + "' where FirstName = '" + textBox1.Text + "'";
            ////      cmd.CommandText = "update Person set Email ='" + textBox4.Text + "' where FirstName = '" + textBox1.Text + "'";
            ////      cmd.CommandText = "update Person set DateOfBirth ='" + textBox5.Text + "' where FirstName = '" + textBox1.Text + "'";
            //////      cmd.CommandText = "update Student set RegrationNo ='" + textBox7.Text + "' where Person.FirstName = '" + textBox1.Text + "'";
            //////      cmd.CommandText = "update Person set Gender ='" + comboBox1.Text + "' where FirstName = '" + textBox1.Text + "'";








            //      // cmd.CommandText = "update Person set LastName ='" + textBox2.Text + "'update Person set Gender = '" + textBox6.Text + "'where FirstName = '" + textBox1.Text + "'";


            //      cmd.ExecuteNonQuery();
            //      con.Close();

            //      disp_data();


            //      //dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
            //      MessageBox.Show("Record updated successfully");




            con.Open();
            string display = String.Format("UPDATE PERSON WHERE RegistrationNo = '{0}'", textBox7.Text);
          //  string display = String.Format("UPDATE Person set FirstName = '" + textBox1.Text + "'WHERE RegistrationNo = '{0}'", textBox7.Text); 
            SqlCommand cmd = new SqlCommand(display, con);
            cmd.ExecuteNonQuery();

            //cmd.CommandText = string.Format("DELETE FROM Person WHERE Email = '{0}'", email);
            //cmd.ExecuteNonQuery();
            con.Close();
            disp_data();



        }



        private void Displaybutton_Click(object sender, EventArgs e)
        {
            disp_data();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
