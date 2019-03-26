namespace miniproject
{
    partial class AddProjectAdvisor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.AssignmentDatelabel = new System.Windows.Forms.Label();
            this.AdvisorRolelabel = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Searchbutton = new System.Windows.Forms.Button();
            this.Deletebutton = new System.Windows.Forms.Button();
            this.Updatebutton = new System.Windows.Forms.Button();
            this.Savebutton = new System.Windows.Forms.Button();
            this.Displaybutton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // AssignmentDatelabel
            // 
            this.AssignmentDatelabel.AutoSize = true;
            this.AssignmentDatelabel.Location = new System.Drawing.Point(105, 98);
            this.AssignmentDatelabel.Name = "AssignmentDatelabel";
            this.AssignmentDatelabel.Size = new System.Drawing.Size(87, 13);
            this.AssignmentDatelabel.TabIndex = 0;
            this.AssignmentDatelabel.Text = "Assignment Date";
            // 
            // AdvisorRolelabel
            // 
            this.AdvisorRolelabel.AutoSize = true;
            this.AdvisorRolelabel.Location = new System.Drawing.Point(105, 144);
            this.AdvisorRolelabel.Name = "AdvisorRolelabel";
            this.AdvisorRolelabel.Size = new System.Drawing.Size(67, 13);
            this.AdvisorRolelabel.TabIndex = 1;
            this.AdvisorRolelabel.Text = "Advisor Role";
            this.AdvisorRolelabel.Click += new System.EventHandler(this.AdvisorRolelabel_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(108, 192);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(493, 150);
            this.dataGridView1.TabIndex = 2;
            // 
            // Searchbutton
            // 
            this.Searchbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.Searchbutton.Location = new System.Drawing.Point(664, 299);
            this.Searchbutton.Name = "Searchbutton";
            this.Searchbutton.Size = new System.Drawing.Size(90, 37);
            this.Searchbutton.TabIndex = 26;
            this.Searchbutton.Text = "Search";
            this.Searchbutton.UseVisualStyleBackColor = false;
            // 
            // Deletebutton
            // 
            this.Deletebutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.Deletebutton.Location = new System.Drawing.Point(664, 241);
            this.Deletebutton.Name = "Deletebutton";
            this.Deletebutton.Size = new System.Drawing.Size(90, 37);
            this.Deletebutton.TabIndex = 25;
            this.Deletebutton.Text = "Delete";
            this.Deletebutton.UseVisualStyleBackColor = false;
            // 
            // Updatebutton
            // 
            this.Updatebutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.Updatebutton.Location = new System.Drawing.Point(664, 129);
            this.Updatebutton.Name = "Updatebutton";
            this.Updatebutton.Size = new System.Drawing.Size(90, 37);
            this.Updatebutton.TabIndex = 24;
            this.Updatebutton.Text = "Update";
            this.Updatebutton.UseVisualStyleBackColor = false;
            // 
            // Savebutton
            // 
            this.Savebutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.Savebutton.Location = new System.Drawing.Point(664, 74);
            this.Savebutton.Name = "Savebutton";
            this.Savebutton.Size = new System.Drawing.Size(90, 37);
            this.Savebutton.TabIndex = 23;
            this.Savebutton.Text = "Save";
            this.Savebutton.UseVisualStyleBackColor = false;
            this.Savebutton.Click += new System.EventHandler(this.Savebutton_Click);
            // 
            // Displaybutton
            // 
            this.Displaybutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.Displaybutton.Location = new System.Drawing.Point(664, 187);
            this.Displaybutton.Name = "Displaybutton";
            this.Displaybutton.Size = new System.Drawing.Size(90, 37);
            this.Displaybutton.TabIndex = 22;
            this.Displaybutton.Text = "Display";
            this.Displaybutton.UseVisualStyleBackColor = false;
            this.Displaybutton.Click += new System.EventHandler(this.Displaybutton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(220, 98);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 20);
            this.textBox1.TabIndex = 27;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Main Advisor",
            "Co-Advisror",
            "Industry Advisor"});
            this.comboBox1.Location = new System.Drawing.Point(220, 136);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 28;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // AddProjectAdvisor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Searchbutton);
            this.Controls.Add(this.Deletebutton);
            this.Controls.Add(this.Updatebutton);
            this.Controls.Add(this.Savebutton);
            this.Controls.Add(this.Displaybutton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.AdvisorRolelabel);
            this.Controls.Add(this.AssignmentDatelabel);
            this.Name = "AddProjectAdvisor";
            this.Text = "AddProjectAdvisor";
            this.Load += new System.EventHandler(this.AddProjectAdvisor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AssignmentDatelabel;
        private System.Windows.Forms.Label AdvisorRolelabel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Searchbutton;
        private System.Windows.Forms.Button Deletebutton;
        private System.Windows.Forms.Button Updatebutton;
        private System.Windows.Forms.Button Savebutton;
        private System.Windows.Forms.Button Displaybutton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}