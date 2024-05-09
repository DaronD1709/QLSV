namespace ListAndEditForm1
{
    partial class Managestudentform
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
            this.txtStudentID = new System.Windows.Forms.TextBox();
            this.TextBoxFname = new System.Windows.Forms.TextBox();
            this.TextBoxLname = new System.Windows.Forms.TextBox();
            this.TextBoxPhone = new System.Windows.Forms.TextBox();
            this.TextBoxAddress = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.rbuttonMale = new System.Windows.Forms.RadioButton();
            this.rbuttonFemale = new System.Windows.Forms.RadioButton();
            this.btUpload = new System.Windows.Forms.Button();
            this.btDowload = new System.Windows.Forms.Button();
            this.PictureBoxStudentImage = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btAdd = new System.Windows.Forms.Button();
            this.btEdit = new System.Windows.Forms.Button();
            this.btRemove = new System.Windows.Forms.Button();
            this.btReset = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.textboxsearch = new System.Windows.Forms.TextBox();
            this.btSearch = new System.Windows.Forms.Button();
            this.LabelTotalStudent = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.TextBoxMail = new System.Windows.Forms.TextBox();
            this.qLSVDBDataSet = new ListAndEditForm1.QLSVDBDataSet();
            this.stdBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.stdTableAdapter1 = new ListAndEditForm1.QLSVDBDataSetTableAdapters.stdTableAdapter();
            this.qLSVDBDataSet7 = new ListAndEditForm1.QLSVDBDataSet7();
            this.stdBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.stdTableAdapter2 = new ListAndEditForm1.QLSVDBDataSet7TableAdapters.stdTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.stdBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.qLSVDBDataSet8 = new ListAndEditForm1.QLSVDBDataSet8();
            this.stdTableAdapter = new ListAndEditForm1.QLSVDBDataSet6TableAdapters.stdTableAdapter();
            this.qLSVDBDataSet6 = new ListAndEditForm1.QLSVDBDataSet6();
            this.pictureDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.selectedCourseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stdBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxStudentImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLSVDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stdBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLSVDBDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stdBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stdBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLSVDBDataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLSVDBDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stdBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtStudentID
            // 
            this.txtStudentID.Font = new System.Drawing.Font("Agency FB", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStudentID.Location = new System.Drawing.Point(171, 54);
            this.txtStudentID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.Size = new System.Drawing.Size(241, 29);
            this.txtStudentID.TabIndex = 0;
            this.txtStudentID.TextChanged += new System.EventHandler(this.txtStudentID_TextChanged);
            // 
            // TextBoxFname
            // 
            this.TextBoxFname.Font = new System.Drawing.Font("Agency FB", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxFname.Location = new System.Drawing.Point(171, 97);
            this.TextBoxFname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TextBoxFname.Name = "TextBoxFname";
            this.TextBoxFname.Size = new System.Drawing.Size(241, 29);
            this.TextBoxFname.TabIndex = 1;
            this.TextBoxFname.TextChanged += new System.EventHandler(this.TextBoxFname_TextChanged);
            // 
            // TextBoxLname
            // 
            this.TextBoxLname.Font = new System.Drawing.Font("Agency FB", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxLname.Location = new System.Drawing.Point(171, 145);
            this.TextBoxLname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TextBoxLname.Name = "TextBoxLname";
            this.TextBoxLname.Size = new System.Drawing.Size(241, 29);
            this.TextBoxLname.TabIndex = 2;
            // 
            // TextBoxPhone
            // 
            this.TextBoxPhone.Font = new System.Drawing.Font("Agency FB", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxPhone.Location = new System.Drawing.Point(171, 341);
            this.TextBoxPhone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TextBoxPhone.Name = "TextBoxPhone";
            this.TextBoxPhone.Size = new System.Drawing.Size(241, 29);
            this.TextBoxPhone.TabIndex = 3;
            this.TextBoxPhone.TextChanged += new System.EventHandler(this.TextBoxPhone_TextChanged);
            // 
            // TextBoxAddress
            // 
            this.TextBoxAddress.Font = new System.Drawing.Font("Agency FB", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxAddress.Location = new System.Drawing.Point(171, 384);
            this.TextBoxAddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TextBoxAddress.Name = "TextBoxAddress";
            this.TextBoxAddress.Size = new System.Drawing.Size(241, 29);
            this.TextBoxAddress.TabIndex = 4;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(171, 190);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(241, 31);
            this.dateTimePicker1.TabIndex = 5;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // rbuttonMale
            // 
            this.rbuttonMale.AutoSize = true;
            this.rbuttonMale.Font = new System.Drawing.Font("Agency FB", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbuttonMale.Location = new System.Drawing.Point(173, 297);
            this.rbuttonMale.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbuttonMale.Name = "rbuttonMale";
            this.rbuttonMale.Size = new System.Drawing.Size(67, 32);
            this.rbuttonMale.TabIndex = 6;
            this.rbuttonMale.TabStop = true;
            this.rbuttonMale.Text = "Male";
            this.rbuttonMale.UseVisualStyleBackColor = true;
            // 
            // rbuttonFemale
            // 
            this.rbuttonFemale.AutoSize = true;
            this.rbuttonFemale.Font = new System.Drawing.Font("Agency FB", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbuttonFemale.Location = new System.Drawing.Point(297, 297);
            this.rbuttonFemale.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbuttonFemale.Name = "rbuttonFemale";
            this.rbuttonFemale.Size = new System.Drawing.Size(85, 32);
            this.rbuttonFemale.TabIndex = 7;
            this.rbuttonFemale.TabStop = true;
            this.rbuttonFemale.Text = "Female";
            this.rbuttonFemale.UseVisualStyleBackColor = true;
            // 
            // btUpload
            // 
            this.btUpload.Font = new System.Drawing.Font("Agency FB", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btUpload.Location = new System.Drawing.Point(140, 565);
            this.btUpload.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btUpload.Name = "btUpload";
            this.btUpload.Size = new System.Drawing.Size(124, 47);
            this.btUpload.TabIndex = 8;
            this.btUpload.Text = "Upload";
            this.btUpload.UseVisualStyleBackColor = true;
            this.btUpload.Click += new System.EventHandler(this.btUpload_Click);
            // 
            // btDowload
            // 
            this.btDowload.Font = new System.Drawing.Font("Agency FB", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDowload.Location = new System.Drawing.Point(307, 565);
            this.btDowload.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btDowload.Name = "btDowload";
            this.btDowload.Size = new System.Drawing.Size(119, 47);
            this.btDowload.TabIndex = 9;
            this.btDowload.Text = "Dowload";
            this.btDowload.UseVisualStyleBackColor = true;
            this.btDowload.Click += new System.EventHandler(this.btDowload_Click);
            // 
            // PictureBoxStudentImage
            // 
            this.PictureBoxStudentImage.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.PictureBoxStudentImage.Location = new System.Drawing.Point(171, 429);
            this.PictureBoxStudentImage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PictureBoxStudentImage.Name = "PictureBoxStudentImage";
            this.PictureBoxStudentImage.Size = new System.Drawing.Size(241, 103);
            this.PictureBoxStudentImage.TabIndex = 10;
            this.PictureBoxStudentImage.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Agency FB", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 28);
            this.label1.TabIndex = 11;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Agency FB", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 28);
            this.label2.TabIndex = 12;
            this.label2.Text = "First Name :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Agency FB", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 28);
            this.label3.TabIndex = 13;
            this.label3.Text = "Last Name :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Agency FB", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(38, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 28);
            this.label4.TabIndex = 14;
            this.label4.Text = "Date Of Birth:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Agency FB", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(38, 297);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 28);
            this.label5.TabIndex = 15;
            this.label5.Text = "Gender:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Agency FB", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(38, 338);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 28);
            this.label6.TabIndex = 16;
            this.label6.Text = "Phone:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Agency FB", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(38, 377);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 28);
            this.label7.TabIndex = 17;
            this.label7.Text = "Address:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Agency FB", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(38, 414);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 28);
            this.label8.TabIndex = 18;
            this.label8.Text = "Picture :";
            // 
            // btAdd
            // 
            this.btAdd.BackColor = System.Drawing.Color.RoyalBlue;
            this.btAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAdd.Font = new System.Drawing.Font("Agency FB", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAdd.Location = new System.Drawing.Point(594, 588);
            this.btAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(147, 52);
            this.btAdd.TabIndex = 19;
            this.btAdd.Text = "Add";
            this.btAdd.UseVisualStyleBackColor = false;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btEdit
            // 
            this.btEdit.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEdit.Font = new System.Drawing.Font("Agency FB", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEdit.Location = new System.Drawing.Point(797, 588);
            this.btEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(147, 52);
            this.btEdit.TabIndex = 20;
            this.btEdit.Text = "Edit";
            this.btEdit.UseVisualStyleBackColor = false;
            this.btEdit.Click += new System.EventHandler(this.btEdit_Click);
            // 
            // btRemove
            // 
            this.btRemove.BackColor = System.Drawing.Color.Red;
            this.btRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRemove.Font = new System.Drawing.Font("Agency FB", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRemove.Location = new System.Drawing.Point(987, 588);
            this.btRemove.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btRemove.Name = "btRemove";
            this.btRemove.Size = new System.Drawing.Size(149, 52);
            this.btRemove.TabIndex = 21;
            this.btRemove.Text = "Remove";
            this.btRemove.UseVisualStyleBackColor = false;
            this.btRemove.Click += new System.EventHandler(this.btRemove_Click);
            // 
            // btReset
            // 
            this.btReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btReset.Font = new System.Drawing.Font("Agency FB", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btReset.Location = new System.Drawing.Point(1194, 588);
            this.btReset.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btReset.Name = "btReset";
            this.btReset.Size = new System.Drawing.Size(150, 52);
            this.btReset.TabIndex = 22;
            this.btReset.Text = "Reset";
            this.btReset.UseVisualStyleBackColor = false;
            this.btReset.Click += new System.EventHandler(this.btReset_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Agency FB", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(663, 47);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(237, 26);
            this.label9.TabIndex = 24;
            this.label9.Text = "Search Fname, Lname, Address :";
            // 
            // textboxsearch
            // 
            this.textboxsearch.Font = new System.Drawing.Font("Agency FB", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxsearch.Location = new System.Drawing.Point(932, 47);
            this.textboxsearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textboxsearch.Name = "textboxsearch";
            this.textboxsearch.Size = new System.Drawing.Size(263, 29);
            this.textboxsearch.TabIndex = 25;
            // 
            // btSearch
            // 
            this.btSearch.BackColor = System.Drawing.Color.SteelBlue;
            this.btSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSearch.Font = new System.Drawing.Font("Agency FB", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSearch.Location = new System.Drawing.Point(1234, 41);
            this.btSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(210, 41);
            this.btSearch.TabIndex = 26;
            this.btSearch.Text = "Search";
            this.btSearch.UseVisualStyleBackColor = false;
            this.btSearch.Click += new System.EventHandler(this.btSearch_Click);
            // 
            // LabelTotalStudent
            // 
            this.LabelTotalStudent.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.LabelTotalStudent.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTotalStudent.Location = new System.Drawing.Point(1174, 517);
            this.LabelTotalStudent.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelTotalStudent.Name = "LabelTotalStudent";
            this.LabelTotalStudent.Size = new System.Drawing.Size(341, 50);
            this.LabelTotalStudent.TabIndex = 27;
            this.LabelTotalStudent.Text = "Total Student :";
            this.LabelTotalStudent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LabelTotalStudent.Click += new System.EventHandler(this.LabelTotalStudent_Click_1);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Agency FB", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(38, 247);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 28);
            this.label10.TabIndex = 29;
            this.label10.Text = "Email :";
            // 
            // TextBoxMail
            // 
            this.TextBoxMail.Font = new System.Drawing.Font("Agency FB", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxMail.Location = new System.Drawing.Point(171, 245);
            this.TextBoxMail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TextBoxMail.Name = "TextBoxMail";
            this.TextBoxMail.Size = new System.Drawing.Size(241, 29);
            this.TextBoxMail.TabIndex = 28;
            // 
            // qLSVDBDataSet
            // 
            this.qLSVDBDataSet.DataSetName = "QLSVDBDataSet";
            this.qLSVDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stdBindingSource1
            // 
            this.stdBindingSource1.DataMember = "std";
            this.stdBindingSource1.DataSource = this.qLSVDBDataSet;
            // 
            // stdTableAdapter1
            // 
            this.stdTableAdapter1.ClearBeforeFill = true;
            // 
            // qLSVDBDataSet7
            // 
            this.qLSVDBDataSet7.DataSetName = "QLSVDBDataSet7";
            this.qLSVDBDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stdBindingSource2
            // 
            this.stdBindingSource2.DataMember = "std";
            this.stdBindingSource2.DataSource = this.qLSVDBDataSet7;
            // 
            // stdTableAdapter2
            // 
            this.stdTableAdapter2.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
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
            this.dataGridView1.Location = new System.Drawing.Point(438, 92);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1078, 422);
            this.dataGridView1.TabIndex = 30;
            // 
            // stdBindingSource3
            // 
            this.stdBindingSource3.DataMember = "std";
            // 
            // qLSVDBDataSet8
            // 
            this.qLSVDBDataSet8.DataSetName = "QLSVDBDataSet8";
            this.qLSVDBDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stdTableAdapter
            // 
            this.stdTableAdapter.ClearBeforeFill = true;
            // 
            // qLSVDBDataSet6
            // 
            this.qLSVDBDataSet6.DataSetName = "QLSVDBDataSet6";
            this.qLSVDBDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pictureDataGridViewImageColumn
            // 
            this.pictureDataGridViewImageColumn.DataPropertyName = "picture";
            this.pictureDataGridViewImageColumn.HeaderText = "Picture";
            this.pictureDataGridViewImageColumn.MinimumWidth = 6;
            this.pictureDataGridViewImageColumn.Name = "pictureDataGridViewImageColumn";
            // 
            // selectedCourseDataGridViewTextBoxColumn
            // 
            this.selectedCourseDataGridViewTextBoxColumn.DataPropertyName = "SelectedCourse";
            this.selectedCourseDataGridViewTextBoxColumn.HeaderText = "Selected Course";
            this.selectedCourseDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.selectedCourseDataGridViewTextBoxColumn.Name = "selectedCourseDataGridViewTextBoxColumn";
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Phone Number";
            this.phoneDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "Gender";
            this.genderDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // bdateDataGridViewTextBoxColumn
            // 
            this.bdateDataGridViewTextBoxColumn.DataPropertyName = "bdate";
            this.bdateDataGridViewTextBoxColumn.HeaderText = "BirthDate";
            this.bdateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bdateDataGridViewTextBoxColumn.Name = "bdateDataGridViewTextBoxColumn";
            // 
            // lnameDataGridViewTextBoxColumn
            // 
            this.lnameDataGridViewTextBoxColumn.DataPropertyName = "lname";
            this.lnameDataGridViewTextBoxColumn.HeaderText = "Last Name ";
            this.lnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lnameDataGridViewTextBoxColumn.Name = "lnameDataGridViewTextBoxColumn";
            // 
            // fnameDataGridViewTextBoxColumn
            // 
            this.fnameDataGridViewTextBoxColumn.DataPropertyName = "fname";
            this.fnameDataGridViewTextBoxColumn.HeaderText = "First Name ";
            this.fnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fnameDataGridViewTextBoxColumn.Name = "fnameDataGridViewTextBoxColumn";
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "StudentID";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // stdBindingSource
            // 
            this.stdBindingSource.DataMember = "std";
            this.stdBindingSource.DataSource = this.qLSVDBDataSet6;
            // 
            // Managestudentform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1528, 661);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.TextBoxMail);
            this.Controls.Add(this.LabelTotalStudent);
            this.Controls.Add(this.btSearch);
            this.Controls.Add(this.textboxsearch);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btReset);
            this.Controls.Add(this.btRemove);
            this.Controls.Add(this.btEdit);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PictureBoxStudentImage);
            this.Controls.Add(this.btDowload);
            this.Controls.Add(this.btUpload);
            this.Controls.Add(this.rbuttonFemale);
            this.Controls.Add(this.rbuttonMale);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.TextBoxAddress);
            this.Controls.Add(this.TextBoxPhone);
            this.Controls.Add(this.TextBoxLname);
            this.Controls.Add(this.TextBoxFname);
            this.Controls.Add(this.txtStudentID);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Managestudentform";
            this.Text = "Managestudentform";
            this.Load += new System.EventHandler(this.Managestudentform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxStudentImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLSVDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stdBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLSVDBDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stdBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stdBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLSVDBDataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLSVDBDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stdBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtStudentID;
        private System.Windows.Forms.TextBox TextBoxFname;
        private System.Windows.Forms.TextBox TextBoxLname;
        private System.Windows.Forms.TextBox TextBoxPhone;
        private System.Windows.Forms.TextBox TextBoxAddress;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.RadioButton rbuttonMale;
        private System.Windows.Forms.RadioButton rbuttonFemale;
        private System.Windows.Forms.Button btUpload;
        private System.Windows.Forms.Button btDowload;
        private System.Windows.Forms.PictureBox PictureBoxStudentImage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btEdit;
        private System.Windows.Forms.Button btRemove;
        private System.Windows.Forms.Button btReset;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textboxsearch;
        private System.Windows.Forms.Button btSearch;
        private System.Windows.Forms.Label LabelTotalStudent;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TextBoxMail;
        private QLSVDBDataSet qLSVDBDataSet;
        private System.Windows.Forms.BindingSource stdBindingSource1;
        private QLSVDBDataSetTableAdapters.stdTableAdapter stdTableAdapter1;
        private QLSVDBDataSet7 qLSVDBDataSet7;
        private System.Windows.Forms.BindingSource stdBindingSource2;
        private QLSVDBDataSet7TableAdapters.stdTableAdapter stdTableAdapter2;
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
        private System.Windows.Forms.BindingSource stdBindingSource3;
        private QLSVDBDataSet8 qLSVDBDataSet8;
        private QLSVDBDataSet6TableAdapters.stdTableAdapter stdTableAdapter;
        private QLSVDBDataSet6 qLSVDBDataSet6;
        private System.Windows.Forms.BindingSource stdBindingSource;
    }
}