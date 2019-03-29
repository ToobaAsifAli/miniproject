using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace miniproject
{
    public partial class AddAdvisor : MaterialSkin.Controls.MaterialForm
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-R6RA1PL\\TOOBAASIF;Initial Catalog=ProjectA;Persist Security Info=True;User ID=sa;Password=1212");

        public AddAdvisor()
        {
            InitializeComponent();
        }

        private void AddAdvisor_Load(object sender, EventArgs e)
        {

        }

        private void Savebutton_Click(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" ||
                textBox7.Text == "")


            {
                // display popup box
                MessageBox.Show("Please fill in all fields", "Error", MessageBoxButtons.OK);
                textBox1.Focus(); // set focus to lastNameTextBox
                return;
            } // end if 
            // if first name format invalid show message
            if (!Regex.Match(textBox1.Text, "^[A-Z][a-zA-Z]*$").Success)
            {
                // first name was incorrect
                MessageBox.Show("Invalid first name", "Message", MessageBoxButtons.OK);
                textBox1.Focus();
                return;
            } // end if 
            // if last name format invalid show message
            if (!Regex.Match(textBox2.Text, "^[A-Z][a-zA-Z]*$").Success)
            {
                // last name was incorrect
                MessageBox.Show("Invalid last name", "Message", MessageBoxButtons.OK);
                textBox2.Focus();
                return;
            }// end if          
             // if address format invalid show message
             // if (!Regex.Match(textBox7.Text, @"^[0-9]+\s+([a-zA-Z]+|[a-zA-Z]+\s[a-zA-Z]+)$").Success)
             //  //if (!Regex.Match(phoneTextBox.Text, @"^[1-9]\d{2}-[1-9]\d{2}-\d{4}$").Success)
            // (@"[\d]"
            if (!Regex.Match(textBox7.Text, @"[\d]").Success)
            {
                // address was incorrect
                MessageBox.Show("Invalid salary", "Message", MessageBoxButtons.OK);
                textBox7.Focus();
                return;
            } // end if

            //------------------------------------------------------------------------------------
            // if city format invalid show message

            if (!Regex.Match(textBox3.Text, @"^([0-9]{4})\-([0-9]{7})$").Success)
            {
                // city was incorrect
                MessageBox.Show("Invalid Contact Number", "Message", MessageBoxButtons.OK);
                textBox3.Focus();
                return;
            }// end if 
             // if state format invalid show message
            if (!Regex.Match(textBox5.Text, @"(((0|1)[0-9]|2[0-9]|3[0-1])\/(0[1-9]|1[0-2])\/((19|20)\d\d))$").Success)
            {
                // state was incorrect
                MessageBox.Show("Invalid date", "Message", MessageBoxButtons.OK);
                textBox5.Focus();
                return;
            } // end if 
              // if zip code format invalid show message
            if (!Regex.Match(textBox4.Text, @"^([\w]+)@([\w]+)\.([\w]+)$").Success)
            {
                // zip was incorrect
                MessageBox.Show("Invalid email address", "Message", MessageBoxButtons.OK);
                textBox4.Focus();
                return;
            } // end if
              //// if phone number format invalid show message
              //if (!Regex.Match(phoneTextBox.Text, @"^[1-9]\d{2}-[1-9]\d{2}-\d{4}$").Success)
              //{
              //    // phone number was incorrect
              //    MessageBox.Show("Invalid phone number", "Message", MessageBoxButton.OK, MessageBoxImage.Error);
              //    phoneTextBox.Focus();
              //    return;
              //}// end if 
              //// information is valid, signal user and exit application
              //this.Hide(); // hide main window while MessageBox displays
              //MessageBox.Show("Thank You!", "Information Correct", MessageBoxButton.OK, MessageBoxImage.Information);

            //------------------------------------------------------------------------------------




            con.Open();




            string gender = comboBox1.SelectedItem.ToString();

            string gdv = "select Id FROM Lookup WHERE Category = 'Gender' AND value ='" + gender + "'";
            SqlCommand gdInt = new SqlCommand(gdv, con);
            int s = 0;
            SqlDataReader reader = gdInt.ExecuteReader();
         
            while (reader.Read())
            {
                s = int.Parse(reader[0].ToString());
            }
            con.Close();
            con.Open();

          

            //string per = "INSERT into Person(FirstName , LastName , Contact , Email , DateOfBirth , Gender) values ('" + textBox1.Text + "' , '" + textBox2.Text + "' , '" + textBox3.Text + "' , '" + textBox4.Text + "' , '" + DateTime.Parse(textBox5.Text) + "' , '" + s + "')";
            string per = "INSERT into Person(FirstName , LastName , Contact , Email , DateOfBirth , Gender) values ('" + textBox1.Text + "' , '" + textBox2.Text + "' , '" + textBox3.Text + "' , '" + textBox4.Text + "' , '" + textBox5.Text + "' , '" + s + "')";

            SqlCommand pesi = new SqlCommand(per, con);
            int a = pesi.ExecuteNonQuery();
            int value1 = 0;
            string query = "Select Id from Person where (Id = SCOPE_IDENTITY())";
            SqlCommand cmd = new SqlCommand(query, con);
            var s1 = cmd.ExecuteScalar().ToString();
            value1 = int.Parse(s1);
            string designation = comboBox2.Text.ToString();
            string desi = "select Id FROM Lookup WHERE Category = 'DESIGNATION' AND Value ='" + designation + "'";
            SqlCommand d = new SqlCommand(desi, con);
            int s2 = 0;
            SqlDataReader reader1 = d.ExecuteReader();
      
            while (reader1.Read())
            {
                s2 = int.Parse(reader1[0].ToString());
            }
            con.Close();
            con.Open();

            string q = "insert into Advisor values('" + value1 + "','" + s2 + "' , '" + int.Parse(textBox7.Text.ToString()) + "' )";
            SqlCommand cmd1 = new SqlCommand(q, con);
            int z = cmd1.ExecuteNonQuery();
            if (MessageBox.Show("Do you want to add him as an Advisor", "Add_Advisor", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MessageBox.Show("Advisor has been assigned to you");
            }

            con.Close();
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox7.Text = "";
            comboBox1.Text = "";
            comboBox2.Text = "";
            disp_data();



          
        }

        public void disp_data()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT Person.Id ,Person.FirstName, Person.LastName, Person.Contact, Person.Email, Person.DateOfBirth, Person.Gender, Advisor.Designation, Advisor.Salary FROM Person JOIN Advisor ON Advisor.Id = Person.Id";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void Deletebutton_Click(object sender, EventArgs e)
        {
            con.Open();
            string display = String.Format("DELETE FROM Person WHERE Email = '{0}'", textBox4.Text);
            SqlCommand cmd = new SqlCommand(display, con);
            cmd.ExecuteNonQuery();

            //cmd.CommandText = string.Format("DELETE FROM Person WHERE Email = '{0}'", email);
            //cmd.ExecuteNonQuery();
            con.Close();
            disp_data();
            if (MessageBox.Show("Do you really want to delete this record", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                MessageBox.Show("Record has been deleted successfully");
            }



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

        }

        private void Updatebutton_Click(object sender, EventArgs e)
        {
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







            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            string gdv = "select Id FROM Lookup WHERE Category = 'GENDER' AND value ='" + comboBox1.Text.ToString() + "'";
            SqlCommand genderInt = new SqlCommand(gdv, con);
            int s = 0;
            SqlDataReader reader3 = genderInt.ExecuteReader();
            // genderInt.ExecuteNonQuery();
            while (reader3.Read())
            {
                s = int.Parse(reader3[0].ToString());
            }
            //FirstName ='" + textBox2.Text + "' ,
            reader3.Close();
            string que1 = string.Format("SELECT Id from Person Where Email = '" + textBox4.Text + "'");
            SqlCommand cmd = new SqlCommand(que1, con);
            var aa = cmd.ExecuteScalar().ToString();
            int s1 = int.Parse(aa);
            // int id =int.Parse( cmd.ExecuteScalar());

           cmd.ExecuteNonQuery();

            string ps = "Update Person set FirstName ='" + textBox1.Text + "' ,  LastName= '" + textBox2.Text + "' , Contact = '" + textBox3.Text + "', Email = '" + textBox4.Text + "', DateOfBirth ='" + DateTime.Parse(textBox5.Text) + "', Gender = '" + s + "' WHERE Id= '" + s1 + "'";
            SqlCommand pesi = new SqlCommand(ps, con);
            int a  = pesi.ExecuteNonQuery();


           // MessageBox.Show("In Middle"+ a.ToString());

            string gender = comboBox2.Text.ToString();
            string desi = "select Id FROM Lookup WHERE Category = 'DESIGNATION' AND Value ='" + gender + "'";
            SqlCommand d = new SqlCommand(desi, con);
            int s2 = 0;
            SqlDataReader reader4 = d.ExecuteReader();
            // genderInt.ExecuteNonQuery();
            while (reader4.Read())
            {
                s2 = int.Parse(reader4[0].ToString());
            }
            string st = "Update Advisor set Designation = '" + s2 + "',Salary = '" + int.Parse(textBox7.Text) + "' where Id ='" + s1 + "'";
            reader4.Close();
            SqlCommand persi1 = new SqlCommand(st, con);
            persi1.ExecuteNonQuery();


            if (MessageBox.Show("Do you really want to Update this record", "Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                MessageBox.Show("Record has been updated successfully");
            }
           
            con.Close();
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox7.Text = "";
            comboBox1.Text = "";
            comboBox2.Text = "";
            disp_data();




        }

        private void Displaybutton_Click(object sender, EventArgs e)
        {
            disp_data();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f2 = new Form1();
            this.Hide();
            f2.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdvisorManagement f3 = new AdvisorManagement();
            this.Hide();
            f3.Show();
        }
    }
}
