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
    public partial class student : Form
    {

       SqlConnection con = new SqlConnection("Data Source=DESKTOP-R6RA1PL\\TOOBAASIF;Initial Catalog=ProjectA;Persist Security Info=True;User ID=sa;Password=1212");

        public student()
        {
            InitializeComponent();
        }

        private void Savebutton_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into Person values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + comboBox1.Text + "')";// + "insert into Student values('" + textBox7.Text + "')";
            cmd.ExecuteNonQuery();
            con.Close();
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";

            comboBox1.Text = "";
            //   textBox7.Text = "";
            //disp_data();
            MessageBox.Show("Record inserted successfully");



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



        }
        public void disp_data()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Person";
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
            cmd.CommandText = "select * from Person where FirstName ='"+textBox4.Text+"'";
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
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            // cmd.CommandText = "delete from Person where values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "')";
            cmd.CommandText = "delete from Person where FirstName ='"+textBox1.Text+"'";
  
            cmd.ExecuteNonQuery();
            con.Close();

            disp_data();


            //dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
            MessageBox.Show("Record deleted successfully");
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

            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            // cmd.CommandText = "delete from Person where values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "')";
          //  cmd.CommandText = "update Person set name ='" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text +"' where FirstName = '"+textBox1.Text+"'";

            cmd.CommandText = "update Person set LastName ='" + textBox2.Text + "' where FirstName = '" + textBox1.Text + "'";
            cmd.CommandText = "update Person set Contact ='" + textBox3.Text + "' where FirstName = '" + textBox1.Text + "'";
            cmd.CommandText = "update Person set Email ='" + textBox4.Text + "' where FirstName = '" + textBox1.Text + "'";
            cmd.CommandText = "update Person set DateOfBirth ='" + textBox5.Text + "' where FirstName = '" + textBox1.Text + "'";
            cmd.CommandText = "update Person set Gender ='" + comboBox1.Text + "' where FirstName = '" + textBox1.Text + "'";
            







            // cmd.CommandText = "update Person set LastName ='" + textBox2.Text + "'update Person set Gender = '" + textBox6.Text + "'where FirstName = '" + textBox1.Text + "'";


            cmd.ExecuteNonQuery();
            con.Close();

            disp_data();


            //dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
            MessageBox.Show("Record updated successfully");



        }



        private void Displaybutton_Click(object sender, EventArgs e)
        {
            disp_data();
        }
    }
}
