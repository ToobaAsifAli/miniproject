﻿using System;
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
    public partial class Evaluation : MaterialSkin.Controls.MaterialForm
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-R6RA1PL\\TOOBAASIF;Initial Catalog=ProjectA;Persist Security Info=True;User ID=sa;Password=1212");

        public Evaluation()
        {
            InitializeComponent();
        }

        private void Insertlabel_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into Evaluation values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "')";// + "insert into Student values('" + textBox7.Text + "')";
            cmd.ExecuteNonQuery();
            con.Close();
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";

            //   textBox7.Text = "";
            //disp_data();
            MessageBox.Show("Record inserted successfully");
        }


        public void disp_data()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Evaluation";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void Searchlabel_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Evalution where Name ='" + textBox1.Text + "'";
            textBox1.Text = "";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            con.Close();
            disp_data();
        }

        private void Deletelabel_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            // cmd.CommandText = "delete from Person where values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "')";
            cmd.CommandText = "delete from Evaluation where Name ='" + textBox1.Text + "'";

            cmd.ExecuteNonQuery();
            con.Close();

            disp_data();


            //dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
            MessageBox.Show("Record deleted successfully");
        }

        private void Display_Click(object sender, EventArgs e)
        {
            disp_data();
        }

        private void Updatelabel_Click(object sender, EventArgs e)
        {  

            con.Open(); 
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;


            cmd.CommandText = "update Evaluation set TotalMarks ='" + textBox2.Text + "' where Name = '" + textBox1.Text + "'";
            cmd.ExecuteNonQuery();
            cmd.CommandText = "update Evaluation set TotalWeightage ='" + textBox3.Text + "' where Name = '" + textBox1.Text + "'";
     
            cmd.ExecuteNonQuery();
            con.Close();

            disp_data();


            //dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
            MessageBox.Show("Record updated successfully");
        }

        private void Evaluation_Load(object sender, EventArgs e)
        {

        }
    }
}
