namespace miniproject
{
    partial class Form1
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
            this.perosonlabel = new System.Windows.Forms.Label();
            this.AddStudentbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // perosonlabel
            // 
            this.perosonlabel.AutoSize = true;
            this.perosonlabel.Location = new System.Drawing.Point(364, 32);
            this.perosonlabel.Name = "perosonlabel";
            this.perosonlabel.Size = new System.Drawing.Size(40, 13);
            this.perosonlabel.TabIndex = 0;
            this.perosonlabel.Text = "Person";
            // 
            // AddStudentbutton
            // 
            this.AddStudentbutton.Location = new System.Drawing.Point(91, 102);
            this.AddStudentbutton.Name = "AddStudentbutton";
            this.AddStudentbutton.Size = new System.Drawing.Size(75, 23);
            this.AddStudentbutton.TabIndex = 1;
            this.AddStudentbutton.Text = "Add Student";
            this.AddStudentbutton.UseVisualStyleBackColor = true;
            this.AddStudentbutton.Click += new System.EventHandler(this.AddStudentlabel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AddStudentbutton);
            this.Controls.Add(this.perosonlabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label perosonlabel;
        private System.Windows.Forms.Button AddStudentbutton;
    }
}

