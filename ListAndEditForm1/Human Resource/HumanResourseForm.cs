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
    }
}
