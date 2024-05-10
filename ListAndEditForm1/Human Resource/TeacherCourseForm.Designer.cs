namespace ListAndEditForm1.Human_Resource
{
    partial class TeacherCourseForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.TeacherNameLabel = new System.Windows.Forms.Label();
            this.CourseDataGridView = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CourseDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.IndianRed;
            this.panel1.Controls.Add(this.TeacherNameLabel);
            this.panel1.Controls.Add(this.CourseDataGridView);
            this.panel1.Location = new System.Drawing.Point(31, 24);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(948, 484);
            this.panel1.TabIndex = 1;
            // 
            // TeacherNameLabel
            // 
            this.TeacherNameLabel.AutoSize = true;
            this.TeacherNameLabel.Location = new System.Drawing.Point(33, 18);
            this.TeacherNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TeacherNameLabel.Name = "TeacherNameLabel";
            this.TeacherNameLabel.Size = new System.Drawing.Size(129, 16);
            this.TeacherNameLabel.TabIndex = 1;
            this.TeacherNameLabel.Text = "TeacherNameLabel";
            // 
            // CourseDataGridView
            // 
            this.CourseDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CourseDataGridView.Location = new System.Drawing.Point(33, 42);
            this.CourseDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.CourseDataGridView.Name = "CourseDataGridView";
            this.CourseDataGridView.RowHeadersWidth = 51;
            this.CourseDataGridView.Size = new System.Drawing.Size(873, 406);
            this.CourseDataGridView.TabIndex = 0;
            // 
            // TeacherCourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 544);
            this.Controls.Add(this.panel1);
            this.Name = "TeacherCourseForm";
            this.Text = "TeacherCourseForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CourseDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label TeacherNameLabel;
        private System.Windows.Forms.DataGridView CourseDataGridView;
    }
}