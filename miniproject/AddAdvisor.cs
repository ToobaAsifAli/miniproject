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
    public partial class AddAdvisor : Form
    {


        SqlConnection con = new SqlConnection("Data Source=DESKTOP-R6RA1PL\\TOOBAASIF;Initial Catalog=ProjectA;Persist Security Info=True;User ID=sa;Password=1212");

        public AddAdvisor()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        public void disp_data()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Advisor";
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

        private void Insertbutton_Click(object sender, EventArgs e)
        {
            //con.Open();




            //string congo = comboBox1.SelectedItem.ToString();

            //string genderValue = "select Id FROM Lookup WHERE Category = 'Designation' AND value ='" + congo + "'";
            //SqlCommand genderInt = new SqlCommand(genderValue, con);
            //int value = 0;
            //SqlDataReader reader = genderInt.ExecuteReader();
            //// genderInt.ExecuteNonQuery();
            //while (reader.Read())
            //{
            //    value = int.Parse(reader[0].ToString());
            //}

            ////int gender = Convert.ToInt32(genderInt.ExecuteScalar ());

            //string per = "INSERT into Person(FirstName , LastName , Contact , Email , DateOfBirth , Gender) values ('" + textBox2.Text + "' , '" + textBox3.Text + "' , '" + textBox4.Text + "' , '" + textBox5.Text + "' , '" + textBox6.Text + "' , '" + value + "')";

            //SqlCommand persi = new SqlCommand(per, con);
            //int i = persi.ExecuteNonQuery();
            //int value1 = 0;
            //string query = "Select Id from Person where (Id = SCOPE_IDENTITY())";
            //SqlCommand cmd = new SqlCommand(query, con);
            //var val = cmd.ExecuteScalar().ToString();
            //value1 = int.Parse(val);
            //string q = "insert into Advisor values('" + value1 + "','" + textBox1.Text.ToString() + "')";
            //SqlCommand cmd1 = new SqlCommand(q, con);
            //int j = cmd1.ExecuteNonQuery();
            ////  string S_ID = string.Format("Select Id FROM Person where Email ='{0}'", email);
            //// SqlCommand StuID = new SqlCommand(S_ID, conn);
            //// int Id = Convert.ToInt32(StuID.ExecuteScalar());
            //// string st = "Insert into Student values( '" + Id + "' ,'" + textBox1.Text + "')";
            //// SqlCommand std = new SqlCommand(st, conn);
            //// int ii = std.ExecuteNonQuery();


            //con.Close();
            //disp_data();
            //MessageBox.Show("Data Inserted");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Savebutton_Click(object sender, EventArgs e)
        {
        //    con.Open();




        //    string congo = comboBox1.SelectedItem.ToString();
        //    string desi = comboBox2.SelectedItem.ToString();

        //    string genderValue = "select Id FROM Lookup WHERE Category = 'Gender' AND value ='" + congo + "'";
        //    string desiValue = "select Designation FROM Lookup WHERE Category = 'Designation' AND value ='" + desi + "'";
        //    SqlCommand genderInt = new SqlCommand(genderValue, con);
        //    int value = 0;
        //    SqlDataReader reader = genderInt.ExecuteReader();
        //    // genderInt.ExecuteNonQuery();
        //    while (reader.Read())
        //    {
        //        value = int.Parse(reader[0].ToString());
        //    }

        //     SqlCommand gInt = new SqlCommand(desiValue, con);
        //    int value = 0;
        //    SqlDataReader reader1 = genderInt.ExecuteReader();
        //    // genderInt.ExecuteNonQuery();
        //    while (reader1.Read())
        //    {
        //        value = int.Parse(reader[0].ToString());
        //    }

        //    //int gender = Convert.ToInt32(genderInt.ExecuteScalar ());
        //    con.Close();
        //    con.Open();

        //    string per = "INSERT into Person(FirstName , LastName , Contact , Email , DateOfBirth , Gender) values ('" + textBox1.Text + "' , '" + textBox2.Text + "' , '" + textBox3.Text + "' , '" + textBox4.Text + "' , '" + textBox5.Text + "' , '" + value + "')";

        //    SqlCommand persi = new SqlCommand(per, con);
        //    int i = persi.ExecuteNonQuery();

        //    int value1 = 0;
        //    //----------------------------------------------------------------------------------------
        //    string query = "Select Id from Person where (Id = SCOPE_IDENTITY())";
        //    SqlCommand cmd = new SqlCommand(query, con);
        //    var val = cmd.ExecuteScalar().ToString();
        //    value1 = int.Parse(val);
        //    //---------------------------------------------------------------------------------------------
        //    string q = "insert into Student values('" + value1 + "','" + textBox7.Text.ToString() + "')";
        //    SqlCommand cmd1 = new SqlCommand(q, con);
        //    int j = cmd1.ExecuteNonQuery();
        //    //  string S_ID = string.Format("Select Id FROM Person where Email ='{0}'", email);
        //    // SqlCommand StuID = new SqlCommand(S_ID, conn);
        //    // int Id = Convert.ToInt32(StuID.ExecuteScalar());
        //    // string st = "Insert into Student values( '" + Id + "' ,'" + textBox1.Text + "')";
        //    // SqlCommand std = new SqlCommand(st, conn);
        //    // int ii = std.ExecuteNonQuery();


        //    con.Close();
        //    disp_data();
        //    MessageBox.Show("Data Inserted");
        }
    }
}
