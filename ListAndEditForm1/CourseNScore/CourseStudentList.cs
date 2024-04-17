using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListAndEditForm1.CourseNScore
{
    public partial class CourseStudentList : Form
    {
        public CourseStudentList()
        {
            InitializeComponent();
        }

        Student student = new Student();

        private void CourseStudentList_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLSVDBDataSet5.std' table. You can move, or remove it, as needed.
            this.stdTableAdapter1.Fill(this.qLSVDBDataSet5.std);
            SqlCommand command = new SqlCommand("SELECT * FROM std");
            dataGridView1.ReadOnly = true;
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            dataGridView1.RowTemplate.Height = 80;
            dataGridView1.DataSource = student.getStudents(command);
            picCol = (DataGridViewImageColumn)dataGridView1.Columns[9];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dataGridView1.AllowUserToAddRows = false;

        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {

        }

        private void btnprint_Click(object sender, EventArgs e)
        {
            
            SqlCommand command = new SqlCommand("SELECT * FROM std WHERE CONCAT(id,fname,lname,address,SelectedCourse)LIKE '%" + txtnamecourse.Text + "%'");
            
            fillGrid(command);
        }

        private void fillGrid(SqlCommand command)
        {

            dataGridView1.ReadOnly = true;
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            dataGridView1.RowTemplate.Height = 80;
            dataGridView1.DataSource = student.getStudents(command);
            picCol = (DataGridViewImageColumn)dataGridView1.Columns[7];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dataGridView1.AllowUserToAddRows = false;
            // Dem sinh vien 
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
    }
}
