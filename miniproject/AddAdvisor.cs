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
    public partial class AddAdvisor : Form
    {


        SqlConnection con = new SqlConnection("Data Source=DESKTOP-R6RA1PL\\TOOBAASIF;Initial Catalog=ProjectA;Persist Security Info=True;User ID=sa;Password=1212");

        public AddAdvisor()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

       

        private void Displaybutton_Click(object sender, EventArgs e)
        {
            disp_data();
        }

        private void Insertbutton_Click(object sender, EventArgs e)
        {
            //con.Open();




            //string congo = comboBox1.SelectedItem.ToString();

            //string genderValue = "select Id FROM Lookup WHERE Category = 'Designation' AND value ='" + congo + "'";
            //SqlCommand genderInt = new SqlCommand(genderValue, con);
            //int value = 0;
            //SqlDataReader reader = genderInt.ExecuteReader();
            //// genderInt.ExecuteNonQuery();
            //while (reader.Read())
            //{
            //    value = int.Parse(reader[0].ToString());
            //}

            ////int gender = Convert.ToInt32(genderInt.ExecuteScalar ());

            //string per = "INSERT into Person(FirstName , LastName , Contact , Email , DateOfBirth , Gender) values ('" + textBox2.Text + "' , '" + textBox3.Text + "' , '" + textBox4.Text + "' , '" + textBox5.Text + "' , '" + textBox6.Text + "' , '" + value + "')";

            //SqlCommand persi = new SqlCommand(per, con);
            //int i = persi.ExecuteNonQuery();
            //int value1 = 0;
            //string query = "Select Id from Person where (Id = SCOPE_IDENTITY())";
            //SqlCommand cmd = new SqlCommand(query, con);
            //var val = cmd.ExecuteScalar().ToString();
            //value1 = int.Parse(val);
            //string q = "insert into Advisor values('" + value1 + "','" + textBox1.Text.ToString() + "')";
            //SqlCommand cmd1 = new SqlCommand(q, con);
            //int j = cmd1.ExecuteNonQuery();
            ////  string S_ID = string.Format("Select Id FROM Person where Email ='{0}'", email);
            //// SqlCommand StuID = new SqlCommand(S_ID, conn);
            //// int Id = Convert.ToInt32(StuID.ExecuteScalar());
            //// string st = "Insert into Student values( '" + Id + "' ,'" + textBox1.Text + "')";
            //// SqlCommand std = new SqlCommand(st, conn);
            //// int ii = std.ExecuteNonQuery();


            //con.Close();
            //disp_data();
            //MessageBox.Show("Data Inserted");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Savebutton_Click(object sender, EventArgs e)
        {
            con.Open();




            string gender = comboBox1.SelectedItem.ToString();

            string gdv = "select Id FROM Lookup WHERE Category = 'Gender' AND value ='" + gender + "'";
            SqlCommand gdInt = new SqlCommand(gdv, con);
            int s = 0;
            SqlDataReader reader = gdInt.ExecuteReader();
            // genderInt.ExecuteNonQuery();
            while (reader.Read())
            {
                s = int.Parse(reader[0].ToString());
            }
            con.Close();
            con.Open();

            //int gender = Convert.ToInt32(genderInt.ExecuteScalar ());

            string per = "INSERT into Person(FirstName , LastName , Contact , Email , DateOfBirth , Gender) values ('" + textBox1.Text + "' , '" + textBox2.Text + "' , '" + textBox3.Text + "' , '" + textBox4.Text + "' , '" + DateTime.Parse(textBox5.Text) + "' , '" + s + "')";

            SqlCommand pesi = new SqlCommand(per, con);
            int a = pesi.ExecuteNonQuery();
            int value1 = 0;
            string query = "Select Id from Person where (Id = SCOPE_IDENTITY())";
            SqlCommand cmd = new SqlCommand(query, con);
            var s1 = cmd.ExecuteScalar().ToString();
            value1 = int.Parse(s1);
            string designation = comboBox2.Text.ToString();
            string desi = "select Id FROM Lookup WHERE Category = 'DESIGNATION' AND Value ='" + designation + "'";
            SqlCommand d = new SqlCommand(desi, con);
            int s2 = 0;
            SqlDataReader reader1 = d.ExecuteReader();
            // genderInt.ExecuteNonQuery();
            while (reader1.Read())
            {
                s2 = int.Parse(reader1[0].ToString());
            }
            con.Close();
            con.Open();

            string q = "insert into Advisor values('" + value1 + "','" + s2 + "' , '" + int.Parse(textBox7.Text.ToString()) + "' )";
            SqlCommand cmd1 = new SqlCommand(q, con);
            int z = cmd1.ExecuteNonQuery();
            if (MessageBox.Show("Do you want to add him as an Advisor", "Add_Advisor", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MessageBox.Show("Advisor has been assigned to you");
            }
            else
            {
                MessageBox.Show("Advisor is not added", "Again Add the Advisor", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            con.Close();
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox7.Text = "";
            comboBox1.Text = "";
            comboBox2.Text = "";
            disp_data();



            //    con.Open();




            //    string congo = comboBox1.SelectedItem.ToString();
            //    string desi = comboBox2.SelectedItem.ToString();

            //    string genderValue = "select Id FROM Lookup WHERE Category = 'Gender' AND value ='" + congo + "'";
            //    string desiValue = "select Designation FROM Lookup WHERE Category = 'Designation' AND value ='" + desi + "'";
            //    SqlCommand genderInt = new SqlCommand(genderValue, con);
            //    int value = 0;
            //    SqlDataReader reader = genderInt.ExecuteReader();
            //    // genderInt.ExecuteNonQuery();
            //    while (reader.Read())
            //    {
            //        value = int.Parse(reader[0].ToString());
            //    }

            //     SqlCommand gInt = new SqlCommand(desiValue, con);
            //    int value = 0;
            //    SqlDataReader reader1 = genderInt.ExecuteReader();
            //    // genderInt.ExecuteNonQuery();
            //    while (reader1.Read())
            //    {
            //        value = int.Parse(reader[0].ToString());
            //    }

            //    //int gender = Convert.ToInt32(genderInt.ExecuteScalar ());
            //    con.Close();
            //    con.Open();

            //    string per = "INSERT into Person(FirstName , LastName , Contact , Email , DateOfBirth , Gender) values ('" + textBox1.Text + "' , '" + textBox2.Text + "' , '" + textBox3.Text + "' , '" + textBox4.Text + "' , '" + textBox5.Text + "' , '" + value + "')";

            //    SqlCommand persi = new SqlCommand(per, con);
            //    int i = persi.ExecuteNonQuery();

            //    int value1 = 0;
            //    //----------------------------------------------------------------------------------------
            //    string query = "Select Id from Person where (Id = SCOPE_IDENTITY())";
            //    SqlCommand cmd = new SqlCommand(query, con);
            //    var val = cmd.ExecuteScalar().ToString();
            //    value1 = int.Parse(val);
            //    //---------------------------------------------------------------------------------------------
            //    string q = "insert into Student values('" + value1 + "','" + textBox7.Text.ToString() + "')";
            //    SqlCommand cmd1 = new SqlCommand(q, con);
            //    int j = cmd1.ExecuteNonQuery();
            //    //  string S_ID = string.Format("Select Id FROM Person where Email ='{0}'", email);
            //    // SqlCommand StuID = new SqlCommand(S_ID, conn);
            //    // int Id = Convert.ToInt32(StuID.ExecuteScalar());
            //    // string st = "Insert into Student values( '" + Id + "' ,'" + textBox1.Text + "')";
            //    // SqlCommand std = new SqlCommand(st, conn);
            //    // int ii = std.ExecuteNonQuery();


            //    con.Close();
            //    disp_data();
            //    MessageBox.Show("Data Inserted");
        }

        private void Displaybutton_Click_1(object sender, EventArgs e)
        {
           
        }
        public void disp_data()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT Person.Id ,Person.FirstName, Person.LastName, Person.Contact, Person.Email, Person.DateOfBirth, Person.Gender, Advisor.Designation, Advisor.Salary FROM Person JOIN Advisor ON Advisor.Id = Person.Id";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void Deletebutton_Click(object sender, EventArgs e)
        {
            con.Open();
            string ID = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            string delete = "DELETE FROM Advisor WHERE Id = '" + int.Parse(ID) + "'";
            SqlCommand cmd = new SqlCommand(delete, con);
            if (MessageBox.Show("Do You want to delete it", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                cmd.ExecuteNonQuery();
                cmd.CommandText = string.Format("DELETE from Person where  Id ='" + int.Parse(ID) + "'");
                cmd.ExecuteNonQuery();
                dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
                MessageBox.Show("DATA IS DELETED");
            }
            else
            {
                MessageBox.Show("Row not deleted", "Remove row", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            con.Close();
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox7.Text = "";
            comboBox1.Text = "";
            comboBox2.Text = "";
            disp_data();
        }

        private void Updatebutton_Click(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            string genderValue = "select Id FROM Lookup WHERE Category = 'GENDER' AND value ='" + comboBox1.Text.ToString() + "'";
            SqlCommand genderInt = new SqlCommand(genderValue, con);
            int value = 0;
            SqlDataReader reader = genderInt.ExecuteReader();
            // genderInt.ExecuteNonQuery();
            while (reader.Read())
            {
                value = int.Parse(reader[0].ToString());
            }
            //FirstName ='" + textBox2.Text + "' ,
            string query = string.Format("SELECT Id from Person Where Email = '" + textBox4.Text + "'");
            SqlCommand cmd = new SqlCommand(query, con);
            var val = cmd.ExecuteScalar().ToString();
            int value1 = int.Parse(val);
            // int id =int.Parse( cmd.ExecuteScalar());
            string per = "Update Person set FirstName ='" + textBox1.Text + "' ,  LastName= '" + textBox2.Text + "' , Contact = '" + textBox3.Text + "', Email = '" + textBox4.Text + "', DateOfBirth ='" + DateTime.Parse(textBox5.Text) + "', Gender = '" + value + "' WHERE Id= '" + value1 + "'";
            SqlCommand persi = new SqlCommand(per, con);
            int i = persi.ExecuteNonQuery();
            string congo1 = comboBox2.Text.ToString();
            string desg = "select Id FROM Lookup WHERE Category = 'DESIGNATION' AND Value ='" + congo1 + "'";
            SqlCommand d = new SqlCommand(desg, con);
            int value5 = 0;
            SqlDataReader reader1 = d.ExecuteReader();
            // genderInt.ExecuteNonQuery();
            while (reader1.Read())
            {
                value5 = int.Parse(reader1[0].ToString());
            }
            string st = "Update Advisor set Designation = '" + value5 + "',Salary = '" + int.Parse(textBox7.Text) + "' where Id ='" + value1 + "'";
            SqlCommand persi1 = new SqlCommand(st, con);
            //int j = persi1.ExecuteNonQuery();


            if (MessageBox.Show("Do You want to Update it", "Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                MessageBox.Show("DATA IS Updated");
            }
            else
            {
                MessageBox.Show("Row not Updated", "Update row", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            con.Close();
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox7.Text = "";
            comboBox1.Text = "";
            comboBox2.Text = "";
            disp_data();
        }
    }
}
