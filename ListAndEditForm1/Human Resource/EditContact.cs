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
    public partial class EditContact : Form
    {
        public EditContact(int userID)
        {
            InitializeComponent();
            UserID = userID;
        }
        private int UserID;

        private void LoadTeacherData()
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=QLSVDB;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM mycontact WHERE Id = @Id", conn);
                cmd.Parameters.AddWithValue("@Id", UserID);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        txtconfname.Text = reader["fname_con"].ToString();
                        txtconlname.Text = reader["lname_con"].ToString();
                        txtconphone.Text = reader["phone"].ToString();
                        txtconaddress.Text = reader["address_con"].ToString();

                        if (reader["picture"] != DBNull.Value)
                        {
                            byte[] pic = (byte[])reader["picture"];
                            MemoryStream pictureStream = new MemoryStream(pic);
                            PictureBoxContact.Image = Image.FromStream(pictureStream);
                        }
                    }
                }
            }
            LoadGroups();  // Load danh sách nhóm vào ComboBox
        }



        private void LoadGroups()
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=QLSVDB;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("SELECT ID, Name FROM Groups", conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                comboBox1.DisplayMember = "Name";
                comboBox1.ValueMember = "ID";
                comboBox1.DataSource = dt;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string fName = txtconfname.Text.Trim();
            string lName = txtconlname.Text.Trim();
            string phone = txtconphone.Text.Trim();
            string address = txtconaddress.Text.Trim();
            int groupId = Convert.ToInt32(comboBox1.SelectedValue); // Lấy ID của nhóm đã chọn
            DateTime bdate = dobcontact.Value;
            string gender = "Male";

            if (radioButton2.Checked)
            {
                gender = "Female";
            }

            // Xử lý hình ảnh
            byte[] img = null;
            if (PictureBoxContact.Image != null)
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    PictureBoxContact.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                    img = ms.ToArray();
                }
            }

            // Chuỗi kết nối và câu lệnh SQL để cập nhật
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=QLSVDB;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = @"UPDATE dbo.mycontact 
                             SET fname_con = @FName, lname_con = @LName,dob_con = @dob,gender_con =@gen, groupid = @GroupID, phone = @Phone, address_con = @Address, picture = @Pic
                             WHERE Id = @UserID";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@FName", fName);
                        cmd.Parameters.AddWithValue("@LName", lName);
                        cmd.Parameters.AddWithValue("@dob", bdate);
                        cmd.Parameters.AddWithValue("@gen", gender);
                        cmd.Parameters.AddWithValue("@GroupID", groupId);
                        cmd.Parameters.AddWithValue("@Phone", phone);
                        cmd.Parameters.AddWithValue("@Address", address);
                        cmd.Parameters.AddWithValue("@UserID", UserID); // Giả định rằng bạn đã lưu Id khi form được mở
                        if (img != null)
                        {
                            cmd.Parameters.AddWithValue("@Pic", img);
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@Pic", DBNull.Value);
                        }

                        int result = cmd.ExecuteNonQuery();
                        if (result > 0)
                        {
                            MessageBox.Show("Thông tin user đã được cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close(); // Đóng form sau khi cập nhật thành công
                        }
                        else
                        {
                            MessageBox.Show("Cập nhật không thành công. Vui lòng thử lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi cập nhật thông tin user: " + ex.Message, "Lỗi cơ sở dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btndeletecontact_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnupload_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                PictureBoxContact.Image = Image.FromFile(opf.FileName);
            }
        }
    }
}
