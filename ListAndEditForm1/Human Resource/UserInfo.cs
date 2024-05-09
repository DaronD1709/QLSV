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
using static System.Net.WebRequestMethods;

namespace ListAndEditForm1.Human_Resource
{
    public partial class UserInfo : Form
    {
        public UserInfo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                PictureBoxUser.Image = Image.FromFile(opf.FileName);
            }
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtiduser.Text))
            {
                int id = int.Parse(txtiduser.Text);

                // Tạo SqlCommand để cập nhật thông tin sinh viên dựa trên ID
                SqlCommand updateCommand = new SqlCommand("UPDATE loginhuman SET f_name = @fname, l_name = @lname, uname = @u_name, pwd = @pass, fig = @picture WHERE Id = @id");

                updateCommand.Parameters.AddWithValue("@id", id);
                updateCommand.Parameters.AddWithValue("@fname", txtfnameuser.Text);
                updateCommand.Parameters.AddWithValue("@lname", txtlnameuser.Text);
                updateCommand.Parameters.AddWithValue("@u_name", txtaccuser.Text);
                updateCommand.Parameters.AddWithValue("@pass", txtpassuser.Text);


                // Chuyển hình ảnh thành byte array để lưu trữ trong cơ sở dữ liệu
                MemoryStream ms = new MemoryStream();
                PictureBoxUser.Image.Save(ms, PictureBoxUser.Image.RawFormat);
                byte[] picture = ms.ToArray();
                updateCommand.Parameters.AddWithValue("@picture", picture);

                // Thực hiện lệnh UPDATE trực tiếp từ đối tượng updateCommand
                int result;

                using (SqlConnection connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=QLSVDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"))

                {
                    connection.Open();
                    updateCommand.Connection = connection;

                    // ExecuteNonQuery trả về số dòng bị ảnh hưởng
                    result = updateCommand.ExecuteNonQuery();
                }

                // Kiểm tra và xử lý kết quả
                if (result > 0)
                {
                    MessageBox.Show("User information updated successfully!", "Edit User", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Failed to update user information. ID not found.", "Edit User", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Please enter the user ID to edit.", "Edit user", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
