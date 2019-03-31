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
    public partial class Management :MaterialSkin.Controls.MaterialForm
    {
        public Management()
        {
            InitializeComponent();
        }

        private void Management_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddGroupStudent f3 = new AddGroupStudent();
            this.Hide();
            f3.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddGroupProject f4 = new AddGroupProject();
            this.Hide();
            f4.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddGroupEvaluation f5= new AddGroupEvaluation();
            this.Hide();
            f5.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            this.Hide();
            f1.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Group f2 = new Group();
            this.Hide();
            f2.Show();
        }
    }
}
