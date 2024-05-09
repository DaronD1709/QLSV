using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Net.WebRequestMethods;
using System.IO;

namespace ListAndEditForm1.CourseNScore
{
    public partial class AddCourseFr : Form
    {
        MY_DB mydb = new MY_DB();
        private SqlConnection connection;
        private SqlCommand command;
        public int studentid;



        public AddCourseFr()
        {
            InitializeComponent();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            System.Windows.Forms.TextBox textBox = sender as System.Windows.Forms.TextBox;
            if (!string.IsNullOrEmpty(textBox.Text))
            {
                if (!int.TryParse(textBox.Text, out _))
                {
                    MessageBox.Show("Invalid, please enter only number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox.Text = string.Empty;
                }
            }
        }

        private void AddCourseFr_Load(object sender, EventArgs e)
        {
            txtstdid.Text = studentid.ToString();
        }



        private void InitializeDatabase()
        {
            string connectionString = "YourConnectionString";
            connection = new SqlConnection(connectionString);
            command = new SqlCommand();
            command.Connection = connection;
            try
            {
                connection.Open();
                // Create table if not exists
                command.CommandText = @"CREATE TABLE IF NOT EXISTS ComboData (
                                            ComboValue NVARCHAR(50),
                                            TextValue NVARCHAR(255)
                                        )";
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error initializing database: " + ex.Message);
            }
        }

        private void PopulateComboBox()
        {
            try
            {
                // Populate combo box with values from database
                command.CommandText = "SELECT ComboValue FROM ComboData";
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    selectcombox.Items.Add(reader["ComboValue"].ToString());
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error populating combo box: " + ex.Message);
            }
        }

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                // Retrieve text value corresponding to the selected combo value
                command.CommandText = "SELECT TextValue FROM ComboData WHERE ComboValue = @ComboValue";
                command.Parameters.Clear();
                command.Parameters.AddWithValue("@ComboValue", selectcombox.SelectedItem.ToString());
                string textValue = command.ExecuteScalar()?.ToString() ?? "";
                availablebox.Text = textValue;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving text value: " + ex.Message);
            }
        }

        private void selectcombox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedValue = selectcombox.SelectedItem.ToString();
            string command1 = "SELECT label FROM Course WHERE semester = 1";
            string command2 = "SELECT label FROM Course WHERE semester = 2";
            string command3 = "SELECT label FROM Course WHERE semester = 3";
            Course course = new Course();
            switch (selectedValue)
            {
                case "1":
                    {
                        availablebox.Items.Clear();
                        DataTable table = (course.getlabelCourses(command1));
                        for (int i = 0; i < table.Rows.Count; i++)
                        {
                            availablebox.Items.Add(table.Rows[i]["label"].ToString());
                        }
                    }
                    break;
                case "2":
                    {
                        availablebox.Items.Clear();
                        DataTable table = (course.getlabelCourses(command2));
                        for (int i = 0; i < table.Rows.Count; i++)
                        {
                            availablebox.Items.Add(table.Rows[i]["label"].ToString());
                        }
                    }
                    break;
                case "3":
                    {
                        availablebox.Items.Clear();
                        DataTable table = (course.getlabelCourses(command3));
                        for (int i = 0; i < table.Rows.Count; i++)
                        {
                            availablebox.Items.Add(table.Rows[i]["label"].ToString());
                        }
                    }
                    break;



            }
        }

        private void selectedbox_SelectedIndexChanged(object sender, EventArgs e)
        { 

            


        }

        Student student = new Student();
        private void button2_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtstdid.Text);

            if (student.updateSelectedCourse(id, store))
            {
                MessageBox.Show("Selected Course Updated", "Edit Course", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            else
            {
                MessageBox.Show("Course Not Updated", "Edit Course", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        private int i;
        private string item;
        private string store;
        private void button1_Click(object sender, EventArgs e)
        {
            int n = availablebox.SelectedItems.Count; //Tong so muc duoc chon for(int i=0;i<=n-1; i++)
            item = availablebox.SelectedItem.ToString();
            store = store + ", " + item;


            selectedbox.Items.Add(availablebox.SelectedItems[i].ToString()); for (int j = n - 1; j >= 0; j--)

                availablebox.Items.RemoveAt(j);


        }

        private void button3_Click(object sender, EventArgs e)
        {
            Student student = new Student();
            string command1 = "SELECT SelectedCourse FROM std WHERE id =" + txtstdid.Text + "";
            string command2 = "SELECT Course FROM Course WHERE semester = 2";
            string command3 = "SELECT Course FROM Course WHERE semester = 3";
            Course course = new Course();
            selectedbox.Items.Clear();
            DataTable table = (student.getStudents1(command1));
            for (int i = 0; i < table.Rows.Count; i++)
            {
                selectedbox.Items.Add(table.Rows[i]["SelectedCourse"].ToString());
            }
        }
    }
}

