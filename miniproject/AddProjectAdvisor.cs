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
    public partial class AddProjectAdvisor : MaterialSkin.Controls.MaterialForm
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-R6RA1PL\\TOOBAASIF;Initial Catalog=ProjectA;Persist Security Info=True;User ID=sa;Password=1212");

        public AddProjectAdvisor()
        {
            InitializeComponent();
        }

        private void AddProjectAdvisor_Load(object sender, EventArgs e)
        {

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
            //cmd.CommandText = "select Advisor.Id,Project.Id,,ProjectAdvisor.AdvisorRole,ProjectAdvisor.AssignmentDate From (ProjectAdvisor JOIN Advisor ON ProjectAdvisor.AdvisorId = Advisor.Id )JOIN Project ON ProjectAdvisor.ProjectId = Project.Id";
            //  cmd.CommandText = "SELECT Advisor.Id as [Advisor Id] ,Project.Id as [Project Id], ProjectAdvisor.AdvisorRole, ProjectAdvisor.AssignmentDate FROM (ProjectAdvisor JOIN Advisor ON ProjectAdvisor.AdvisorId = Advisor.Id) JOIN Project ON ProjectAdvisor.ProjectId = Project.Id";
            cmd.CommandText = "SELECT [Advisor].Id as [Advisor Id],Project.Id as [Project Id], ProjectAdvisor.AdvisorRole, ProjectAdvisor.AssignmentDate FROM ([Advisor] JOIN ProjectAdvisor ON [Advisor].Id = ProjectAdvisor.AdvisorId) JOIN Project ON ProjectAdvisor.ProjectId = Project.Id";

            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void Savebutton_Click(object sender, EventArgs e)
        {
            //con.Open();




            //string advisorrole = comboBox1.SelectedItem.ToString();

            //string advisorvalue = "select Id FROM Lookup WHERE Category = 'Gender' AND value ='" + advisorrole + "'";
            //SqlCommand genderInt = new SqlCommand(advisorvalue, con);
            //int s = 0;
            //SqlDataReader reader = genderInt.ExecuteReader();

            //while (reader.Read())
            //{
            //    s = int.Parse(reader[0].ToString());
            //}


            //con.Close();
            //con.Open();

            //string ps = "INSERT into ProjectAdvisor(AdvisorRole, AssignmentDate) values ('" + s + "' , '" + textBox1.Text + "')";

            //SqlCommand persi = new SqlCommand(ps, con);
            //int a = persi.ExecuteNonQuery();

            //int s1 = 0;
            ////----------------------------------------------------------------------------------------
            //string que = "Select Id from Advidor where (Id = SCOPE_IDENTITY())";
            //SqlCommand cmd = new SqlCommand(que, con);
            //var v = cmd.ExecuteScalar().ToString();
            //s1 = int.Parse(v);
            ////---------------------------------------------------------------------------------------------
            ////string q = "insert into Student values('" + s1 + "','" + textBox7.Text.ToString() + "')";
            ////SqlCommand cmd1 = new SqlCommand(q, con);
            ////int k = cmd1.ExecuteNonQuery();
            //int s2 = 0;
            ////----------------------------------------------------------------------------------------
            //string quex = "Select Id from Project where (Id = SCOPE_IDENTITY())";
            //SqlCommand cmd1 = new SqlCommand(quex, con);
            //var vs = cmd.ExecuteScalar().ToString();
            //s2 = int.Parse(vs);
            ////---------------------------------------------------------------------------------------------

            //con.Close();
            //textBox1.Text = "";

            //comboBox1.Text = "";

            //disp_data();
            ////MessageBox.Show("Data Inserted");

            //if (MessageBox.Show("Do you really want to register this student", "Register", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            //{

            //    MessageBox.Show("Record has been inserted successfully");
            //}

            try
            {

                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }


                string status = comboBox3.SelectedItem.ToString();

                string gdv = "select Id FROM Lookup WHERE Category = 'ADVISOR_ROLE' AND value ='" + status + "'";
                SqlCommand gdInt = new SqlCommand(gdv, con);
                int s = 0;
                SqlDataReader reader = gdInt.ExecuteReader();

                while (reader.Read())
                {
                    s = int.Parse(reader[0].ToString());
                }
                con.Close();
                con.Open();
                string gender = comboBox1.SelectedItem.ToString();
                string g = comboBox2.SelectedItem.ToString();
                DateTime dt = DateTime.Now;

                string ps = "INSERT into ProjectAdvisor(AdvisorId, ProjectId ,AdvisorRole, AssignmentDate ) values ('" + gender + "' , '" + g + "' , '" + s + "','" + dt + "')";

                SqlCommand persi = new SqlCommand(ps, con);
                int a = persi.ExecuteNonQuery();

                //SqlCommand cmd = con.CreateCommand();
                //cmd.CommandType = CommandType.Text;

                //cmd.CommandText = "insert into Evaluation values('" + gender + "','" + g + "','" + textBox1.Text + "','" + dt+ "')";// + "insert into Student values('" + textBox7.Text + "')";
                //cmd.ExecuteNonQuery();
               

                //   textBox7.Text = "";
                //disp_data();
                if (MessageBox.Show("Do you really want to add this Evaluation", "Insert", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    MessageBox.Show("Record has been inserted successfully");
                }
                con.Close();
                //    textBox1.Text = "";
                //   textBox2.Text = "";
                comboBox1.Text = "";
                comboBox2.Text = "";
                comboBox3.Text = "";
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message);
            }
        }

        private void AdvisorRolelabel_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter a1 = new SqlDataAdapter("select * from [Advisor]", con);

            DataTable dt = new DataTable();
            a1.Fill(dt);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                comboBox1.Items.Add(dt.Rows[i]["Id"]);
            }
            con.Close();
            con.Open();
            SqlDataAdapter a2 = new SqlDataAdapter("select * from Project", con);
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
                string gdv = "select Id FROM Lookup WHERE Category = 'ADVISOR_ROLE' AND value ='" + comboBox3.Text.ToString() + "'";
                SqlCommand gdInt = new SqlCommand(gdv, con);
                int s = 0;
                SqlDataReader reader = gdInt.ExecuteReader();

                while (reader.Read())
                {
                    s = int.Parse(reader[0].ToString());
                }
                reader.Close();

                string gender = comboBox1.SelectedItem.ToString();
                string g = comboBox2.SelectedItem.ToString();
                DateTime dt = DateTime.Now;


                //string que1 = string.Format("SELECT Id from P Where Email = '" + textBox4.Text + "'");
                //SqlCommand cmd = new SqlCommand(que1, con);
                //var aa = cmd.ExecuteScalar().ToString();
                //int s1 = int.Parse(aa);
                //// int id =int.Parse( cmd.ExecuteScalar());

                //cmd.ExecuteNonQuery();

                string ps1 = "Update ProjectAdvisor set  AssignmentDate ='" + dt + "', AdvisorRole ='" + s + "'  WHERE (AdvisorId = '" + gender + "'and ProjectId ='" + g + "')";
                SqlCommand pesi = new SqlCommand(ps1, con);
                int a1 = pesi.ExecuteNonQuery();

                if (MessageBox.Show("Do you really want to Update this record", "Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    MessageBox.Show("Record has been updated successfully");
                }
               
                //    textBox1.Text = "";
                //   textBox2.Text = "";
                comboBox1.Text = "";
                comboBox2.Text = "";
                comboBox3.Text = "";
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


                string display = String.Format("DELETE FROM ProjectAdvisor WHERE  (AdvisorId = '" + gender + "'and ProjectId = '" + g + "')");
                SqlCommand cmd = new SqlCommand(display, con);
                cmd.ExecuteNonQuery();

                //cmd.CommandText = string.Format("DELETE FROM Person WHERE Email = '{0}'", email);
                //cmd.ExecuteNonQuery();
                
                if (MessageBox.Show("Do you really want to delete this record", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    MessageBox.Show("Record has been deleted successfully");

                }
                comboBox1.Text = "";
                comboBox2.Text = "";
                comboBox3.Text = "";
                con.Close();
                disp_data();
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
            ProjectAdvisor f4 = new ProjectAdvisor();
            this.Hide();
            f4.Show();
        }
    }
}
    