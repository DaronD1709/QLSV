using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListAndEditForm1.Result
{
    internal class StudentResult
    {
        MY_DB dB = new MY_DB();
        public DataTable getStudentResult(string StdID, string Fname, string Lname)
        {
            // Kiểm tra xem có ít nhất một trong ba trường có dữ liệu không
            if (string.IsNullOrEmpty(StdID) && string.IsNullOrEmpty(Fname) && string.IsNullOrEmpty(Lname))
            {
                MessageBox.Show("Vui lòng nhập ít nhất một trong các trường: Id, First name, Last name.");
                return null;
            }

            // Mở kết nối
            dB.openConnection();

            // Tạo câu truy vấn SQL để lấy dữ liệu từ bảng Student và các cột Label từ bảng Course
            string query = "SELECT std.Id AS 'ID Student', std.fname AS 'First Name', std.lname AS 'Last Name'";

            // Truy vấn để lấy các Label từ bảng Course
            string labelQuery = "SELECT Label FROM COURSE";
            using (SqlCommand labelCommand = new SqlCommand(labelQuery, dB.getConnection))
            {
                SqlDataReader labelReader = labelCommand.ExecuteReader();

                // Trích xuất các Label từ bảng Course và thêm chúng vào truy vấn chính
                while (labelReader.Read())
                {
                    string label = labelReader["Label"].ToString();
                    query += $", (SELECT ISNULL(student_score, '') FROM score WHERE student_id = std.Id AND course_id = (SELECT Id FROM Course WHERE label = '{label}')) AS '{label}'";
                }
                labelReader.Close();
            }

            query += " FROM std WHERE 1=1"; // 1=1 để bắt đầu câu truy vấn

            // Thêm điều kiện cho câu truy vấn nếu StdID, Fname, Lname không rỗng
            if (!string.IsNullOrEmpty(StdID))
                query += " AND std.Id = @id";
            if (!string.IsNullOrEmpty(Fname))
                query += " AND std.fname LIKE @fname";
            if (!string.IsNullOrEmpty(Lname))
                query += " AND std.lname LIKE @lname";

            // Thực hiện truy vấn
            SqlCommand command = new SqlCommand(query, dB.getConnection);
            if (!string.IsNullOrEmpty(StdID))
                command.Parameters.AddWithValue("@id", StdID);
            if (!string.IsNullOrEmpty(Fname))
                command.Parameters.AddWithValue("@fname", "%" + Fname + "%");
            if (!string.IsNullOrEmpty(Lname))
                command.Parameters.AddWithValue("@lname", "%" + Lname + "%");

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            // Đóng kết nối
            dB.closeConnection();

            return dt;
        }
    }
}
