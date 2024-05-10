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

namespace ListAndEditForm1.Human_Resource
{
    public partial class ShowFullTeacherForm : Form
    {
        public ShowFullTeacherForm()
        {
            InitializeComponent();
        }

        private void ShowAllTeacherButton_Click(object sender, EventArgs e)
        {
            ShowAllTeachers();
        }

        private void ShowAllTeachers()
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=QLSVDB;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("SELECT t.Id, t.fname AS 'First Name', t.lname AS 'Last Name', t.phone AS 'Phone', t.address AS 'Address', g.name AS 'Group' FROM teacher t INNER JOIN groups g ON t.group_id = g.Id", conn);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    TeacherDataGridView.DataSource = dt;

                    // Thiết lập HeaderText cho các cột
                    UpdateDataGridViewHeaders();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message);
                }
            }
        }

        private void LoadGroups()
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=QLSVDB;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("SELECT Id, name FROM groups", conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                GroupListBox.DisplayMember = "name";
                GroupListBox.ValueMember = "Id";
                GroupListBox.DataSource = dt;
            }
        }

        private void UpdateDataGridViewHeaders()
        {
            if (TeacherDataGridView.Columns["Id"] != null)
                TeacherDataGridView.Columns["Id"].HeaderText = "Teacher ID";

            if (TeacherDataGridView.Columns["fname"] != null)
                TeacherDataGridView.Columns["fname"].HeaderText = "First Name";

            if (TeacherDataGridView.Columns["lname"] != null)
                TeacherDataGridView.Columns["lname"].HeaderText = "Last Name";

            if (TeacherDataGridView.Columns["phone"] != null)
                TeacherDataGridView.Columns["phone"].HeaderText = "Phone";

            if (TeacherDataGridView.Columns["address"] != null)
                TeacherDataGridView.Columns["address"].HeaderText = "Address";

            if (TeacherDataGridView.Columns["name"] != null) // Tên cột phụ thuộc vào câu truy vấn SQL của bạn
                TeacherDataGridView.Columns["name"].HeaderText = "Group Name";
        }

        private void TeacherDataGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void GroupListBox_DoubleClick(object sender, EventArgs e)
        {
            if (GroupListBox.SelectedValue != null)
            {
                int groupId = Convert.ToInt32(GroupListBox.SelectedValue);
                FilterTeachersByGroup(groupId);
            }
        }

        private void FilterTeachersByGroup(int groupId)
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=QLSVDB;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("SELECT t.Id, t.fname AS 'First Name', t.lname AS 'Last Name', t.phone AS 'Phone', t.address AS 'Address', g.name AS 'Group' FROM teacher t INNER JOIN groups g ON t.group_id = g.Id WHERE g.Id = @GroupId", conn);
                cmd.Parameters.AddWithValue("@GroupId", groupId);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                TeacherDataGridView.DataSource = dt;

                // Cập nhật lại tiêu đề cột
                UpdateDataGridViewHeaders();
            }
        }
    }
}
