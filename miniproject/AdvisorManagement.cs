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
    public partial class AdvisorManagement : Form
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
    }
}
