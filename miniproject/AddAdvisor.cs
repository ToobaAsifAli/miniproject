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
    public partial class AddAdvisor : MaterialSkin.Controls.MaterialForm
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-R6RA1PL\\TOOBAASIF;Initial Catalog=ProjectA;Persist Security Info=True;User ID=sa;Password=1212");

        public AddAdvisor()
        {
            InitializeComponent();
        }

        private void AddAdvisor_Load(object sender, EventArgs e)
        {

        }

        private void Savebutton_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0)
            {
                MessageBox.Show("please fill the above boxes ");
            }
            else
            {
                //   DegreecomboBox.Items.Add(NameBox.Text);

                //dataGridViewManage.Rows[0].Cells[0].Value = st.Courses[i].semester;

            }





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

            //string per = "INSERT into Person(FirstName , LastName , Contact , Email , DateOfBirth , Gender) values ('" + textBox1.Text + "' , '" + textBox2.Text + "' , '" + textBox3.Text + "' , '" + textBox4.Text + "' , '" + DateTime.Parse(textBox5.Text) + "' , '" + s + "')";
            string per = "INSERT into Person(FirstName , LastName , Contact , Email , DateOfBirth , Gender) values ('" + textBox1.Text + "' , '" + textBox2.Text + "' , '" + textBox3.Text + "' , '" + textBox4.Text + "' , '" + textBox5.Text + "' , '" + s + "')";

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
            string pid = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            string delete = "DELETE FROM Advisor WHERE Id = '" + int.Parse(pid) + "'";
            SqlCommand cmd = new SqlCommand(delete, con);
            if (MessageBox.Show("Do you really want to remove this advisor", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                cmd.ExecuteNonQuery();
                cmd.CommandText = string.Format("DELETE from Person where  Id ='" + int.Parse(pid) + "'");
                cmd.ExecuteNonQuery();
                dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
                MessageBox.Show("Records are deleted successfully");
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


            //      con.Open();
            //      SqlCommand cmd = con.CreateCommand();
            //      cmd.CommandType = CommandType.Text;
            //      // cmd.CommandText = "delete from Person where values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "')";
            //    //  cmd.CommandText = "update Person set name ='" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text +"' where FirstName = '"+textBox1.Text+"'";

            ////      cmd.CommandText = "update Person set LastName ='" + textBox2.Text + "' where FirstName = '" + textBox1.Text + "'";
            ////      cmd.CommandText = "update Person set Contact ='" + textBox3.Text + "' where FirstName = '" + textBox1.Text + "'";
            ////      cmd.CommandText = "update Person set Email ='" + textBox4.Text + "' where FirstName = '" + textBox1.Text + "'";
            ////      cmd.CommandText = "update Person set DateOfBirth ='" + textBox5.Text + "' where FirstName = '" + textBox1.Text + "'";
            //////      cmd.CommandText = "update Student set RegrationNo ='" + textBox7.Text + "' where Person.FirstName = '" + textBox1.Text + "'";
            //////      cmd.CommandText = "update Person set Gender ='" + comboBox1.Text + "' where FirstName = '" + textBox1.Text + "'";








            //      // cmd.CommandText = "update Person set LastName ='" + textBox2.Text + "'update Person set Gender = '" + textBox6.Text + "'where FirstName = '" + textBox1.Text + "'";


            //      cmd.ExecuteNonQuery();
            //      con.Close();

            //      disp_data();


            //      //dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
            //      MessageBox.Show("Record updated successfully");

        }

        private void Updatebutton_Click(object sender, EventArgs e)
        {
            //      con.Open();
            //      SqlCommand cmd = con.CreateCommand();
            //      cmd.CommandType = CommandType.Text;
            //      // cmd.CommandText = "delete from Person where values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "')";
            //    //  cmd.CommandText = "update Person set name ='" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text +"' where FirstName = '"+textBox1.Text+"'";

            ////      cmd.CommandText = "update Person set LastName ='" + textBox2.Text + "' where FirstName = '" + textBox1.Text + "'";
            ////      cmd.CommandText = "update Person set Contact ='" + textBox3.Text + "' where FirstName = '" + textBox1.Text + "'";
            ////      cmd.CommandText = "update Person set Email ='" + textBox4.Text + "' where FirstName = '" + textBox1.Text + "'";
            ////      cmd.CommandText = "update Person set DateOfBirth ='" + textBox5.Text + "' where FirstName = '" + textBox1.Text + "'";
            //////      cmd.CommandText = "update Student set RegrationNo ='" + textBox7.Text + "' where Person.FirstName = '" + textBox1.Text + "'";
            //////      cmd.CommandText = "update Person set Gender ='" + comboBox1.Text + "' where FirstName = '" + textBox1.Text + "'";








            //      // cmd.CommandText = "update Person set LastName ='" + textBox2.Text + "'update Person set Gender = '" + textBox6.Text + "'where FirstName = '" + textBox1.Text + "'";


            //      cmd.ExecuteNonQuery();
            //      con.Close();

            //      disp_data();


            //      //dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
            //      MessageBox.Show("Record updated successfully");







            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            string gdv = "select Id FROM Lookup WHERE Category = 'GENDER' AND value ='" + comboBox1.Text.ToString() + "'";
            SqlCommand genderInt = new SqlCommand(gdv, con);
            int s = 0;
            SqlDataReader reader3 = genderInt.ExecuteReader();
            // genderInt.ExecuteNonQuery();
            while (reader3.Read())
            {
                s = int.Parse(reader3[0].ToString());
            }
            //FirstName ='" + textBox2.Text + "' ,
            con.Close();
            con.Open();
            string que1 = string.Format("SELECT Id from Person Where Email = '" + textBox4.Text + "'");
            SqlCommand cmd = new SqlCommand(que1, con);
            var aa = cmd.ExecuteScalar().ToString();
            int s1 = int.Parse(aa);
            // int id =int.Parse( cmd.ExecuteScalar());
            string ps = "Update Person set FirstName ='" + textBox1.Text + "' ,  LastName= '" + textBox2.Text + "' , Contact = '" + textBox3.Text + "', Email = '" + textBox4.Text + "', DateOfBirth ='" + DateTime.Parse(textBox5.Text) + "', Gender = '" + s + "' WHERE Id= '" + s1 + "'";
            SqlCommand pesi = new SqlCommand(ps, con);
            int a = pesi.ExecuteNonQuery();
            string gender = comboBox2.Text.ToString();
            string desi = "select Id FROM Lookup WHERE Category = 'DESIGNATION' AND Value ='" + gender + "'";
            SqlCommand d = new SqlCommand(desi, con);
            int s2 = 0;
            SqlDataReader reader4 = d.ExecuteReader();
            // genderInt.ExecuteNonQuery();
            while (reader4.Read())
            {
                s2 = int.Parse(reader4[0].ToString());
            }
            string st = "Update Advisor set Designation = '" + s2 + "',Salary = '" + int.Parse(textBox7.Text) + "' where Id ='" + s1 + "'";
            SqlCommand persi1 = new SqlCommand(st, con);
            //int j = persi1.ExecuteNonQuery();


            if (MessageBox.Show("Do you really want to Update this record", "Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                MessageBox.Show("Record has been updated successfully");
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

        private void Displaybutton_Click(object sender, EventArgs e)
        {
            disp_data();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f2 = new Form1();
            this.Hide();
            f2.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdvisorManagement f3 = new AdvisorManagement();
            this.Hide();
            f3.Show();
        }
    }
}
