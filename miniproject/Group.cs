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
    public partial class Group : MaterialSkin.Controls.MaterialForm
    {

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-R6RA1PL\\TOOBAASIF;Initial Catalog=ProjectA;Persist Security Info=True;User ID=sa;Password=1212");

        public Group()
        {
            InitializeComponent();
        }

        private void Group_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f3 = new Form1();
            this.Hide();
            f3.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 f4 = new Form1();
            this.Hide();
            f4.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            DateTime dt = DateTime.Now;
            cmd.CommandText = "insert into [Group] values('" + dt + "')";// + "insert into Student values('" + textBox7.Text + "')";
            cmd.ExecuteNonQuery();
            con.Close();
          //  textBox1.Text = "";

            //  disp_data();
            if (MessageBox.Show("Do you really want to add this Group", "Insert", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                MessageBox.Show("Record has been inserted successfully");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AddGroupProject f6 = new AddGroupProject();
            this.Hide();
            f6.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Management f7 = new Management();
            this.Hide();
            f7.Show();
        }
    }
}
