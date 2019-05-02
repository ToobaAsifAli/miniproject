using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Data.SqlClient;

namespace miniproject
{
    public partial class Report : MaterialSkin.Controls.MaterialForm
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-R6RA1PL\\TOOBAASIF;Initial Catalog=ProjectA;Persist Security Info=True;User ID=sa;Password=1212");

        public Report()
        {
            InitializeComponent();
        }

        DataGridView maketable()
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }

            String cmd = "SELECT Project.Title as [Project Title],dbo.Person.[FirstName] +' '+Person.LastName as [Advisor Name],(SELECT Value From Lookup Where Id = ProjectAdvisor.[AdvisorRole]  AND Category ='ADVISOR_ROLE')as[Advisor Role],Student.RegistrationNo as [Registration Number] FROM Person p JOIN Advisor ON p.Id = Advisor.Id JOIN [dbo].ProjectAdvisor ON [dbo].ProjectAdvisor.AdvisorId = Advisor.Id JOIN [dbo].Project ON [dbo].ProjectAdvisor.ProjectId = Project.Id JOIN [dbo].[GroupProject] ON [dbo].GroupProject.[ProjectId] = Project.Id  JOIN [dbo].[Group] ON [dbo].[Group].[Id] = GroupProject.[GroupId] JOIN [dbo].GroupStudent ON [dbo].GroupStudent.GroupId = dbo.[Group].Id JOIN [dbo].Student ON [dbo].Student.Id = [dbo].GroupStudent.StudentId  JOIN Person on Advisor.Id = Person.Id";
            SqlCommand command = new SqlCommand(cmd, conn);
            DataTable dbadataset = new DataTable();
         
            try
            {
                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = command;

                sda.Fill(dbadataset);
                BindingSource bsource = new BindingSource();
                bsource.DataSource = dbadataset;
                dataGridView1.DataSource = bsource;
                sda.Update(dbadataset);
      
                conn.Close();
            }
         
            return dataGridView1;
        }
        DataGridView maketable1()
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
           
            String cmd = "SELECT Project.[Title] as [Project Title],Evaluation.[Name],[Group].Id as [Group Id],Student.[RegistrationNo] as [Registration No],(SELECT Value From Lookup Where Id = GroupStudent.Status  AND Category ='STATUS')as[Student Status],Evaluation.[TotalMarks] as [Total Marks],GroupEvaluation.[ObtainedMarks] as [Obtained Marks] FROM Evaluation JOIN GroupEvaluation ON GroupEvaluation.EvaluationId = Evaluation.Id JOIN [Group] ON [Group].Id=GroupEvaluation.GroupId JOIN GroupStudent ON GroupStudent.GroupId = [Group].Id JOIN Student ON Student.Id = GroupStudent.StudentId JOIN GroupProject ON GroupProject.GroupId = [Group].Id JOIN Project ON Project.Id =  GroupProject.ProjectId ";
            SqlCommand command = new SqlCommand(cmd, conn);
            DataTable dbadataset = new DataTable();
       
            try
            {
                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = command;

                sda.Fill(dbadataset);
                BindingSource bsource = new BindingSource();
                bsource.DataSource = dbadataset;
                dataGridView1.DataSource = bsource;
                sda.Update(dbadataset);
                //this.dataGridView1.Columns["ID"].Visible = false;
                conn.Close();
            }
           
            return dataGridView1;
        }
        public void exportgridtopdf(DataGridView dt1, string filename)
        {
            try
            {
            
           
               
                iTextSharp.text.Font text1 = new iTextSharp.text.Font(bfntHead, 10, iTextSharp.text.Font.NORMAL);
                for (int i = 0; i < dt1.Rows.Count; i++)
                {
                    for (int j = 0; j < dt1.Columns.Count; j++)
                    {
                        if (dt1[j, i].Value != null)
                        {
                            PdfPCell cell = new PdfPCell(new Phrase(dt1[j, i].Value.ToString(), text1));
                       
                            table.AddCell(cell);
                        }


                    }
                }
                //

                //
                var savefiledialogue = new SaveFileDialog();
                savefiledialogue.FileName = filename;
                savefiledialogue.DefaultExt = ".pdf";
                if (savefiledialogue.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (FileStream stream = new FileStream(savefiledialogue.FileName, FileMode.Create))
                        {
                            Document pdfdoc = new Document(PageSize.A4, 10f, 10f, 10f, 0f);

                            PdfWriter.GetInstance(pdfdoc, stream);
                            pdfdoc.Open();
                            iTextSharp.text.Font text4 = new iTextSharp.text.Font(bfntHead, 22, iTextSharp.text.Font.BOLD);
                            Paragraph para = new Paragraph(new Phrase("Generated Report", text4));
                            para.Alignment = Element.ALIGN_CENTER;
                            pdfdoc.Add(para);
                            pdfdoc.Add(new Paragraph("\r\n"));
                            iTextSharp.text.Font text5 = new iTextSharp.text.Font(bfntHead, 15, iTextSharp.text.Font.BOLD);
                          
                            pdfdoc.Add(new Paragraph("\r\n"));
                           
                            pdfdoc.Add(table);
                            pdfdoc.Close();
                            stream.Close();
                        }
                    }
                   


                }
            }
           



        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataGridView db1 = maketable();
            exportgridtopdf(db1, "Assigned_Projects");
          
            MessageBox.Show("The respective report has been generated");
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataGridView db1 = maketable1();
            exportgridtopdf(db1, "Project_Evaluation");
            MessageBox.Show("The respective report has been generated");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 f2 = new Form1();
            this.Hide();
            f2.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f2 = new Form1();
            this.Hide();
            f2.Show();
        }
    }
}
