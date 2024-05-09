using ListAndEditForm1.Human_Resource;
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

namespace ListAndEditForm1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }



        
        private void bt_Login_Click(object sender, EventArgs e)
        {
            MY_DB db = new MY_DB();
           

            if(radiobtnstudent.Checked )
            {
                SqlDataAdapter adapter = new SqlDataAdapter();
                DataTable table = new DataTable();
                SqlCommand command = new SqlCommand("SELECT * FROM log_in WHERE username = @User AND password = @Pass", db.getConnection);
                command.Parameters.Add("@User", SqlDbType.VarChar).Value = TextBoxUserName.Text;
                command.Parameters.Add("@Pass", SqlDbType.VarChar).Value = TextBoxPassword.Text;
                adapter.SelectCommand = command;
                adapter.Fill(table);
                if (table.Rows.Count > 0)
                {
                    //MessageBox.Show("Ok , next time will go to Main Menu of App");
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Invalid Username Or Password", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else if(radiobtnhuman.Checked)
            {
              
                SqlDataAdapter adapter1 = new SqlDataAdapter();
                DataTable table = new DataTable();
                SqlCommand command = new SqlCommand("SELECT * FROM loginhuman WHERE uname = @User AND pwd = @Pass", db.getConnection);
                command.Parameters.Add("@User", SqlDbType.VarChar).Value = TextBoxUserName.Text;
                command.Parameters.Add("@Pass", SqlDbType.VarChar).Value = TextBoxPassword.Text;
                adapter1.SelectCommand = command;
                adapter1.Fill(table);
                if (table.Rows.Count > 0)
                {
                    //MessageBox.Show("Ok , next time will go to Main Menu of App");
                    Globals.SetGlobalUserID(int.Parse(table.Rows[0][0].ToString()));                    // Dùng 1 lớp static Global Class, lớp này dùng để lấy và gọi ID từ table human ra 


                    HumanResourseForm resourseForm = new HumanResourseForm();    
                    resourseForm.Show();
                }
                else
                {
                    MessageBox.Show("Invalid Username Or Password", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void bt_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void checkBoxShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxShowPass.Checked)
            {
                TextBoxPassword.UseSystemPasswordChar = false;
            }
            else
            {
                TextBoxPassword.UseSystemPasswordChar = true;
            }
        }

        private void TextBoxPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegisterForm register = new RegisterForm(); 
            register.ShowDialog();
        }
    }
}
