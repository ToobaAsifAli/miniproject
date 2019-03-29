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
    public partial class Evaluation : MaterialSkin.Controls.MaterialForm
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-R6RA1PL\\TOOBAASIF;Initial Catalog=ProjectA;Persist Security Info=True;User ID=sa;Password=1212");

        public Evaluation()
        {
            InitializeComponent();
        }

        private void Insertlabel_Click(object sender, EventArgs e)
        {
            //con.Open();
            //SqlCommand cmd = con.CreateCommand();
            //cmd.CommandType = CommandType.Text;
            //cmd.CommandText = "insert into Evaluation values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "')";// + "insert into Student values('" + textBox7.Text + "')";
            //cmd.ExecuteNonQuery();
            //con.Close();
            //textBox1.Text = "";
            //textBox2.Text = "";
            //textBox3.Text = "";

            ////   textBox7.Text = "";
            ////disp_data();
            //MessageBox.Show("Record inserted successfully");
        }


        public void disp_data()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Evaluation";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void Searchlabel_Click(object sender, EventArgs e)
        {
            //con.Open();
            //SqlCommand cmd = con.CreateCommand();
            //cmd.CommandType = CommandType.Text;
            //cmd.CommandText = "select * from Evalution where Name ='" + textBox1.Text + "'";
            //textBox1.Text = "";
            //cmd.ExecuteNonQuery();
            //DataTable dt = new DataTable();
            //SqlDataAdapter da = new SqlDataAdapter(cmd);
            //da.Fill(dt);
            //dataGridView1.DataSource = dt;

            //con.Close();
            //disp_data();
        }

        private void Deletelabel_Click(object sender, EventArgs e)
        {
            //con.Open();
            //SqlCommand cmd = con.CreateCommand();
            //cmd.CommandType = CommandType.Text;
            //// cmd.CommandText = "delete from Person where values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "')";
            //cmd.CommandText = "delete from Evaluation where Name ='" + textBox1.Text + "'";

            //cmd.ExecuteNonQuery();
            //con.Close();

            //disp_data();


            //dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
            MessageBox.Show("Record deleted successfully");
        }

        private void Display_Click(object sender, EventArgs e)
        {
           // disp_data();
        }

        private void Updatelabel_Click(object sender, EventArgs e)
        {  

            //con.Open(); 
            //SqlCommand cmd = con.CreateCommand();
            //cmd.CommandType = CommandType.Text;


            //cmd.CommandText = "update Evaluation set TotalMarks ='" + textBox2.Text + "' where Name = '" + textBox1.Text + "'";
            //cmd.ExecuteNonQuery();
            //cmd.CommandText = "update Evaluation set TotalWeightage ='" + textBox3.Text + "' where Name = '" + textBox1.Text + "'";
     
            //cmd.ExecuteNonQuery();
            //con.Close();

            //disp_data();


            ////dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
            //MessageBox.Show("Record updated successfully");
        }

        private void Evaluation_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f2 = new Form1();
            this.Hide();
            f2.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EvaluationManagement f3 = new EvaluationManagement();
            this.Hide();
            f3.Show();
        }

        private void Savebutton_Click(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            if (textBox1.Text == ""|| textBox2.Text == ""|| textBox3.Text == "")


            {
                MessageBox.Show("Please fill in all fields", "Error", MessageBoxButtons.OK);
                textBox1.Focus(); // set focus to lastNameTextBox
                return;
            } // end if


            if (!Regex.Match(textBox1.Text, "^[A-Z][a-zA-Z]*$").Success)
            {
                // first name was incorrect
                MessageBox.Show("Invalid first name", "Message", MessageBoxButtons.OK);
                textBox1.Focus();
                return;
            } // end if
            if (!Regex.Match(textBox2.Text, @"[\d]").Success)
            {
                // address was incorrect
                MessageBox.Show("Invalid salary", "Message", MessageBoxButtons.OK);
                textBox1.Focus();
                return;
            } // end if

            if (!Regex.Match(textBox3.Text, @"[\d]").Success)
            {
                // address was incorrect
                MessageBox.Show("Invalid salary", "Message", MessageBoxButtons.OK);
                textBox1.Focus();
                return;
            } // end if

            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into Evaluation values('" + textBox1.Text+ "','" + textBox2.Text + "','" + textBox3.Text + "')";// + "insert into Student values('" + textBox7.Text + "')";
            cmd.ExecuteNonQuery();
            con.Close();
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";

            //   textBox7.Text = "";
            //disp_data();
            if (MessageBox.Show("Do you really want to add this Evaluation", "Insert", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                MessageBox.Show("Record has been inserted successfully");
            }
        }

        private void Displaybutton_Click(object sender, EventArgs e)
        {
            disp_data();
        }

        private void Deletebutton_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            // cmd.CommandText = "delete from Person where values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "')";
            cmd.CommandText = "delete from Evaluation where Name ='" + textBox1.Text + "'";

            cmd.ExecuteNonQuery();
            con.Close();

            disp_data();


            //dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
            if (MessageBox.Show("Do you really want to delete this record", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                MessageBox.Show("Record has been deleted successfully");
            }
        }

        private void Updatebutton_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;


            cmd.CommandText = "update Evaluation set TotalMarks ='" + textBox2.Text + "' where Name = '" + textBox1.Text + "'";
            cmd.ExecuteNonQuery();
            cmd.CommandText = "update Evaluation set TotalWeightage ='" + textBox3.Text + "' where Name = '" + textBox1.Text + "'";

            cmd.ExecuteNonQuery();
            con.Close();

            disp_data();


            //dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
            if (MessageBox.Show("Do you really want to Update this record", "Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                MessageBox.Show("Record has been updated successfully");
            }
        }

        private void Searchbutton_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Evalution where Name ='" + textBox1.Text + "'";
            textBox1.Text = "";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            con.Close();
            disp_data();
        }
    }
}
