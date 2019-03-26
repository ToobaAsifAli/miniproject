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

        }

        public void disp_data()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT [Group].Id as [Group Id],Student.Id as [Student Id],[Group].Created_On, GroupStudent.Status, GroupStudent.AssignmentDate FROM ([Group] JOIN Groupstudent ON [Group].Id = GroupStudent.GroupId) JOIN Student ON GroupStudent.StudentId = student.Id";

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
    }
}
