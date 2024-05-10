namespace ListAndEditForm1.Human_Resource
{
    partial class ShowFullTeacherForm
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
            this.ShowAllTeacherButton = new System.Windows.Forms.Button();
            this.TeacherDataGridView = new System.Windows.Forms.DataGridView();
            this.GroupListBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TeacherDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MistyRose;
            this.panel1.Controls.Add(this.ShowAllTeacherButton);
            this.panel1.Controls.Add(this.TeacherDataGridView);
            this.panel1.Controls.Add(this.GroupListBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1172, 430);
            this.panel1.TabIndex = 1;
            // 
            // ShowAllTeacherButton
            // 
            this.ShowAllTeacherButton.Location = new System.Drawing.Point(1001, 268);
            this.ShowAllTeacherButton.Margin = new System.Windows.Forms.Padding(4);
            this.ShowAllTeacherButton.Name = "ShowAllTeacherButton";
            this.ShowAllTeacherButton.Size = new System.Drawing.Size(145, 28);
            this.ShowAllTeacherButton.TabIndex = 4;
            this.ShowAllTeacherButton.Text = "Show All";
            this.ShowAllTeacherButton.UseVisualStyleBackColor = true;
            this.ShowAllTeacherButton.Click += new System.EventHandler(this.ShowAllTeacherButton_Click);
            // 
            // TeacherDataGridView
            // 
            this.TeacherDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TeacherDataGridView.Location = new System.Drawing.Point(321, 63);
            this.TeacherDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.TeacherDataGridView.Name = "TeacherDataGridView";
            this.TeacherDataGridView.RowHeadersWidth = 51;
            this.TeacherDataGridView.Size = new System.Drawing.Size(825, 185);
            this.TeacherDataGridView.TabIndex = 3;
            this.TeacherDataGridView.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TeacherDataGridView_CellContentDoubleClick);
            // 
            // GroupListBox
            // 
            this.GroupListBox.FormattingEnabled = true;
            this.GroupListBox.ItemHeight = 16;
            this.GroupListBox.Location = new System.Drawing.Point(37, 66);
            this.GroupListBox.Margin = new System.Windows.Forms.Padding(4);
            this.GroupListBox.Name = "GroupListBox";
            this.GroupListBox.Size = new System.Drawing.Size(167, 180);
            this.GroupListBox.TabIndex = 2;
            this.GroupListBox.DoubleClick += new System.EventHandler(this.GroupListBox_DoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(315, 28);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 36);
            this.label2.TabIndex = 1;
            this.label2.Text = "All Teacher";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Group";
            // 
            // ShowFullTeacherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1205, 459);
            this.Controls.Add(this.panel1);
            this.Name = "ShowFullTeacherForm";
            this.Text = "ShowFullTeacherForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TeacherDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ShowAllTeacherButton;
        private System.Windows.Forms.DataGridView TeacherDataGridView;
        private System.Windows.Forms.ListBox GroupListBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}