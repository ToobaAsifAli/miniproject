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
    public partial class AddProject : MaterialSkin.Controls.MaterialForm
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-R6RA1PL\\TOOBAASIF;Initial Catalog=ProjectA;Persist Security Info=True;User ID=sa;Password=1212");

        public AddProject()
        {
            InitializeComponent();
        }

        private void Insertlabel_Click(object sender, EventArgs e)
        {
            //con.Open();
            //SqlCommand cmd = con.CreateCommand();
            //cmd.CommandType = CommandType.Text;
            //cmd.CommandText = "insert into Project values('" + textBox1.Text + "','" + textBox2.Text + "')";// + "insert into Student values('" + textBox7.Text + "')";
            //cmd.ExecuteNonQuery();
            //con.Close();
            //textBox1.Text = "";
            //textBox2.Text = "";
           

            ////   textBox7.Text = "";
            ////disp_data();
            //MessageBox.Show("Record inserted successfully");
        }

        public void disp_data()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Project";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void Updatelabel_Click(object sender, EventArgs e)
        {
            //con.Open();
            //SqlCommand cmd = con.CreateCommand();
            //cmd.CommandType = CommandType.Text;


            //cmd.CommandText = "update Project set TotalMarks ='" + textBox2.Text + "' where Description = '" + textBox1.Text + "'";
            //cmd.ExecuteNonQuery();
            ////cmd.CommandText = "update Evaluation set TotalWeightage ='" + textBox3.Text + "' where Name = '" + textBox1.Text + "'";

            ////cmd.ExecuteNonQuery();
            //con.Close();

            //disp_data();


            ////dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
            //MessageBox.Show("Record updated successfully");
        }

        private void Deletelabel_Click(object sender, EventArgs e)
        {

            //con.Open();
            //SqlCommand cmd = con.CreateCommand();
            //cmd.CommandType = CommandType.Text;
            //// cmd.CommandText = "delete from Person where values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "')";
            //cmd.CommandText = "delete from Project where description ='" + textBox1.Text + "'";

            //cmd.ExecuteNonQuery();
            //con.Close();

            //disp_data();


            ////dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
            //MessageBox.Show("Record deleted successfully");
        }

        private void Searchlabel_Click(object sender, EventArgs e)
        {
            //con.Open();
            //SqlCommand cmd = con.CreateCommand();
            //cmd.CommandType = CommandType.Text;
            //cmd.CommandText = "select * from Project where Description ='" + textBox1.Text + "'";
            //textBox1.Text = "";
            //cmd.ExecuteNonQuery();
            //DataTable dt = new DataTable();
            //SqlDataAdapter da = new SqlDataAdapter(cmd);
            //da.Fill(dt);
            //dataGridView1.DataSource = dt;

            //con.Close();
            //disp_data();
        }

        private void Display_Click(object sender, EventArgs e)
        {
            //disp_data();
        }

        private void AddProject_Load(object sender, EventArgs e)
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
            ProjectMagement f3 = new ProjectMagement();
            this.Hide();
            f3.Show();
        }

        private void Savebutton_Click(object sender, EventArgs e)
        {
            try
            {

                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                if (textBox2.Text == "" || richTextBox1.Text == "")


                {
                    MessageBox.Show("Please fill in all fields", "Error", MessageBoxButtons.OK);
                    textBox2.Focus(); // set focus to lastNameTextBox
                    return;
                } // end if


                if (!Regex.Match(textBox2.Text, "^[A-Z][a-zA-Z]*$").Success)
                {
                    // first name was incorrect
                    MessageBox.Show("Invalid first title", "Message", MessageBoxButtons.OK);
                    textBox2.Focus();
                    return;
                } // end if

                //if (!Regex.Match(richTextBox1.Text, "^[A-Z][a-zA-Z]*$").Success)
                //{
                //    // first name was incorrect
                //    MessageBox.Show("Invalid description", "Message", MessageBoxButtons.OK);
                //    textBox2.Focus();
                //    return;
                //} // end if
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into Project values('" + richTextBox1.Text + "','" + textBox2.Text + "')";// + "insert into Student values('" + textBox7.Text + "')";
                cmd.ExecuteNonQuery();
              
                if (MessageBox.Show("Do you really want to add this Project", "Insert", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    MessageBox.Show("Record has been inserted successfully");
                }
                con.Close();
                richTextBox1.Text = "";
                textBox2.Text = "";


                //   textBox7.Text = "";
                disp_data();

            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message);
            }
        }

        private void Updatebutton_Click(object sender, EventArgs e)
        {
            try
            {

                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;


                cmd.CommandText = "update Project set Description ='" + richTextBox1.Text + "' where Title = '" + textBox2.Text + "'";
                cmd.ExecuteNonQuery();
                //cmd.CommandText = "update Evaluation set TotalWeightage ='" + textBox3.Text + "' where Name = '" + textBox1.Text + "'";

                //cmd.ExecuteNonQuery();
                con.Close();

                disp_data();


                //dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
                if (MessageBox.Show("Do you really want to Update this record", "Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    MessageBox.Show("Record has been updated successfully");
                }
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

        private void Deletebutton_Click(object sender, EventArgs e)
        {
            try
            {

                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                // cmd.CommandText = "delete from Person where values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "')";
                cmd.CommandText = "delete from Project where Title ='" + textBox2.Text + "'";

                cmd.ExecuteNonQuery();
                con.Close();

                disp_data();

                if (MessageBox.Show("Do you really want to delete this record", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    MessageBox.Show("Record has been deleted successfully");
                }
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message);
            }
            //dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);

        }

        private void Searchbutton_Click(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Project where Title ='" + textBox2.Text + "'";
            textBox2.Text = "";
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
