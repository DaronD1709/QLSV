using ListAndEditForm1.CourseNScore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ListAndEditForm1.Score
{
    public partial class ManageScoreForm : Form
    {
        SCORE score = new SCORE();
        Student student = new Student();
        Course course = new Course();
        string data = "score";


        public ManageScoreForm()
        {
            InitializeComponent();
        }

        private void ManageScoreForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = score.getStudentScore();

            // populate combobox with course id and name 
            ComboBoxCourse.DataSource = course.getAllCourses();
            ComboBoxCourse.DisplayMember = "label";
            ComboBoxCourse.ValueMember = "id";
        }

        private void btnshowstd_Click(object sender, EventArgs e)
        {
            data = "std";
            SqlCommand command = new SqlCommand("SELECT id, fname, lname, bdate, SelectedCourse FROM std");
            dataGridView1.DataSource = student.getStudents(command);
        }

        private void btnshowscore_Click(object sender, EventArgs e)
        {
            data = "score";
            dataGridView1.DataSource = score.getStudentScore();
        }


        void getDataFromDatagridView()
        {
            if (data == "std" )
            {
                TextBoxStudentID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            }
            else if (data == "score ")
            {
                TextBoxStudentID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                ComboBoxCourse.SelectedValue = dataGridView1.CurrentRow.Cells[3].Value;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            getDataFromDatagridView();
        }

        private void btnave_Click(object sender, EventArgs e)
        {
            avgScoreByCourseForm avgScoreBy = new avgScoreByCourseForm();
            avgScoreBy.Show(this);
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            try
            {
                int studentID = Convert.ToInt32(TextBoxStudentID.Text);
                int courseID = Convert.ToInt32(ComboBoxCourse.SelectedValue);
                float scoreValue = Convert.ToInt32(TextBoxScore.Text);
                string description = TextBoxDescript.Text;

                if (!score.studentScoreExist(studentID, courseID))
                {
                    if (score.insertScore(studentID, courseID, scoreValue, description))
                    {
                        MessageBox.Show("Student Score Inserted", "Add Score", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Student Score Not Inserted", "Add Score", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid numeric values for student ID, course ID, and score.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnremove_Click(object sender, EventArgs e)
        {
            try
            {
                int studentID = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                int courseID = int.Parse(dataGridView1.CurrentRow.Cells[3].Value.ToString());

                MessageBox.Show("Are you sure you want to Delete This Course", "Remove Score", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (score.deletescore(studentID, courseID))
                {
                    MessageBox.Show("Score Deleted", "Remove Score", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Score Not Deleted", "Remove Score", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch
            {
                MessageBox.Show("Enter A Valid Numeric ID", "Remove Score", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM score");
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 80;
            dataGridView1.DataSource = score.getStudentScore();
            dataGridView1.AllowUserToAddRows = false;
        }
    }
}
