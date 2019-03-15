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
    public partial class EvaluationManagement : MaterialSkin.Controls.MaterialForm
    {
        public EvaluationManagement()
        {
            InitializeComponent();
        }

        private void EvaluationManagement_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Evaluation f1 = new Evaluation();
            this.Hide();
            f1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f2 = new Form1();
            this.Hide();
            f2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 f3 = new Form1();
            this.Hide();
            f3.Show();
        }
    }
}
