﻿using System;
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
    public partial class Form1 : MaterialSkin.Controls.MaterialForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void AddStudentlabel_Click(object sender, EventArgs e)
        {
            AddStudent f1 = new AddStudent();
            this.Hide();
            f1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EvaluationManagement f2 = new EvaluationManagement();
            this.Hide();
            f2.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdvisorManagement f3 = new AdvisorManagement();
            this.Hide();
            f3.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ProjectMagement f4 = new ProjectMagement();
            this.Hide();
            f4.Show();
        }
    }
}
