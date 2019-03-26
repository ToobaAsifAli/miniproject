namespace miniproject
{
    partial class AddGroupEvaluation
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
            this.ObtainMarkslabel = new System.Windows.Forms.Label();
            this.EvaluationDatelabel = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Searchbutton = new System.Windows.Forms.Button();
            this.Deletebutton = new System.Windows.Forms.Button();
            this.Updatebutton = new System.Windows.Forms.Button();
            this.Savebutton = new System.Windows.Forms.Button();
            this.Displaybutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ObtainMarkslabel
            // 
            this.ObtainMarkslabel.AutoSize = true;
            this.ObtainMarkslabel.Location = new System.Drawing.Point(97, 105);
            this.ObtainMarkslabel.Name = "ObtainMarkslabel";
            this.ObtainMarkslabel.Size = new System.Drawing.Size(70, 13);
            this.ObtainMarkslabel.TabIndex = 0;
            this.ObtainMarkslabel.Text = "Obtain Marks";
            // 
            // EvaluationDatelabel
            // 
            this.EvaluationDatelabel.AutoSize = true;
            this.EvaluationDatelabel.Location = new System.Drawing.Point(97, 148);
            this.EvaluationDatelabel.Name = "EvaluationDatelabel";
            this.EvaluationDatelabel.Size = new System.Drawing.Size(83, 13);
            this.EvaluationDatelabel.TabIndex = 1;
            this.EvaluationDatelabel.Text = "Evaluation Date";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(100, 203);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(471, 150);
            this.dataGridView1.TabIndex = 2;
            // 
            // Searchbutton
            // 
            this.Searchbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.Searchbutton.Location = new System.Drawing.Point(673, 306);
            this.Searchbutton.Name = "Searchbutton";
            this.Searchbutton.Size = new System.Drawing.Size(90, 37);
            this.Searchbutton.TabIndex = 26;
            this.Searchbutton.Text = "Search";
            this.Searchbutton.UseVisualStyleBackColor = false;
            // 
            // Deletebutton
            // 
            this.Deletebutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.Deletebutton.Location = new System.Drawing.Point(673, 248);
            this.Deletebutton.Name = "Deletebutton";
            this.Deletebutton.Size = new System.Drawing.Size(90, 37);
            this.Deletebutton.TabIndex = 25;
            this.Deletebutton.Text = "Delete";
            this.Deletebutton.UseVisualStyleBackColor = false;
            // 
            // Updatebutton
            // 
            this.Updatebutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.Updatebutton.Location = new System.Drawing.Point(673, 136);
            this.Updatebutton.Name = "Updatebutton";
            this.Updatebutton.Size = new System.Drawing.Size(90, 37);
            this.Updatebutton.TabIndex = 24;
            this.Updatebutton.Text = "Update";
            this.Updatebutton.UseVisualStyleBackColor = false;
            // 
            // Savebutton
            // 
            this.Savebutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.Savebutton.Location = new System.Drawing.Point(673, 81);
            this.Savebutton.Name = "Savebutton";
            this.Savebutton.Size = new System.Drawing.Size(90, 37);
            this.Savebutton.TabIndex = 23;
            this.Savebutton.Text = "Save";
            this.Savebutton.UseVisualStyleBackColor = false;
            // 
            // Displaybutton
            // 
            this.Displaybutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.Displaybutton.Location = new System.Drawing.Point(673, 194);
            this.Displaybutton.Name = "Displaybutton";
            this.Displaybutton.Size = new System.Drawing.Size(90, 37);
            this.Displaybutton.TabIndex = 22;
            this.Displaybutton.Text = "Display";
            this.Displaybutton.UseVisualStyleBackColor = false;
            this.Displaybutton.Click += new System.EventHandler(this.Displaybutton_Click);
            // 
            // AddGroupEvaluation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Searchbutton);
            this.Controls.Add(this.Deletebutton);
            this.Controls.Add(this.Updatebutton);
            this.Controls.Add(this.Savebutton);
            this.Controls.Add(this.Displaybutton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.EvaluationDatelabel);
            this.Controls.Add(this.ObtainMarkslabel);
            this.Name = "AddGroupEvaluation";
            this.Text = "AddGroupEvaluation";
            this.Load += new System.EventHandler(this.AddGroupEvaluation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ObtainMarkslabel;
        private System.Windows.Forms.Label EvaluationDatelabel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Searchbutton;
        private System.Windows.Forms.Button Deletebutton;
        private System.Windows.Forms.Button Updatebutton;
        private System.Windows.Forms.Button Savebutton;
        private System.Windows.Forms.Button Displaybutton;
    }
}