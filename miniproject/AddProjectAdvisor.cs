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
    public partial class AddProjectAdvisor : Form
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
            disp_data();
        }

        public void disp_data()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            //cmd.CommandText = "select Advisor.Id,Project.Id,,ProjectAdvisor.AdvisorRole,ProjectAdvisor.AssignmentDate From (ProjectAdvisor JOIN Advisor ON ProjectAdvisor.AdvisorId = Advisor.Id )JOIN Project ON ProjectAdvisor.ProjectId = Project.Id";
            cmd.CommandText = "SELECT Advisor.Id as [Advisor Id] ,Project.Id as [Project Id], ProjectAdvisor.AdvisorRole, ProjectAdvisor.AssignmentDate FROM (ProjectAdvisor JOIN Advisor ON ProjectAdvisor.AdvisorId = Advisor.Id) JOIN Project ON ProjectAdvisor.ProjectId = Project.Id";

            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void Savebutton_Click(object sender, EventArgs e)
        {
            con.Open();




            string advisorrole = comboBox1.SelectedItem.ToString();

            string advisorvalue = "select Id FROM Lookup WHERE Category = 'Gender' AND value ='" + advisorrole + "'";
            SqlCommand genderInt = new SqlCommand(advisorvalue, con);
            int s = 0;
            SqlDataReader reader = genderInt.ExecuteReader();

            while (reader.Read())
            {
                s = int.Parse(reader[0].ToString());
            }


            con.Close();
            con.Open();

            string ps = "INSERT into ProjectAdvisor(AdvisorRole, AssignmentDate) values ('" + s + "' , '" + textBox1.Text + "')";

            SqlCommand persi = new SqlCommand(ps, con);
            int a = persi.ExecuteNonQuery();

            int s1 = 0;
            //----------------------------------------------------------------------------------------
            string que = "Select Id from Advidor where (Id = SCOPE_IDENTITY())";
            SqlCommand cmd = new SqlCommand(que, con);
            var v = cmd.ExecuteScalar().ToString();
            s1 = int.Parse(v);
            //---------------------------------------------------------------------------------------------
            //string q = "insert into Student values('" + s1 + "','" + textBox7.Text.ToString() + "')";
            //SqlCommand cmd1 = new SqlCommand(q, con);
            //int k = cmd1.ExecuteNonQuery();
            int s2 = 0;
            //----------------------------------------------------------------------------------------
            string quex = "Select Id from Project where (Id = SCOPE_IDENTITY())";
            SqlCommand cmd1 = new SqlCommand(quex, con);
            var vs = cmd.ExecuteScalar().ToString();
            s2 = int.Parse(vs);
            //---------------------------------------------------------------------------------------------

            con.Close();
            textBox1.Text = "";
           
            comboBox1.Text = "";

            disp_data();
            //MessageBox.Show("Data Inserted");

            if (MessageBox.Show("Do you really want to register this student", "Register", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                MessageBox.Show("Record has been inserted successfully");
            }
        }

        private void AdvisorRolelabel_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
    