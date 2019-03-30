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
    public partial class AddGroupEvaluation : MaterialSkin.Controls.MaterialForm
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-R6RA1PL\\TOOBAASIF;Initial Catalog=ProjectA;Persist Security Info=True;User ID=sa;Password=1212");

        public AddGroupEvaluation()
        {
            InitializeComponent();
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

        public void disp_data()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT [Group].Id as [Group Id],Evaluation.Id as [Evaluation Id], GroupEvaluation.ObtainedMarks, GroupEvaluation.EvaluationDate FROM ([Group] JOIN GroupEvaluation ON [Group].Id = GroupEvaluation.GroupId) JOIN Evaluation ON GroupEvaluation.EvaluationId = Evaluation.Id";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void AddGroupEvaluation_Load(object sender, EventArgs e)
        {

        }

        private void Savebutton_Click(object sender, EventArgs e)
        {
            try
            {

                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                if (textBox1.Text == "")


                {
                    MessageBox.Show("Please fill in all fields", "Error", MessageBoxButtons.OK);
                    textBox1.Focus(); // set focus to lastNameTextBox
                    return;
                } // end if

                if (!Regex.Match(textBox1.Text, @"[\d]").Success)
                {
                    // address was incorrect
                    MessageBox.Show("Invalid salary", "Message", MessageBoxButtons.OK);
                    textBox1.Focus();
                    return;
                } // end if


                string gender = comboBox1.SelectedItem.ToString();
                string g = comboBox2.SelectedItem.ToString();
                DateTime dt = DateTime.Now;

                string ps = "INSERT into GroupEvaluation(GroupId, EvaluationId ,ObtainedMarks, EvaluationDate ) values ('" + gender + "' , '" + g + "' , '" + textBox1.Text + "','" + dt + "')";

                SqlCommand persi = new SqlCommand(ps, con);
                int a = persi.ExecuteNonQuery();

                //SqlCommand cmd = con.CreateCommand();
                //cmd.CommandType = CommandType.Text;

                //cmd.CommandText = "insert into Evaluation values('" + gender + "','" + g + "','" + textBox1.Text + "','" + dt+ "')";// + "insert into Student values('" + textBox7.Text + "')";
                //cmd.ExecuteNonQuery();
                con.Close();
                textBox1.Text = "";

                comboBox1.Text = "";
                comboBox2.Text = "";

                //   textBox7.Text = "";
                //disp_data();
                if (MessageBox.Show("Do you really want to add this Evaluation", "Insert", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    MessageBox.Show("Record has been inserted successfully");
                }
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter a1 = new SqlDataAdapter("select * from [Group]", con);

            DataTable dt = new DataTable();
            a1.Fill(dt);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                comboBox1.Items.Add(dt.Rows[i]["Id"]);
            }
            con.Close();
            con.Open();
            SqlDataAdapter a2 = new SqlDataAdapter("select * from Evaluation", con);
            DataTable dt1 = new DataTable();
            a2.Fill(dt1);
            for (int j = 0; j < dt1.Rows.Count; j++)
            {
                comboBox2.Items.Add(dt1.Rows[j]["Id"]);
            }
            con.Close();
        }

        private void Updatebutton_Click(object sender, EventArgs e)
        {

            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }



                string gender = comboBox1.SelectedItem.ToString();
                string g = comboBox2.SelectedItem.ToString();
                DateTime dt = DateTime.Now;


                //string que1 = string.Format("SELECT Id from P Where Email = '" + textBox4.Text + "'");
                //SqlCommand cmd = new SqlCommand(que1, con);
                //var aa = cmd.ExecuteScalar().ToString();
                //int s1 = int.Parse(aa);
                //// int id =int.Parse( cmd.ExecuteScalar());

                //cmd.ExecuteNonQuery();

                string ps1 = "Update GroupEvaluation set ObtainedMarks ='" + textBox1.Text + "', EvaluationDate ='" + dt + "'  WHERE (GroupId = '" + gender + "'and EvaluationId ='" + g + "')";
                SqlCommand pesi = new SqlCommand(ps1, con);
                int a1 = pesi.ExecuteNonQuery();
                disp_data();
                con.Close();
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

                string gender = comboBox1.SelectedItem.ToString();
                string g = comboBox2.SelectedItem.ToString();


                string display = String.Format("DELETE FROM GroupEvaluation WHERE  (GroupId = '" + gender + "'and EvaluationId = '" + g + "')");
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
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f3 = new Form1();
            this.Hide();
            f3.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Group f4 = new Group();
            this.Hide();
            f4.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
