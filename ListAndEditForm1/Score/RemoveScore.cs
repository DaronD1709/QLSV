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

namespace ListAndEditForm1.Score
{
    public partial class RemoveScore : Form
    {
        public RemoveScore()
        {
            InitializeComponent();
        }
        SCORE score = new SCORE();

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            SCORE score = new SCORE();
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

        private void button1_Click_1(object sender, EventArgs e)
        {
         
        }

        private void RemoveScore_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = score.getStudentScore();

        }

        private void btnref_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM score");
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 80;
            dataGridView1.DataSource = score.getStudentScore();
            dataGridView1.AllowUserToAddRows = false;
        }
    }
}
