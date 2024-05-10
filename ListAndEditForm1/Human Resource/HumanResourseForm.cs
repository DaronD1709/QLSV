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

namespace ListAndEditForm1.Human_Resource
{
    public partial class HumanResourseForm : Form
    {
        public HumanResourseForm()
        {
            InitializeComponent();
        }
        private int position;
        public HumanResourseForm(int position)
        {
            InitializeComponent();
            this.position = position;
        }

        private void HumanResourseForm_Load(object sender, EventArgs e)
        {
            User user = new User();
            user.ID = Globals.GlobalUserID.ToString();
            string sql = "Select * from loginhuman where Id = '" + user.ID + "'";
            if (position == -1)
                sql = "Select * from Login where MSGV = '" + user.ID + "'";
            SqlCommand cmd = new SqlCommand(sql);
            DataTable dt = user.getUser(cmd);
            if (dt.Rows[0][5] != null)
            {
                byte[] pic = (byte[])dt.Rows[0][5];
                user.Picture = new MemoryStream(pic);
                pictureBox1.Image = Image.FromStream(user.Picture);
            }
            else
                pictureBox1.Image = null;
            lb_Name.Text = dt.Rows[0][2].ToString();
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UserInfo userInfo = new UserInfo();
            userInfo.Show(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddContact addContact = new AddContact();
            addContact.Show(this);
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            User user = new User();
            user.ID = Globals.GlobalUserID.ToString();
            string sql = "Select * from loginhuman where Id = '" + user.ID + "'";
            if (position == -1)
                sql = "Select * from Login where MSGV = '" + user.ID + "'";
            SqlCommand cmd = new SqlCommand(sql);
            DataTable dt = user.getUser(cmd);
            if (dt.Rows[0][5] != null)
            {
                byte[] pic = (byte[])dt.Rows[0][5];
                user.Picture = new MemoryStream(pic);
                pictureBox1.Image = Image.FromStream(user.Picture);
            }
            else
                pictureBox1.Image = null;
            lb_Name.Text = dt.Rows[0][2].ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int userID;
            if (int.TryParse(txtuserID.Text, out userID))
            {
                string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=QLSVDB;Integrated Security=True";
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();
                        SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM dbo.mycontact WHERE Id = @id", conn);
                        cmd.Parameters.AddWithValue("@id", userID);
                        int exists = (int)cmd.ExecuteScalar();

                        if (exists > 0)
                        {
                            EditContact editForm = new EditContact(userID); // Khởi tạo form với teacherId
                            editForm.ShowDialog(); // Hiển thị form dưới dạng modal
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy user với ID đã nhập. Vui lòng kiểm tra lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi truy xuất cơ sở dữ liệu: " + ex.Message, "Lỗi cơ sở dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập một ID hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int userID;
            if (int.TryParse(txtuserID.Text, out userID))
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa User này?", "Xóa User", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=QLSVDB;Integrated Security=True";
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        try
                        {
                            conn.Open();
                            SqlCommand cmd = new SqlCommand("DELETE FROM dbo.mycontact WHERE Id = @id", conn);
                            cmd.Parameters.AddWithValue("@id", userID);

                            int result = cmd.ExecuteNonQuery();
                            if (result > 0)
                            {
                                MessageBox.Show("User đã được xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                txtuserID.Clear();  // Xóa trường ID sau khi xóa thành công
                            }
                            else
                            {
                                MessageBox.Show("Không tìm thấy User với ID này hoặc đã xảy ra lỗi khi xóa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Lỗi khi xóa User: " + ex.Message, "Lỗi cơ sở dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập một ID hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ShowFullTeacherForm showFullTeacher = new ShowFullTeacherForm();
            showFullTeacher.Show(this);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // Kiểm tra nhập liệu
            if (string.IsNullOrWhiteSpace(GroupIdTextBox.Text) || string.IsNullOrWhiteSpace(GroupNameTextBox.Text))
            {
                MessageBox.Show("Vui lòng nhập cả ID và tên nhóm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int groupId;
            if (!int.TryParse(GroupIdTextBox.Text, out groupId))
            {
                MessageBox.Show("ID nhóm phải là số nguyên.", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string groupName = GroupNameTextBox.Text.Trim();

            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=QLSVDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO dbo.Groups (ID, Name) VALUES (@Id, @Name)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Id", groupId);
                        cmd.Parameters.AddWithValue("@Name", groupName);

                        int result = cmd.ExecuteNonQuery();
                        if (result > 0)
                        {
                            MessageBox.Show("Thêm nhóm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            // Xóa trường sau khi thêm
                            GroupIdTextBox.Clear();
                            GroupNameTextBox.Clear();
                        }
                        else
                        {
                            MessageBox.Show("Thêm nhóm không thành công. Vui lòng thử lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi thêm nhóm: " + ex.Message, "Lỗi cơ sở dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            LoadGroupsToComboBox();
            LoadGroupsToRemoveComboBox();
        }

        private void LoadGroupsToComboBox()
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=QLSVDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("SELECT ID, Name FROM dbo.Groups", conn);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    EditGroupComboBox.DisplayMember = "Name"; // Text to display.
                    EditGroupComboBox.ValueMember = "ID"; // Corresponding value.
                    EditGroupComboBox.DataSource = dt; // Set the data source.
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi tải nhóm: " + ex.Message);
                }
            }
        }

        private void LoadGroupsToRemoveComboBox()
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=QLSVDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("SELECT ID, Name FROM dbo.Groups", conn);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    RemoveGroupComboBox.DisplayMember = "Name"; // Text to display.
                    RemoveGroupComboBox.ValueMember = "ID"; // Corresponding value.
                    RemoveGroupComboBox.DataSource = dt; // Set the data source.
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi tải nhóm: " + ex.Message);
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (EditGroupComboBox.SelectedValue == null || string.IsNullOrWhiteSpace(NewNameGroupTextBox.Text))
            {
                MessageBox.Show("Vui lòng chọn nhóm và nhập tên mới.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int selectedGroupId = Convert.ToInt32(EditGroupComboBox.SelectedValue);
            string newGroupName = NewNameGroupTextBox.Text.Trim();

            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=QLSVDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE dbo.Groups SET Name = @Name WHERE ID = @Id", conn);
                    cmd.Parameters.AddWithValue("@Id", selectedGroupId);
                    cmd.Parameters.AddWithValue("@Name", newGroupName);

                    int result = cmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Tên nhóm đã được cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadGroupsToComboBox(); // Tải lại danh sách nhóm
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật không thành công.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi cập nhật nhóm: " + ex.Message);
                }
            }
            LoadGroupsToComboBox();
            LoadGroupsToRemoveComboBox();

        }

        private void button8_Click(object sender, EventArgs e)
        {

            if (RemoveGroupComboBox.SelectedValue != null)
            {
                int selectedGroupId = Convert.ToInt32(RemoveGroupComboBox.SelectedValue);

                string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=QLSVDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();
                        SqlCommand cmd = new SqlCommand("DELETE FROM dbo.Groups WHERE ID = @Id", conn);
                        cmd.Parameters.AddWithValue("@Id", selectedGroupId);

                        int result = cmd.ExecuteNonQuery();
                        if (result > 0)
                        {
                            MessageBox.Show("Nhóm đã được xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadGroupsToRemoveComboBox(); // Tải lại danh sách nhóm
                        }
                        else
                        {
                            MessageBox.Show("Xóa nhóm không thành công.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi xóa nhóm: " + ex.Message, "Lỗi cơ sở dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một nhóm để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            LoadGroupsToComboBox();
            LoadGroupsToRemoveComboBox();
        }
    }
}
