using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ListAndEditForm1.Human_Resource;

namespace ListAndEditForm1
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void ButtonUploadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                PictureBoxStudentImage.Image = Image.FromFile(opf.FileName);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (!string.IsNullOrEmpty(textBox.Text))
            {
                if (!int.TryParse(textBox.Text, out _))
                {
                    MessageBox.Show("Invalid, please enter only number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox.Text = string.Empty;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            User user = new User();
            int id = Convert.ToInt32(txtID.Text);
            string fname = txtfname.Text;
            string lname = txtlname.Text;
            string username = txtusername.Text;
            string password = txtpass.Text;

            MemoryStream pic = new MemoryStream();
         
             if (verif())
            {
                PictureBoxStudentImage.Image.Save(pic, PictureBoxStudentImage.Image.RawFormat);
                if (user.insertUser(id, fname, lname, username, password, pic))
                {
                    MessageBox.Show("New User Added", "Add User", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error", "Add User", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

            else
            {
                MessageBox.Show("Empty Fields", "Add User", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        bool verif()
        {
            if ((txtfname.Text.Trim() == "")
                        || (txtlname.Text.Trim() == "")
                        || (txtusername.Text.Trim() == "")
                        || (txtpass.Text.Trim() == "")
                        || (PictureBoxStudentImage.Image == null))
            {
                return false;
            }
            else
            {
                return true;
            }

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();

        }
    }
}
