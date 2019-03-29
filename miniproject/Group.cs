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
    public partial class Group : MaterialSkin.Controls.MaterialForm
    {
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
            AddGroupStudent f5 = new AddGroupStudent();
            this.Hide();
            f5.Show();
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
