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
    public partial class GroupStudent : MaterialSkin.Controls.MaterialForm
    {
        public GroupStudent()
        {
            InitializeComponent();
        }

        private void GroupStudent_Load(object sender, EventArgs e)
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
    }
}
