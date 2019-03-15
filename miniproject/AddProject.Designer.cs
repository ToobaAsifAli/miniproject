namespace miniproject
{
    partial class AddProject
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Display = new System.Windows.Forms.Button();
            this.Searchlabel = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Titlelabel = new System.Windows.Forms.Label();
            this.Descriptionlabel = new System.Windows.Forms.Label();
            this.Deletelabel = new System.Windows.Forms.Button();
            this.Updatelabel = new System.Windows.Forms.Button();
            this.Insertlabel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(55, 220);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(547, 150);
            this.dataGridView1.TabIndex = 23;
            // 
            // Display
            // 
            this.Display.Location = new System.Drawing.Point(675, 300);
            this.Display.Name = "Display";
            this.Display.Size = new System.Drawing.Size(75, 23);
            this.Display.TabIndex = 22;
            this.Display.Text = "Display";
            this.Display.UseVisualStyleBackColor = true;
            this.Display.Click += new System.EventHandler(this.Display_Click);
            // 
            // Searchlabel
            // 
            this.Searchlabel.Location = new System.Drawing.Point(675, 246);
            this.Searchlabel.Name = "Searchlabel";
            this.Searchlabel.Size = new System.Drawing.Size(75, 23);
            this.Searchlabel.TabIndex = 21;
            this.Searchlabel.Text = "Search";
            this.Searchlabel.UseVisualStyleBackColor = true;
            this.Searchlabel.Click += new System.EventHandler(this.Searchlabel_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(194, 129);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 19;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(194, 88);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 18;
            // 
            // Titlelabel
            // 
            this.Titlelabel.AutoSize = true;
            this.Titlelabel.Location = new System.Drawing.Point(51, 136);
            this.Titlelabel.Name = "Titlelabel";
            this.Titlelabel.Size = new System.Drawing.Size(27, 13);
            this.Titlelabel.TabIndex = 16;
            this.Titlelabel.Text = "Title";
            // 
            // Descriptionlabel
            // 
            this.Descriptionlabel.AutoSize = true;
            this.Descriptionlabel.Location = new System.Drawing.Point(51, 91);
            this.Descriptionlabel.Name = "Descriptionlabel";
            this.Descriptionlabel.Size = new System.Drawing.Size(60, 13);
            this.Descriptionlabel.TabIndex = 15;
            this.Descriptionlabel.Text = "Description";
            // 
            // Deletelabel
            // 
            this.Deletelabel.Location = new System.Drawing.Point(675, 196);
            this.Deletelabel.Name = "Deletelabel";
            this.Deletelabel.Size = new System.Drawing.Size(75, 23);
            this.Deletelabel.TabIndex = 14;
            this.Deletelabel.Text = "Delete";
            this.Deletelabel.UseVisualStyleBackColor = true;
            this.Deletelabel.Click += new System.EventHandler(this.Deletelabel_Click);
            // 
            // Updatelabel
            // 
            this.Updatelabel.Location = new System.Drawing.Point(675, 136);
            this.Updatelabel.Name = "Updatelabel";
            this.Updatelabel.Size = new System.Drawing.Size(75, 23);
            this.Updatelabel.TabIndex = 13;
            this.Updatelabel.Text = "Update";
            this.Updatelabel.UseVisualStyleBackColor = true;
            this.Updatelabel.Click += new System.EventHandler(this.Updatelabel_Click);
            // 
            // Insertlabel
            // 
            this.Insertlabel.Location = new System.Drawing.Point(675, 81);
            this.Insertlabel.Name = "Insertlabel";
            this.Insertlabel.Size = new System.Drawing.Size(75, 23);
            this.Insertlabel.TabIndex = 12;
            this.Insertlabel.Text = "Insert";
            this.Insertlabel.UseVisualStyleBackColor = true;
            this.Insertlabel.Click += new System.EventHandler(this.Insertlabel_Click);
            // 
            // AddProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Display);
            this.Controls.Add(this.Searchlabel);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Titlelabel);
            this.Controls.Add(this.Descriptionlabel);
            this.Controls.Add(this.Deletelabel);
            this.Controls.Add(this.Updatelabel);
            this.Controls.Add(this.Insertlabel);
            this.Name = "AddProject";
            this.Text = "AddProject";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Display;
        private System.Windows.Forms.Button Searchlabel;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label Titlelabel;
        private System.Windows.Forms.Label Descriptionlabel;
        private System.Windows.Forms.Button Deletelabel;
        private System.Windows.Forms.Button Updatelabel;
        private System.Windows.Forms.Button Insertlabel;
    }
}