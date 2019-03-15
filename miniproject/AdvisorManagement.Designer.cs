namespace miniproject
{
    partial class AdvisorManagement
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
            this.AddAdvisorbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddAdvisorbutton
            // 
            this.AddAdvisorbutton.Location = new System.Drawing.Point(80, 132);
            this.AddAdvisorbutton.Name = "AddAdvisorbutton";
            this.AddAdvisorbutton.Size = new System.Drawing.Size(75, 23);
            this.AddAdvisorbutton.TabIndex = 0;
            this.AddAdvisorbutton.Text = "Add Advisor";
            this.AddAdvisorbutton.UseVisualStyleBackColor = true;
            this.AddAdvisorbutton.Click += new System.EventHandler(this.AddAdvisorbutton_Click);
            // 
            // AdvisorManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AddAdvisorbutton);
            this.Name = "AdvisorManagement";
            this.Text = "AdvisorManagement";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddAdvisorbutton;
    }
}