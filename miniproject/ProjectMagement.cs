using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace miniproject
{
    public partial class ProjectMagement : MaterialSkin.Controls.MaterialForm
    {
        public ProjectMagement()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddProject f3 = new AddProject();
            this.Hide();
            f3.Show();
        }

        private void ProjectMagement_Load(object sender, EventArgs e)
        {

        }
    }
}
