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
    public partial class AdvisorManagement : MaterialSkin.Controls.MaterialForm
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-R6RA1PL\\TOOBAASIF;Initial Catalog=ProjectA;Persist Security Info=True;User ID=sa;Password=1212");

        public AdvisorManagement()
        {
            InitializeComponent();
        }

        private void AddAdvisorbutton_Click(object sender, EventArgs e)
        {
            AddAdvisor f2 = new AddAdvisor();
            this.Hide();
            f2.Show();
        }

        private void AdvisorManagement_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddAdvisor f1 = new AddAdvisor();
            this.Hide();
            f1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f2 = new Form1();
            this.Hide();
            f2.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f3 = new Form1();
            this.Hide();
            f3.Show();
        }
    }
}
