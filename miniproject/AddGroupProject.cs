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
    public partial class AddGroupProject : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-R6RA1PL\\TOOBAASIF;Initial Catalog=ProjectA;Persist Security Info=True;User ID=sa;Password=1212");

        public AddGroupProject()
        {
            InitializeComponent();
        }

        private void AddGroupProject_Load(object sender, EventArgs e)
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
            cmd.CommandText = "SELECT [Group].Id as [Group Id],Project.Id as [Project Id], GroupProject.AssignmentDate FROM ([Group] JOIN GroupProject ON [Group].Id = GroupProject.GroupId) JOIN Project ON GroupProject.ProjectId = Project.Id";

            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void AssignmentDatelabel_Click(object sender, EventArgs e)
        {

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
            SqlDataAdapter a2 = new SqlDataAdapter("select * from Project", con);
            DataTable dt1 = new DataTable();
            a2.Fill(dt1);
            for (int j = 0; j < dt1.Rows.Count; j++)
            {
                comboBox2.Items.Add(dt1.Rows[j]["Id"]);
            }
            con.Close();
        }

        private void Savebutton_Click(object sender, EventArgs e)
        {
            con.Open();



            string gender = comboBox1.SelectedItem.ToString();
            string g = comboBox2.SelectedItem.ToString();
            DateTime dt = DateTime.Now;

            string ps = "INSERT into GroupProject(GroupId, ProjectId , AssignmentDate ) values ('" + gender + "' , '" + g + "' , '" + dt + "')";

            SqlCommand persi = new SqlCommand(ps, con);
            int a = persi.ExecuteNonQuery();

            //SqlCommand cmd = con.CreateCommand();
            //cmd.CommandType = CommandType.Text;

            //cmd.CommandText = "insert into Evaluation values('" + gender + "','" + g + "','" + textBox1.Text + "','" + dt+ "')";// + "insert into Student values('" + textBox7.Text + "')";
            //cmd.ExecuteNonQuery();
            con.Close();
            
            comboBox1.Text = "";
            comboBox2.Text = "";

            //   textBox7.Text = "";
            //disp_data();
            if (MessageBox.Show("Do you really want to add this Evaluation", "Insert", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                MessageBox.Show("Record has been inserted successfully");
            }
        }
    }
}
