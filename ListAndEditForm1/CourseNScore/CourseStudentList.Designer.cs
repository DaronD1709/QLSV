﻿namespace ListAndEditForm1.CourseNScore
{
    partial class CourseStudentList
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.semesterlabel = new System.Windows.Forms.Label();
            this.txtnamecourse = new System.Windows.Forms.TextBox();
            this.stdBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLSVDBDataSet3 = new ListAndEditForm1.QLSVDBDataSet3();
            this.btnprint = new System.Windows.Forms.Button();
            this.stdTableAdapter = new ListAndEditForm1.QLSVDBDataSet3TableAdapters.stdTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.selectedCourseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.stdBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.qLSVDBDataSet6 = new ListAndEditForm1.QLSVDBDataSet6();
            this.stdBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.qLSVDBDataSet5BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLSVDBDataSet5 = new ListAndEditForm1.QLSVDBDataSet5();
            this.stdTableAdapter1 = new ListAndEditForm1.QLSVDBDataSet5TableAdapters.stdTableAdapter();
            this.qLSVDBDataSet6BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stdTableAdapter2 = new ListAndEditForm1.QLSVDBDataSet6TableAdapters.stdTableAdapter();
            this.btnsearchcourse = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.stdBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLSVDBDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stdBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLSVDBDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stdBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLSVDBDataSet5BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLSVDBDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLSVDBDataSet6BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Agency FB", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(285, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Course Name :";
            // 
            // semesterlabel
            // 
            this.semesterlabel.AutoSize = true;
            this.semesterlabel.Font = new System.Drawing.Font("Agency FB", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.semesterlabel.Location = new System.Drawing.Point(1101, 48);
            this.semesterlabel.Name = "semesterlabel";
            this.semesterlabel.Size = new System.Drawing.Size(121, 35);
            this.semesterlabel.TabIndex = 1;
            this.semesterlabel.Text = "Semester : ";
            // 
            // txtnamecourse
            // 
            this.txtnamecourse.Font = new System.Drawing.Font("Agency FB", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnamecourse.Location = new System.Drawing.Point(469, 44);
            this.txtnamecourse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtnamecourse.Multiline = true;
            this.txtnamecourse.Name = "txtnamecourse";
            this.txtnamecourse.ReadOnly = true;
            this.txtnamecourse.Size = new System.Drawing.Size(327, 50);
            this.txtnamecourse.TabIndex = 2;
            // 
            // stdBindingSource
            // 
            this.stdBindingSource.DataMember = "std";
            this.stdBindingSource.DataSource = this.qLSVDBDataSet3;
            // 
            // qLSVDBDataSet3
            // 
            this.qLSVDBDataSet3.DataSetName = "QLSVDBDataSet3";
            this.qLSVDBDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnprint
            // 
            this.btnprint.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnprint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnprint.Font = new System.Drawing.Font("Agency FB", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnprint.Location = new System.Drawing.Point(586, 545);
            this.btnprint.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnprint.Name = "btnprint";
            this.btnprint.Size = new System.Drawing.Size(283, 55);
            this.btnprint.TabIndex = 4;
            this.btnprint.Text = "Print";
            this.btnprint.UseVisualStyleBackColor = false;
            this.btnprint.Click += new System.EventHandler(this.btnprint_Click);
            // 
            // stdTableAdapter
            // 
            this.stdTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.fnameDataGridViewTextBoxColumn,
            this.lnameDataGridViewTextBoxColumn,
            this.bdateDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.selectedCourseDataGridViewTextBoxColumn,
            this.pictureDataGridViewImageColumn});
            this.dataGridView1.DataSource = this.stdBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(61, 127);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1310, 391);
            this.dataGridView1.TabIndex = 5;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Student ID";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // fnameDataGridViewTextBoxColumn
            // 
            this.fnameDataGridViewTextBoxColumn.DataPropertyName = "fname";
            this.fnameDataGridViewTextBoxColumn.HeaderText = "First Name";
            this.fnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fnameDataGridViewTextBoxColumn.Name = "fnameDataGridViewTextBoxColumn";
            // 
            // lnameDataGridViewTextBoxColumn
            // 
            this.lnameDataGridViewTextBoxColumn.DataPropertyName = "lname";
            this.lnameDataGridViewTextBoxColumn.HeaderText = "Last Name";
            this.lnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lnameDataGridViewTextBoxColumn.Name = "lnameDataGridViewTextBoxColumn";
            // 
            // bdateDataGridViewTextBoxColumn
            // 
            this.bdateDataGridViewTextBoxColumn.DataPropertyName = "bdate";
            this.bdateDataGridViewTextBoxColumn.HeaderText = "Birthdate";
            this.bdateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bdateDataGridViewTextBoxColumn.Name = "bdateDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "Gender";
            this.genderDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Phone";
            this.phoneDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            // 
            // selectedCourseDataGridViewTextBoxColumn
            // 
            this.selectedCourseDataGridViewTextBoxColumn.DataPropertyName = "SelectedCourse";
            this.selectedCourseDataGridViewTextBoxColumn.HeaderText = "Selected Course";
            this.selectedCourseDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.selectedCourseDataGridViewTextBoxColumn.Name = "selectedCourseDataGridViewTextBoxColumn";
            // 
            // pictureDataGridViewImageColumn
            // 
            this.pictureDataGridViewImageColumn.DataPropertyName = "picture";
            this.pictureDataGridViewImageColumn.HeaderText = "Picture";
            this.pictureDataGridViewImageColumn.MinimumWidth = 6;
            this.pictureDataGridViewImageColumn.Name = "pictureDataGridViewImageColumn";
            // 
            // stdBindingSource2
            // 
            this.stdBindingSource2.DataMember = "std";
            this.stdBindingSource2.DataSource = this.qLSVDBDataSet6;
            // 
            // qLSVDBDataSet6
            // 
            this.qLSVDBDataSet6.DataSetName = "QLSVDBDataSet6";
            this.qLSVDBDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stdBindingSource1
            // 
            this.stdBindingSource1.DataMember = "std";
            this.stdBindingSource1.DataSource = this.qLSVDBDataSet5BindingSource;
            // 
            // qLSVDBDataSet5BindingSource
            // 
            this.qLSVDBDataSet5BindingSource.DataSource = this.qLSVDBDataSet5;
            this.qLSVDBDataSet5BindingSource.Position = 0;
            // 
            // qLSVDBDataSet5
            // 
            this.qLSVDBDataSet5.DataSetName = "QLSVDBDataSet5";
            this.qLSVDBDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stdTableAdapter1
            // 
            this.stdTableAdapter1.ClearBeforeFill = true;
            // 
            // qLSVDBDataSet6BindingSource
            // 
            this.qLSVDBDataSet6BindingSource.DataSource = this.qLSVDBDataSet6;
            this.qLSVDBDataSet6BindingSource.Position = 0;
            // 
            // stdTableAdapter2
            // 
            this.stdTableAdapter2.ClearBeforeFill = true;
            // 
            // btnsearchcourse
            // 
            this.btnsearchcourse.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnsearchcourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsearchcourse.Font = new System.Drawing.Font("Agency FB", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsearchcourse.Location = new System.Drawing.Point(846, 40);
            this.btnsearchcourse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnsearchcourse.Name = "btnsearchcourse";
            this.btnsearchcourse.Size = new System.Drawing.Size(180, 55);
            this.btnsearchcourse.TabIndex = 6;
            this.btnsearchcourse.Text = "Search";
            this.btnsearchcourse.UseVisualStyleBackColor = false;
            this.btnsearchcourse.Click += new System.EventHandler(this.btnsearchcourse_Click);
            // 
            // CourseStudentList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1424, 625);
            this.Controls.Add(this.btnsearchcourse);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnprint);
            this.Controls.Add(this.txtnamecourse);
            this.Controls.Add(this.semesterlabel);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CourseStudentList";
            this.Text = "CourseStudentList";
            this.Load += new System.EventHandler(this.CourseStudentList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.stdBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLSVDBDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stdBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLSVDBDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stdBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLSVDBDataSet5BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLSVDBDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLSVDBDataSet6BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label semesterlabel;
        private System.Windows.Forms.TextBox txtnamecourse;
        private System.Windows.Forms.Button btnprint;
        private QLSVDBDataSet3 qLSVDBDataSet3;
        private System.Windows.Forms.BindingSource stdBindingSource;
        private QLSVDBDataSet3TableAdapters.stdTableAdapter stdTableAdapter;
        private System.Windows.Forms.BindingSource qLSVDBDataSet5BindingSource;
        private QLSVDBDataSet5 qLSVDBDataSet5;
        private System.Windows.Forms.BindingSource stdBindingSource1;
        private QLSVDBDataSet5TableAdapters.stdTableAdapter stdTableAdapter1;
        private QLSVDBDataSet6 qLSVDBDataSet6;
        private System.Windows.Forms.BindingSource qLSVDBDataSet6BindingSource;
        private System.Windows.Forms.BindingSource stdBindingSource2;
        private QLSVDBDataSet6TableAdapters.stdTableAdapter stdTableAdapter2;
        private System.Windows.Forms.Button btnsearchcourse;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn selectedCourseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn pictureDataGridViewImageColumn;
    }
}