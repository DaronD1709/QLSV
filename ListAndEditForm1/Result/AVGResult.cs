using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListAndEditForm1.Result
{
    public partial class AVGResult : Form
    {
        public AVGResult()
        {
            InitializeComponent();

        }
        StudentResult studentresult = new StudentResult();


        private void buttonPrint_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();
            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                // Tạo một PrintDocument
                PrintDocument printDocument = new PrintDocument();
                printDocument.PrintPage += (s, ev) =>
                {
                    // Vẽ nội dung từ dataGridViewAVGResultByScore
                    Bitmap bm = new Bitmap(dataGridView1.Width, dataGridView1.Height);
                    dataGridView1.DrawToBitmap(bm, new System.Drawing.Rectangle(0, 0, dataGridView1.Width, dataGridView1.Height));
                    ev.Graphics.DrawImage(bm, 0, 0);
                };

                // Kích hoạt hộp thoại in
                printDocument.Print();
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string IdOrFName = tbSearch.Text.Trim();



            // Kiểm tra xem đã nhập đủ id, fname, lname chưa
            if (string.IsNullOrEmpty(IdOrFName))
            {
                MessageBox.Show("Vui lòng nhập Id Student");
                return;
            }

            // Gọi phương thức getStudentResult và hiển thị kết quả trong dataGridViewAVGResultByScore
            System.Data.DataTable dt = studentresult.getStudentResult(IdOrFName, null, null);

            // Tính điểm trung bình các course và thêm cột AverageScore vào DataTable
            dt.Columns.Add("AverageScore", typeof(float));
            foreach (DataRow row in dt.Rows)
            {
                // Lấy tất cả các cột có tên là course label
                var courseScores = dt.Columns.Cast<DataColumn>()
                    .Where(col => col.ColumnName != "ID Student" && col.ColumnName != "First Name" && col.ColumnName != "Last Name" && col.ColumnName != "AverageScore")
                    .Select(col =>
                    {
                        var value = row[col];
                        return value == DBNull.Value ? (float?)null : Convert.ToSingle(value);
                    }).ToList();

                // Tính điểm trung bình chỉ cho các course mà sinh viên thực sự có điểm
                float? averageScoreNullable = courseScores.Any(score => score != null) ? courseScores.Where(score => score != null).Average() : null;
                float averageScore = averageScoreNullable ?? 0;

                row["AverageScore"] = averageScore;
            }
            // Tính điểm trung bình các course và thêm cột AverageScore vào DataTable
            dt.Columns.Add("Result", typeof(string)); // Thêm cột Result vào DataTable

            foreach (DataRow row in dt.Rows)
            {
                // Lấy giá trị điểm trung bình từ cột AverageScore
                float averageScore = Convert.ToSingle(row["AverageScore"]);

                // Phân loại kết quả dựa trên điểm trung bình
                string result;
                if (averageScore > 9)
                {
                    result = "A+";
                }
                else if (averageScore >= 8)
                {
                    result = "A";
                }
                else if (averageScore >= 7)
                {
                    result = "B+";
                }
                else if (averageScore >= 6)
                {
                    result = "C+";
                }
                else if (averageScore >= 5)
                {
                    result = "C";
                }
                else
                {
                    result = "D (fail)";
                }

                // Gán kết quả vào cột Result
                row["Result"] = result;
            }


            // Hiển thị kết quả trong dataGridViewAVGResultByScore
            dataGridView1.DataSource = dt;
        }
    }
}
