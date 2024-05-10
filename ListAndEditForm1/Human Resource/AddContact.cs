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
    public partial class AddContact : Form
    {
        public AddContact()
        {
            InitializeComponent();
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
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
        private bool CheckUserIDExists(int id, SqlConnection conn)
        {
            SqlCommand checkIdCommand = new SqlCommand("SELECT COUNT(*) FROM dbo.mycontact WHERE Id = @Id", conn);
            checkIdCommand.Parameters.AddWithValue("@Id", id);
            int exists = (int)checkIdCommand.ExecuteScalar();
            return exists > 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtconid.Text) || !int.TryParse(txtconid.Text, out int teacherId))
            {
                MessageBox.Show("Vui lòng nhập một ID hợp lệ cho giáo viên.", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string fName = txtconfname.Text.Trim();
            string lName = txtconlname.Text.Trim();
            string phone = txtconphone.Text.Trim();
            DateTime bdate = dobcontact.Value;
            string gender = "Male";

            if (radioButton2.Checked)
            {
                gender = "Female";
            }
            string address = txtconaddress.Text.Trim();
            int groupId = Convert.ToInt32(comboBox1.SelectedValue);

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

            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=QLSVDB;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    // Kiểm tra xem ID đã tồn tại hay chưa
                    if (CheckUserIDExists(teacherId, conn))
                    {
                        MessageBox.Show("ID User này đã tồn tại. Vui lòng nhập ID khác.", "Trùng ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    SqlCommand cmd = new SqlCommand("INSERT INTO dbo.mycontact (Id, fname_con, lname_con,dob_con, groupid, phone, gender_con, address_con, picture) VALUES (@Id, @FName, @LName,@dob, @GroupID, @Phone,@gender, @Address, @Pic)", conn);
                    cmd.Parameters.AddWithValue("@Id", teacherId);
                    cmd.Parameters.AddWithValue("@FName", fName);
                    cmd.Parameters.AddWithValue("@LName", lName);
                    cmd.Parameters.AddWithValue("@dob", bdate);
                    cmd.Parameters.AddWithValue("@GroupID", groupId);
                    cmd.Parameters.AddWithValue("@Phone", phone);
                    cmd.Parameters.AddWithValue("@gender", gender);
                    cmd.Parameters.AddWithValue("@Address", address);
                    cmd.Parameters.AddWithValue("@Pic", (img != null) ? (object)img : DBNull.Value);

                    int result = cmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Giáo viên đã được thêm thành công!");
                        ClearFormFields();
                    }
                    else
                    {
                        MessageBox.Show("Thêm giáo viên không thành công.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi thêm giáo viên: " + ex.Message, "Lỗi cơ sở dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ClearFormFields()
        {
            txtconfname.Clear();
            txtconlname.Clear();
            txtconphone.Clear();
            txtconaddress.Clear();
            PictureBoxContact.Image = null;
            comboBox1.SelectedIndex = -1; // Reset combobox
            txtconid.Clear();
        }

        private void LoadGroups()
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=QLSVDB;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("SELECT ID, Name FROM dbo.Groups", conn);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    comboBox1.DisplayMember = "Name";  // Hiển thị tên nhóm
                    comboBox1.ValueMember = "ID";      // Giá trị là ID của nhóm
                    comboBox1.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi tải nhóm: " + ex.Message);
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_DropDown(object sender, EventArgs e)
        {
            LoadGroups();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dobcontact_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btndeletecontact_Click(object sender, EventArgs e)
        {

        }

        private void PictureBoxContact_Click(object sender, EventArgs e)
        {

        }

        private void txtconphone_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtconaddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtconlname_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtconfname_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtconid_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
