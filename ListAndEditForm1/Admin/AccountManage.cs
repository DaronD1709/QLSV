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

namespace ListAndEditForm1.Admin
{
    public partial class AccountManage : Form
    {
        public AccountManage()
        {
            InitializeComponent();
        }

        private void btn_Reject_Click(object sender, EventArgs e)
        {
            if (dataGridViewListofAccountsAwaitingApproval.SelectedRows.Count > 0)
            {
                // Xác nhận xóa tài khoản
                DialogResult result = MessageBox.Show("Are you sure you want to refuse this account?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    // Lấy ID của tài khoản được chọn
                    int id = Convert.ToInt32(dataGridViewListofAccountsAwaitingApproval.SelectedRows[0].Cells["id"].Value);

                    try
                    {
                        MY_DB db = new MY_DB();
                        // Xóa tài khoản từ bảng PendingUser
                        SqlCommand deleteCommand = new SqlCommand("DELETE FROM PendingUser WHERE Id = @id", db.getConnection);
                        deleteCommand.Parameters.AddWithValue("@id", id);
                        db.openConnection();
                        int deleteRowsAffected = deleteCommand.ExecuteNonQuery();
                        if (deleteRowsAffected > 0)
                        {
                            //MessageBox.Show("Account removed from PendingUser.");
                            // Load lại danh sách tài khoản đang chờ phê duyệt
                            LoadPendingAccounts();
                        }
                        else
                        {
                            MessageBox.Show("Failed to remove account from PendingUser.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        // Đảm bảo rằng kết nối đến cơ sở dữ liệu được đóng sau khi hoàn tất
                        MY_DB db = new MY_DB();
                        db.closeConnection();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select an account to refuse.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Accept_Click(object sender, EventArgs e)
        {
            if (dataGridViewListofAccountsAwaitingApproval.SelectedRows.Count > 0)
            {
                // Lấy dữ liệu từ hàng được chọn trong dataGridViewListofAccountsAwaitingApproval
                DataGridViewRow selectedRow = dataGridViewListofAccountsAwaitingApproval.SelectedRows[0];
                int id = Convert.ToInt32(selectedRow.Cells["Id"].Value);
                string fname = Convert.ToString(selectedRow.Cells["Fisrt Name"].Value);
                string lname = Convert.ToString(selectedRow.Cells["Last Name"].Value);
                string username = Convert.ToString(selectedRow.Cells["uname"].Value);
                string password = Convert.ToString(selectedRow.Cells["pwd"].Value);

                // Lấy dữ liệu hình ảnh từ bảng tạm thời
                byte[] pictureData = GetPictureData(id);

                // Thêm dữ liệu vào bảng [UserHumanResource]
                try
                {
                    MY_DB db = new MY_DB();
                    SqlCommand command = new SqlCommand("INSERT INTO [loginhuman] (Id, f_name, l_name, uname, pwd, fig) VALUES (@id, @fname, @lname, @username, @password, @picture)", db.getConnection);
                    command.Parameters.AddWithValue("@id", id);
                    command.Parameters.AddWithValue("@fname", fname);
                    command.Parameters.AddWithValue("@lname", lname);
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@password", password); // Sử dụng mật khẩu không được băm
                    command.Parameters.AddWithValue("@picture", pictureData);
                    db.openConnection();
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Account added successfully to [loginhuman].");
                        // Xóa tài khoản từ bảng PendingUser
                        SqlCommand deleteCommand = new SqlCommand("DELETE FROM PendingUser WHERE Id = @id", db.getConnection);
                        deleteCommand.Parameters.AddWithValue("@id", id);
                        int deleteRowsAffected = deleteCommand.ExecuteNonQuery();
                        /*if (deleteRowsAffected > 0)
                        {
                            MessageBox.Show("Account removed from PendingUser.");
                        }
                        else
                        {
                            MessageBox.Show("Failed to remove account from PendingUser.");
                        }*/

                        // Load lại danh sách tài khoản đang chờ phê duyệt và danh sách tài khoản đã được duyệt
                        LoadPendingAccounts();
                        LoadAccounts();
                    }
                    else
                    {
                        MessageBox.Show("Failed to add account to [UserHumanResource].");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    // Đảm bảo rằng kết nối đến cơ sở dữ liệu được đóng sau khi hoàn tất
                    MY_DB db = new MY_DB();
                    db.closeConnection();
                }
            }
            else
            {
                MessageBox.Show("Please select an account to approve.");
            }
        }

        private void AccountManage_Load(object sender, EventArgs e)
        {

            LoadPendingAccounts();
            LoadAccounts();
        }


        private void LoadPendingAccounts()
        {
            try
            {
                MY_DB db = new MY_DB();
                string query = "SELECT Id AS id, f_name AS 'Fisrt Name', l_name AS 'Last Name', uname, pwd, fig FROM PendingUser";
                SqlCommand command = new SqlCommand(query, db.getConnection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridViewListofAccountsAwaitingApproval.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadAccounts()
        {
            try
            {
                MY_DB db = new MY_DB();
                string query = "SELECT Id AS id, f_name AS 'Fisrt Name', l_name AS 'Last Name', uname, pwd, fig FROM loginhuman";
                SqlCommand command = new SqlCommand(query, db.getConnection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridViewAccountManagement.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private byte[] GetPictureData(int id)
        {
            byte[] pictureData = null;
            try
            {
                MY_DB db = new MY_DB();
                SqlCommand command = new SqlCommand("SELECT fig FROM PendingUser WHERE Id = @id", db.getConnection);
                command.Parameters.AddWithValue("@id", id);
                db.openConnection();
                object result = command.ExecuteScalar();
                if (result != null)
                {
                    pictureData = (byte[])result;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                MY_DB db = new MY_DB();
                db.closeConnection();
            }
            return pictureData;
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (dataGridViewAccountManagement.SelectedRows.Count > 0)
            {
                // Xác nhận xóa tài khoản
                DialogResult result = MessageBox.Show("Are you sure you want to delete this account?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    // Lấy ID của tài khoản được chọn
                    int id = Convert.ToInt32(dataGridViewAccountManagement.SelectedRows[0].Cells["id"].Value);

                    try
                    {
                        MY_DB db = new MY_DB();
                        // Xóa tài khoản từ bảng UserHumanResource
                        SqlCommand deleteCommand = new SqlCommand("DELETE FROM loginhuman WHERE Id = @id", db.getConnection);
                        deleteCommand.Parameters.AddWithValue("@id", id);
                        db.openConnection();
                        int deleteRowsAffected = deleteCommand.ExecuteNonQuery();
                        if (deleteRowsAffected > 0)
                        {
                            //MessageBox.Show("Account deleted successfully.");
                            // Load lại danh sách tài khoản đã được duyệt
                            LoadAccounts();
                        }
                        else
                        {
                            MessageBox.Show("Failed to delete account.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        // Đảm bảo rằng kết nối đến cơ sở dữ liệu được đóng sau khi hoàn tất
                        MY_DB db = new MY_DB();
                        db.closeConnection();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select an account to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
