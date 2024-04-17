namespace ListAndEditForm1
{
    partial class studentsListForm
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
            this.stdBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.QLSVDBDataSet = new ListAndEditForm1.QLSVDBDataSet();
            this.stdTableAdapter = new ListAndEditForm1.QLSVDBDataSetTableAdapters.stdTableAdapter();
            this.ButtonRefresh = new System.Windows.Forms.Button();
            this.btnimport = new System.Windows.Forms.Button();
            this.stdBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.qLSVDBDataSet4 = new ListAndEditForm1.QLSVDBDataSet4();
            this.stdBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.qLSVDBDataSet3 = new ListAndEditForm1.QLSVDBDataSet3();
            this.stdBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.stdTableAdapter1 = new ListAndEditForm1.QLSVDBDataSet3TableAdapters.stdTableAdapter();
            this.btnsave = new System.Windows.Forms.Button();
            this.stdTableAdapter2 = new ListAndEditForm1.QLSVDBDataSet4TableAdapters.stdTableAdapter();
            this.stdBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.qLSVDBDataSet5 = new ListAndEditForm1.QLSVDBDataSet5();
            this.stdBindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            this.stdTableAdapter3 = new ListAndEditForm1.QLSVDBDataSet5TableAdapters.stdTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.qLSVDBDataSet5BindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            ((System.ComponentModel.ISupportInitialize)(this.stdBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QLSVDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stdBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLSVDBDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stdBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLSVDBDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stdBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stdBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLSVDBDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stdBindingSource5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLSVDBDataSet5BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // stdBindingSource
            // 
            this.stdBindingSource.DataMember = "std";
            this.stdBindingSource.DataSource = this.QLSVDBDataSet;
            // 
            // QLSVDBDataSet
            // 
            this.QLSVDBDataSet.DataSetName = "QLSVDBDataSet";
            this.QLSVDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stdTableAdapter
            // 
            this.stdTableAdapter.ClearBeforeFill = true;
            // 
            // ButtonRefresh
            // 
            this.ButtonRefresh.Font = new System.Drawing.Font("Agency FB", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonRefresh.Location = new System.Drawing.Point(665, 372);
            this.ButtonRefresh.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ButtonRefresh.Name = "ButtonRefresh";
            this.ButtonRefresh.Size = new System.Drawing.Size(141, 49);
            this.ButtonRefresh.TabIndex = 1;
            this.ButtonRefresh.Text = "Refresh";
            this.ButtonRefresh.UseVisualStyleBackColor = true;
            this.ButtonRefresh.Click += new System.EventHandler(this.ButtonRefresh_Click);
            // 
            // btnimport
            // 
            this.btnimport.Font = new System.Drawing.Font("Agency FB", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnimport.Location = new System.Drawing.Point(276, 372);
            this.btnimport.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnimport.Name = "btnimport";
            this.btnimport.Size = new System.Drawing.Size(141, 49);
            this.btnimport.TabIndex = 2;
            this.btnimport.Text = "Import";
            this.btnimport.UseVisualStyleBackColor = true;
            this.btnimport.Click += new System.EventHandler(this.btnimport_Click);
            // 
            // stdBindingSource3
            // 
            this.stdBindingSource3.DataMember = "std";
            this.stdBindingSource3.DataSource = this.qLSVDBDataSet4;
            // 
            // qLSVDBDataSet4
            // 
            this.qLSVDBDataSet4.DataSetName = "QLSVDBDataSet4";
            this.qLSVDBDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stdBindingSource2
            // 
            this.stdBindingSource2.DataMember = "std";
            this.stdBindingSource2.DataSource = this.QLSVDBDataSet;
            // 
            // qLSVDBDataSet3
            // 
            this.qLSVDBDataSet3.DataSetName = "QLSVDBDataSet3";
            this.qLSVDBDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stdBindingSource1
            // 
            this.stdBindingSource1.DataMember = "std";
            this.stdBindingSource1.DataSource = this.qLSVDBDataSet3;
            // 
            // stdTableAdapter1
            // 
            this.stdTableAdapter1.ClearBeforeFill = true;
            // 
            // btnsave
            // 
            this.btnsave.Font = new System.Drawing.Font("Agency FB", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.Location = new System.Drawing.Point(465, 372);
            this.btnsave.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(141, 49);
            this.btnsave.TabIndex = 4;
            this.btnsave.Text = "Save In DB";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // stdTableAdapter2
            // 
            this.stdTableAdapter2.ClearBeforeFill = true;
            // 
            // stdBindingSource4
            // 
            this.stdBindingSource4.DataMember = "std";
            this.stdBindingSource4.DataSource = this.qLSVDBDataSet4;
            // 
            // qLSVDBDataSet5
            // 
            this.qLSVDBDataSet5.DataSetName = "QLSVDBDataSet5";
            this.qLSVDBDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stdBindingSource5
            // 
            this.stdBindingSource5.DataMember = "std";
            this.stdBindingSource5.DataSource = this.qLSVDBDataSet5;
            // 
            // stdTableAdapter3
            // 
            this.stdTableAdapter3.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
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
            this.dataGridView1.DataSource = this.stdBindingSource5;
            this.dataGridView1.Location = new System.Drawing.Point(33, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1049, 328);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CurrentCellChanged += new System.EventHandler(this.dataGridView1_CurrentCellChanged);
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick_2);
            // 
            // qLSVDBDataSet5BindingSource
            // 
            this.qLSVDBDataSet5BindingSource.DataSource = this.qLSVDBDataSet5;
            this.qLSVDBDataSet5BindingSource.Position = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // fnameDataGridViewTextBoxColumn
            // 
            this.fnameDataGridViewTextBoxColumn.DataPropertyName = "fname";
            this.fnameDataGridViewTextBoxColumn.HeaderText = "fname";
            this.fnameDataGridViewTextBoxColumn.Name = "fnameDataGridViewTextBoxColumn";
            // 
            // lnameDataGridViewTextBoxColumn
            // 
            this.lnameDataGridViewTextBoxColumn.DataPropertyName = "lname";
            this.lnameDataGridViewTextBoxColumn.HeaderText = "lname";
            this.lnameDataGridViewTextBoxColumn.Name = "lnameDataGridViewTextBoxColumn";
            // 
            // bdateDataGridViewTextBoxColumn
            // 
            this.bdateDataGridViewTextBoxColumn.DataPropertyName = "bdate";
            this.bdateDataGridViewTextBoxColumn.HeaderText = "bdate";
            this.bdateDataGridViewTextBoxColumn.Name = "bdateDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "gender";
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "phone";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            // 
            // selectedCourseDataGridViewTextBoxColumn
            // 
            this.selectedCourseDataGridViewTextBoxColumn.DataPropertyName = "SelectedCourse";
            this.selectedCourseDataGridViewTextBoxColumn.HeaderText = "SelectedCourse";
            this.selectedCourseDataGridViewTextBoxColumn.Name = "selectedCourseDataGridViewTextBoxColumn";
            // 
            // pictureDataGridViewImageColumn
            // 
            this.pictureDataGridViewImageColumn.DataPropertyName = "picture";
            this.pictureDataGridViewImageColumn.HeaderText = "picture";
            this.pictureDataGridViewImageColumn.Name = "pictureDataGridViewImageColumn";
            // 
            // studentsListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(1105, 471);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.btnimport);
            this.Controls.Add(this.ButtonRefresh);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "studentsListForm";
            this.Text = "studentsListForm";
            this.Load += new System.EventHandler(this.studentsListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.stdBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QLSVDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stdBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLSVDBDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stdBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLSVDBDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stdBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stdBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLSVDBDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stdBindingSource5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLSVDBDataSet5BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private QLSVDBDataSet QLSVDBDataSet;
        private System.Windows.Forms.BindingSource stdBindingSource;
        private QLSVDBDataSetTableAdapters.stdTableAdapter stdTableAdapter;
        private System.Windows.Forms.Button ButtonRefresh;
        private System.Windows.Forms.Button btnimport;
        private QLSVDBDataSet3 qLSVDBDataSet3;
        private System.Windows.Forms.BindingSource stdBindingSource1;
        private QLSVDBDataSet3TableAdapters.stdTableAdapter stdTableAdapter1;
        private System.Windows.Forms.BindingSource stdBindingSource2;
        private System.Windows.Forms.Button btnsave;
        private QLSVDBDataSet4 qLSVDBDataSet4;
        private System.Windows.Forms.BindingSource stdBindingSource3;
        private QLSVDBDataSet4TableAdapters.stdTableAdapter stdTableAdapter2;
        private System.Windows.Forms.BindingSource stdBindingSource4;
        private QLSVDBDataSet5 qLSVDBDataSet5;
        private System.Windows.Forms.BindingSource stdBindingSource5;
        private QLSVDBDataSet5TableAdapters.stdTableAdapter stdTableAdapter3;
        private System.Windows.Forms.DataGridView dataGridView1;
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
        private System.Windows.Forms.BindingSource qLSVDBDataSet5BindingSource;
    }
}