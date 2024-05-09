
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

namespace ListAndEditForm1.Result
{
    public partial class StaticResult : Form
    {
        private MY_DB MY_DB = new MY_DB();
        public StaticResult()
        {
            InitializeComponent();
        }

        private void StaticResult_Load(object sender, EventArgs e)
        {
            LoadDataToDataGridView();
            CalculatePassFailPercentage();
        }

        private void LoadDataToDataGridView()
        {
            try
            {
                MY_DB MY_DB = new MY_DB(); // Khởi tạo đối tượng My_DB

                string query = "SELECT label FROM Course";
                SqlDataAdapter adapter = new SqlDataAdapter(query, MY_DB.getConnection); // Sử dụng getConnection từ đối tượng My_DB
                DataTable courseTable = new DataTable();
                adapter.Fill(courseTable);

                dataGridViewStaticByCourse.Columns.Clear();

                // Thêm cột "Course Label" vào dataGridView
                DataGridViewTextBoxColumn courseLabelColumn = new DataGridViewTextBoxColumn();
                courseLabelColumn.HeaderText = "Course Label";
                courseLabelColumn.Name = "CourseLabel";
                dataGridViewStaticByCourse.Columns.Add(courseLabelColumn);

                // Thêm cột "Average Score" vào dataGridView
                DataGridViewTextBoxColumn averageScoreColumn = new DataGridViewTextBoxColumn();
                averageScoreColumn.HeaderText = "Average Score";
                averageScoreColumn.Name = "AverageScore";
                dataGridViewStaticByCourse.Columns.Add(averageScoreColumn);

                // Lấy dữ liệu điểm trung bình của từng môn học
                query = "SELECT Course.label AS CourseLabel, \r\n    ISNULL(SUM(score.student_score) / NULLIF(COUNT(DISTINCT score.student_id), 0), 0) AS AverageScore\r\nFROM Course \r\nLEFT JOIN score ON Course.Id = score.course_id \r\nGROUP BY Course.label \r\nORDER BY Course.label\r\n";

                adapter = new SqlDataAdapter(query, MY_DB.getConnection); // Sử dụng getConnection từ đối tượng My_DB
                DataTable resultTable = new DataTable();
                adapter.Fill(resultTable);

                // Hiển thị dữ liệu lên dataGridView
                foreach (DataRow row in resultTable.Rows)
                {
                    string courseLabel = row["CourseLabel"].ToString();
                    string averageScore = row["AverageScore"].ToString();

                    dataGridViewStaticByCourse.Rows.Add(courseLabel, averageScore);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
        }

        private void CalculatePassFailPercentage()
        {
            try
            {
                MY_DB MY_DB = new MY_DB();  // Khởi tạo đối tượng My_DB

                // Tính số lượng sinh viên pass và fail
                string passQuery = "SELECT COUNT(*) FROM std WHERE Id IN (SELECT student_id FROM score GROUP BY student_id HAVING AVG(student_score) >= 5)";
                string failQuery = "SELECT COUNT(*) FROM std WHERE Id IN (SELECT student_id FROM score GROUP BY student_id HAVING AVG(student_score) < 5)";

                SqlCommand passCmd = new SqlCommand(passQuery, MY_DB.getConnection);
                SqlCommand failCmd = new SqlCommand(failQuery, MY_DB.getConnection);

                MY_DB.openConnection();

                int passCount = Convert.ToInt32(passCmd.ExecuteScalar());
                int failCount = Convert.ToInt32(failCmd.ExecuteScalar());
                int totalStudents = passCount + failCount;

                MY_DB.closeConnection();

                // Tính phần trăm
                double passPercentage = (double)passCount / totalStudents * 100;
                double failPercentage = (double)failCount / totalStudents * 100;
                // Hiển thị phần trăm trên label
                labelPass.Text = "Pass: " + passPercentage.ToString("0.00") + "%";
                labelFail.Text = "Fail: " + failPercentage.ToString("0.00") + "%";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
        }

    }
}
