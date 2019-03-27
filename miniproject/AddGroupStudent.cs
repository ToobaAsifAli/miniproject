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

namespace miniproject
{
    public partial class AddGroupStudent : Form
    {


        SqlConnection con = new SqlConnection("Data Source=DESKTOP-R6RA1PL\\TOOBAASIF;Initial Catalog=ProjectA;Persist Security Info=True;User ID=sa;Password=1212");

        public AddGroupStudent()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void AddGroupStudent_Load(object sender, EventArgs e)
        {

        }

        private void Savebutton_Click(object sender, EventArgs e)
        {
            //con.Open();




            //string status = comboBox1.SelectedItem.ToString();

            //string statusvalue = "select Id FROM Lookup WHERE Category = 'Status' AND value ='" + status + "'";
            //SqlCommand statusInt = new SqlCommand(statusvalue, con);
            //int s = 0;
            //SqlDataReader reader = statusInt.ExecuteReader();

            //while (reader.Read())
            //{
            //    s = int.Parse(reader[0].ToString());
            //}


            //con.Close();
            //con.Open();

            ////string ps = "INSERT into [Group](Status , AssignmentDate) values ('" + s + "'  , '" + textBox1.Text + "')";
            //string ps = "INSERT into [Group](Created_On) values ( '" + textBox2.Text + "')";

            //SqlCommand persi = new SqlCommand(ps, con);
            //int a = persi.ExecuteNonQuery();

            //int s1 = 0;
            ////----------------------------------------------------------------------------------------
            //string que = "Select Id from [Group] where (Id = SCOPE_IDENTITY())";
            //SqlCommand cmd = new SqlCommand(que, con);
            //var v = cmd.ExecuteScalar().ToString();
            //s1 = int.Parse(v);
            ////---------------------------------------------------------------------------------------------
            //string q = "insert into GroupStudent values('" + s1 + "','" + textBox2.Text.ToString() + "' )";
            // q = "insert into GroupStudent values('" + s + "' )";
            //SqlCommand cmd1 = new SqlCommand(q, con);
            //int k = cmd1.ExecuteNonQuery();



            //int s2 = 0;
            ////----------------------------------------------------------------------------------------
            //string quex = "Select Id from [Student] where (Id = SCOPE_IDENTITY())";
            //SqlCommand cmd2 = new SqlCommand(quex, con);
            //var ve = cmd2.ExecuteScalar().ToString();
            //s2 = int.Parse(ve);
            ////---------------------------------------------------------------------------------------------
            //string qq = "insert into GroupStudent values('" + s2 + "')";//,'" + textBox2.Text.ToString() + "' ,'" + s + "')";
            //SqlCommand cmd3 = new SqlCommand(qq, con);
            //int kk = cmd3.ExecuteNonQuery();


            //con.Close();
            //textBox1.Text = "";
            //textBox2.Text = "";

            //comboBox1.Text = "";

            //disp_data();
            ////MessageBox.Show("Data Inserted");

            //if (MessageBox.Show("Do you really want to register this student", "Register", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            //{

            //    MessageBox.Show("Record has been inserted successfully");
            //}

            // con.Open();




            // string gender = comboBox1.SelectedItem.ToString();

            // string gdv = "select Id FROM Lookup WHERE Category = 'Gender' AND value ='" + gender + "'";
            // SqlCommand gdInt = new SqlCommand(gdv, con);
            // int s = 0;
            // SqlDataReader reader = gdInt.ExecuteReader();

            // while (reader.Read())
            // {
            //     s = int.Parse(reader[0].ToString());
            // }
            // con.Close();
            // con.Open();



            // //string per = "INSERT into Person(FirstName , LastName , Contact , Email , DateOfBirth , Gender) values ('" + textBox1.Text + "' , '" + textBox2.Text + "' , '" + textBox3.Text + "' , '" + textBox4.Text + "' , '" + DateTime.Parse(textBox5.Text) + "' , '" + s + "')";
            // string per = "INSERT into [Group](Created_On) values ('" + textBox2.Text + "')";

            // SqlCommand pesi = new SqlCommand(per, con);
            // int a = pesi.ExecuteNonQuery();
            // int value1 = 0;
            // string query = "Select Id from [Group] where (Id = SCOPE_IDENTITY())";
            // SqlCommand cmd = new SqlCommand(query, con);
            // var s1 = cmd.ExecuteScalar().ToString();
            // value1 = int.Parse(s1);


            // int value2 = 0;
            // string query2 = "Select Id from [student] where (Id = SCOPE_IDENTITY())";
            // SqlCommand cmd2 = new SqlCommand(query2, con);
            // var s2 = cmd.ExecuteScalar().ToString();
            // value2 = int.Parse(s2);
            // //string designation = comboBox2.Text.ToString();
            // //string desi = "select Id FROM Lookup WHERE Category = 'DESIGNATION' AND Value ='" + designation + "'";
            // //SqlCommand d = new SqlCommand(desi, con);
            // //int s2 = 0;
            // //SqlDataReader reader1 = d.ExecuteReader();

            // //while (reader1.Read())
            // //{
            // //    s2 = int.Parse(reader1[0].ToString());
            // //}
            // con.Close();
            // con.Open();

            // string q = "insert into GroupStudent values('" + value1 + "','" + gender + "' , '" + int.Parse(textBox1.Text.ToString()) + "' )";
            // SqlCommand cmd1 = new SqlCommand(q, con);
            // int z = cmd1.ExecuteNonQuery();
            // if (MessageBox.Show("Do you want to add him as an Advisor", "Add_Advisor", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            // {
            //     MessageBox.Show("Advisor has been assigned to you");
            // }

            // con.Close();
            // textBox1.Text = "";
            // textBox2.Text = "";

            // comboBox1.Text = "";
            //// comboBox2.Text = "";
            // disp_data();





            //con.Open();




            //string gender = comboBox1.SelectedItem.ToString();

            //string gdv = "select Id FROM Lookup WHERE Category = 'Status' AND value ='" + gender + "'";
            //SqlCommand gdInt = new SqlCommand(gdv, con);
            //int s = 0;
            //SqlDataReader reader = gdInt.ExecuteReader();

            //while (reader.Read())
            //{
            //    s = int.Parse(reader[0].ToString());
            //}
            //con.Close();
            //con.Open();



            ////string per = "INSERT into Person(FirstName , LastName , Contact , Email , DateOfBirth , Gender) values ('" + textBox1.Text + "' , '" + textBox2.Text + "' , '" + textBox3.Text + "' , '" + textBox4.Text + "' , '" + DateTime.Parse(textBox5.Text) + "' , '" + s + "')";
            //string per = "INSERT into [Group](Created_On) values ('" + textBox2.Text + "' )";

            //SqlCommand pesi = new SqlCommand(per, con);
            //int a = pesi.ExecuteNonQuery();
            //int value1 = 0;
            //string query = "Select Id from [Group] where (Id = SCOPE_IDENTITY())";
            //SqlCommand cmd = new SqlCommand(query, con);
            //var s1 = cmd.ExecuteScalar().ToString();
            //value1 = int.Parse(s1);
            ////string designation = comboBox2.Text.ToString();
            ////string desi = "select Id FROM Lookup WHERE Category = 'DESIGNATION' AND Value ='" + designation + "'";
            ////SqlCommand d = new SqlCommand(desi, con);
            ////int s2 = 0;
            ////SqlDataReader reader1 = d.ExecuteReader();

            ////while (reader1.Read())
            ////{
            ////    s2 = int.Parse(reader1[0].ToString());
            ////}
            //con.Close();
            //con.Open();
            ////(textBox1.Text.ToString())
            //string q = "insert into GroupStudent values('" + value1 + "','" + gender + "' , '" + int.Parse(textBox1.Text.ToString()) + "' )";
            //SqlCommand cmd1 = new SqlCommand(q, con);
            //int z = cmd1.ExecuteNonQuery();

            //int value2 = 0;
            //string query2 = "Select Id from [Group] where (Id = SCOPE_IDENTITY())";
            //SqlCommand cmd2 = new SqlCommand(query2, con);
            //var s2 = cmd.ExecuteScalar().ToString();
            //value2 = int.Parse(s2);
            //if (MessageBox.Show("Do you want to add him as an Advisor", "Add_Advisor", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            //{
            //    MessageBox.Show("Advisor has been assigned to you");
            //}

            //con.Close();

            //textBox2.Text = "";

            //comboBox1.Text = "";

            //disp_data();


            con.Open();

            //con.Open();




            string status = comboBox1.SelectedItem.ToString();

            string gdv = "select Id FROM Lookup WHERE Category = 'Status' AND value ='" + status + "'";
            SqlCommand gdInt = new SqlCommand(gdv, con);
            int s = 0;
            SqlDataReader reader = gdInt.ExecuteReader();

            while (reader.Read())
            {
                s = int.Parse(reader[0].ToString());
            }
          //  con.Close();

            string gender = comboBox1.SelectedItem.ToString();
            string g = comboBox2.SelectedItem.ToString();
            DateTime dt = DateTime.Now;

            string ps = "INSERT into GroupStudent(GroupId, EvaluationId ,status, EvaluationDate ) values ('" + gender + "' , '" + g + "' , '" + s+ "','" + dt + "')";

            SqlCommand persi = new SqlCommand(ps, con);
            int a = persi.ExecuteNonQuery();

            //SqlCommand cmd = con.CreateCommand();
            //cmd.CommandType = CommandType.Text;

            //cmd.CommandText = "insert into Evaluation values('" + gender + "','" + g + "','" + textBox1.Text + "','" + dt+ "')";// + "insert into Student values('" + textBox7.Text + "')";
            //cmd.ExecuteNonQuery();
            con.Close();
        //    textBox1.Text = "";
         //   textBox2.Text = "";
            comboBox1.Text = "";
            comboBox2.Text = "";

            //   textBox7.Text = "";
            //disp_data();
            if (MessageBox.Show("Do you really want to add this Evaluation", "Insert", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                MessageBox.Show("Record has been inserted successfully");
            }

        }

        public void disp_data()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT [Group].Id as [Group Id],Student.Id as [Student Id],[Group].Created_On, GroupStudent.Status, GroupStudent.AssignmentDate FROM ([Group] JOIN Groupstudent ON [Group].Id = GroupStudent.GroupId) JOIN Person ON GroupStudent.StudentId = Person.Id";

            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void Displaybutton_Click(object sender, EventArgs e)
        {
            disp_data();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
