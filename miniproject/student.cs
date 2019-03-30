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
using System.Text.RegularExpressions;

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
            try
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
                if (!Regex.Match(textBox7.Text, @"^\d{4}(-[A-Z][A-Z])(-\d{3})").Success)
                {
                    // address was incorrect
                    MessageBox.Show("Invalid Registration Number", "Message", MessageBoxButtons.OK);
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

                string gender = comboBox1.SelectedItem.ToString();

                string gdv = "select Id FROM Lookup WHERE Category = 'Gender' AND value ='" + gender + "'";
                SqlCommand genderInt = new SqlCommand(gdv, con);
                int s = 0;
                SqlDataReader reader = genderInt.ExecuteReader();

                while (reader.Read())
                {
                    s = int.Parse(reader[0].ToString());
                }


                con.Close();
                con.Open();

                string ps = "INSERT into Person(FirstName , LastName , Contact , Email , DateOfBirth , Gender) values ('" + textBox1.Text + "' , '" + textBox2.Text + "' , '" + textBox3.Text + "' , '" + textBox4.Text + "' , '" + textBox5.Text + "' , '" + s + "')";

                SqlCommand persi = new SqlCommand(ps, con);
                int a = persi.ExecuteNonQuery();

                int s1 = 0;
                //----------------------------------------------------------------------------------------
                string que = "Select Id from Person where (Id = SCOPE_IDENTITY())";
                SqlCommand cmd = new SqlCommand(que, con);
                var v = cmd.ExecuteScalar().ToString();
                s1 = int.Parse(v);
                //---------------------------------------------------------------------------------------------
                string q = "insert into Student values('" + s1 + "','" + textBox7.Text.ToString() + "')";
                SqlCommand cmd1 = new SqlCommand(q, con);
                int k = cmd1.ExecuteNonQuery();
                if (MessageBox.Show("Do you really want to register this student", "Register", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    MessageBox.Show("Record has been inserted successfully");
                }

                con.Close();
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox7.Text = "";
                comboBox1.Text = "";

                disp_data();
                //MessageBox.Show("Data Inserted");

            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message);
            }
        }


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




    
        public void disp_data()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
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
            try
            {


                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                string display = String.Format("DELETE FROM Student WHERE RegistrationNo = '{0}'", textBox7.Text);
                SqlCommand cmd = new SqlCommand(display, con);
                cmd.ExecuteNonQuery();

                //cmd.CommandText = string.Format("DELETE FROM Person WHERE Email = '{0}'", email);
                //cmd.ExecuteNonQuery();
                con.Close();
                disp_data();

                if (MessageBox.Show("Do you really want to delete this record", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    MessageBox.Show("Record has been inserted successfully");
                }


            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message);
            }
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




            //  con.Open();
            //  string display = String.Format("UPDATE PERSON WHERE RegistrationNo = '{0}'", textBox7.Text);
            ////  string display = String.Format("UPDATE Person set FirstName = '" + textBox1.Text + "'WHERE RegistrationNo = '{0}'", textBox7.Text); 
            //  SqlCommand cmd = new SqlCommand(display, con);
            //  cmd.ExecuteNonQuery();

            //  //cmd.CommandText = string.Format("DELETE FROM Person WHERE Email = '{0}'", email);
            //  //cmd.ExecuteNonQuery();
            //  con.Close();
            //  disp_data();



            //if (con.State == ConnectionState.Closed)
            //{
            //    con.Open();
            //}

            //string gdv = "select Id FROM Lookup WHERE Category = 'GENDER' AND value ='" + comboBox1.Text.ToString() + "'";
            //SqlCommand genderInt = new SqlCommand(gdv, con);
            //int s = 0;
            //SqlDataReader reader3 = genderInt.ExecuteReader();
            //// genderInt.ExecuteNonQuery();
            //while (reader3.Read())
            //{
            //    s = int.Parse(reader3[0].ToString());
            //}
            ////FirstName ='" + textBox2.Text + "' ,
            //string que1 = string.Format("SELECT Id from Person Where Email = '" + textBox4.Text + "'");
            //SqlCommand cmd = new SqlCommand(que1, con);
            //var aa = cmd.ExecuteScalar().ToString();
            //int s1 = int.Parse(aa);
            //// int id =int.Parse( cmd.ExecuteScalar());
            //string ps = "Update Person set FirstName ='" + textBox1.Text + "' ,  LastName= '" + textBox2.Text + "' , Contact = '" + textBox3.Text + "', Email = '" + textBox4.Text + "', DateOfBirth ='" + DateTime.Parse(textBox5.Text) + "', Gender = '" + s + "' WHERE Id= '" + s1 + "'";
            //SqlCommand pesi = new SqlCommand(ps, con);
            //int a = pesi.ExecuteNonQuery();
            //string gender = comboBox2.Text.ToString();
            //string desi = "select Id FROM Lookup WHERE Category = 'DESIGNATION' AND Value ='" + gender + "'";
            //SqlCommand d = new SqlCommand(desi, con);
            //int s2 = 0;
            //SqlDataReader reader4 = d.ExecuteReader();
            //// genderInt.ExecuteNonQuery();
            //while (reader4.Read())
            //{
            //    s2 = int.Parse(reader4[0].ToString());
            //}
            //string st = "Update Advisor set Designation = '" + s2 + "',Salary = '" + int.Parse(textBox7.Text) + "' where Id ='" + s1 + "'";
            //SqlCommand persi1 = new SqlCommand(st, con);
            ////int j = persi1.ExecuteNonQuery();


            //if (MessageBox.Show("Do you really want to Update this record", "Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            //{

            //    MessageBox.Show("Record has been updated successfully");
            //}
            //else
            //{
            //    MessageBox.Show("Row not Updated", "Update row", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            //con.Close();
            //textBox1.Text = "";
            //textBox2.Text = "";
            //textBox3.Text = "";
            //textBox4.Text = "";
            //textBox5.Text = "";
            //textBox7.Text = "";
            //comboBox1.Text = "";
            //comboBox2.Text = "";
            //disp_data();

            try
            {

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
                int a = pesi.ExecuteNonQuery();


                //// MessageBox.Show("In Middle"+ a.ToString());

                //string gender = comboBox2.Text.ToString();
                //string desi = "select Id FROM Lookup WHERE Category = 'DESIGNATION' AND Value ='" + gender + "'";
                //SqlCommand d = new SqlCommand(desi, con);
                //int s2 = 0;
                //SqlDataReader reader4 = d.ExecuteReader();
                //// genderInt.ExecuteNonQuery();
                //while (reader4.Read())
                //{
                //    s2 = int.Parse(reader4[0].ToString());
                //}
                //string st = "Update Advisor set Designation = '" + s2 + "',Salary = '" + int.Parse(textBox7.Text) + "' where Id ='" + s1 + "'";
                //reader4.Close();
                //SqlCommand persi1 = new SqlCommand(st, con);
                //persi1.ExecuteNonQuery();


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

                disp_data();

            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message);
            }


        }



        private void Displaybutton_Click(object sender, EventArgs e)
        {
            try
            {
                disp_data();
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddStudent f2 = new AddStudent();
            this.Hide();
            f2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f3 = new Form1();
            this.Hide();
            f3.Show();
        }
    }
}
