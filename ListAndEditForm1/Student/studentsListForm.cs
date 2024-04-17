using Excel = Microsoft.Office.Interop.Excel;
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
using System.Runtime.InteropServices;
using System.Globalization;
using Microsoft.Office.Interop.Excel;

namespace ListAndEditForm1
{
    public partial class studentsListForm : Form
    {
        public studentsListForm()
        {
            InitializeComponent();
        }
        Student student = new Student();
        private System.Data.DataTable dataTable;
        private bool isImported = false;
        MY_DB MY_DB = new MY_DB();

        private void studentsListForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLSVDBDataSet5.std' table. You can move, or remove it, as needed.
           
            this.stdTableAdapter3.Fill(this.qLSVDBDataSet5.std);
            SqlCommand command = new SqlCommand("SELECT * FROM std");
            dataGridView1.ReadOnly = true;
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            dataGridView1.RowTemplate.Height = 80;
            dataGridView1.DataSource = student.getStudents(command);
            picCol = (DataGridViewImageColumn)dataGridView1.Columns[9];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dataGridView1.AllowUserToAddRows = false;
        }

        private void ButtonRefresh_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM std");
            dataGridView1.ReadOnly = true;
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            dataGridView1.RowTemplate.Height = 80;
            dataGridView1.DataSource = student.getStudents(command);
            picCol = (DataGridViewImageColumn)dataGridView1.Columns[9];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dataGridView1.AllowUserToAddRows = false;
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnimport_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFD = new OpenFileDialog();
            Microsoft.Office.Interop.Excel.Application xlApp = null;
            Workbook xlWorkbook = null;
            Worksheet xlWorksheet = null;
            Range xlRange = null;

            string strFilename;
            openFD.Filter = "Excel Office |*.xls; *.xlsx";
            openFD.ShowDialog();
            strFilename = openFD.FileName;

            if (strFilename != "")
            {
                try
                {
                    xlApp = new Microsoft.Office.Interop.Excel.Application();
                    xlWorkbook = xlApp.Workbooks.Open(strFilename);
                    xlWorksheet = xlWorkbook.Worksheets[1]; // Assuming the first sheet, change if needed
                    xlRange = xlWorksheet.UsedRange;

                    // Create a DataTable to hold the imported data
                    System.Data.DataTable dataTable = new System.Data.DataTable();

                    // Add columns to the DataTable
                    dataTable.Columns.Add("id");
                    dataTable.Columns.Add("fname");
                    dataTable.Columns.Add("lname");
                    dataTable.Columns.Add("bdate", typeof(DateTime)); // Specify the data type for the BirthDate column
                    dataTable.Columns.Add("email");
                    dataTable.Columns.Add("gender");
                    dataTable.Columns.Add("phone");
                    dataTable.Columns.Add("address");
                    dataTable.Columns.Add("SelectedCourse");
                    dataTable.Columns.Add("picture", typeof(byte[])); // Specify the data type for the Picture column

                    // Loop through Excel data and populate DataTable
                    for (int row = 1; row <= xlRange.Rows.Count; row++)
                    {
                        DataRow newRow = dataTable.NewRow();
                        for (int col = 1; col <= 9; col++) // Assuming 8 columns in Excel file
                        {
                            if (col == 4) // Handling BirthDate column
                            {
                                string dateFormat = "dd/MM/yyyy";
                                DateTime dateValue = DateTime.MinValue;
                                if (xlRange.Cells[row, col].Value != null && DateTime.TryParseExact(xlRange.Cells[row, col].Value.ToString(), dateFormat, CultureInfo.InvariantCulture, DateTimeStyles.None, out dateValue))
                                {
                                    newRow[col - 1] = dateValue; // Assign DateTime value directly
                                }
                            }
                            else if (col == 5)
                            {
                                string studentId = xlRange.Cells[row, 2].Value != null ? xlRange.Cells[row, 2].Value.ToString() : "";
                                newRow[col - 1] = studentId + "@student.hcmute.edu.vn";
                            }
                            else if (col == 10) // Handling Picture column
                            {
                                // You need to handle the image data here.
                                // If the Excel contains paths to image files, load the images and convert them to byte arrays.
                                // If the Excel contains byte array data for images, convert them accordingly.
                                // For now, let's assume the Picture column contains null values.
                                newRow[col - 1] = DBNull.Value;
                            }
                            else
                            {
                                newRow[col - 1] = xlRange.Cells[row, col].Value != null ? xlRange.Cells[row, col].Value.ToString() : "";
                            }
                        }
                        dataTable.Rows.Add(newRow);
                    }

                    // Bind the DataTable to the DataGridView
                    dataGridView1.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void dataGridView1_DoubleClick_1(object sender, EventArgs e)
        {
            
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=QLSVDB;Integrated Security=True;";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    if (dataGridView1.Rows.Count > 0)
                    {
                        foreach (DataRow row in ((System.Data.DataTable)dataGridView1.DataSource).Rows)
                        {
                            using (MemoryStream pic = new MemoryStream())
                            {
                                // Load picture data into MemoryStream
                                byte[] imageData = null;
                                if (row["picture"] != DBNull.Value)
                                {
                                    imageData = (byte[])row["picture"];
                                    pic.Write(imageData, 0, imageData.Length);
                                }

                                // Reset the position of the MemoryStream to the beginning
                                pic.Seek(0, SeekOrigin.Begin);

                                // Insert command
                                using (SqlCommand cmd = new SqlCommand("INSERT INTO std (id, fname, lname, bdate, email, gender, phone, address, SelectedCourse)" +
                                                                        "VALUES (@id, @fname, @lname, @bdate, @email, @gender, @phone, @address, @selt)", connection))
                                {
                                    cmd.Parameters.AddWithValue("@id", Convert.ToInt32(row["id"]));
                                    cmd.Parameters.AddWithValue("@fname", row["fname"].ToString());
                                    cmd.Parameters.AddWithValue("@lname", row["lname"].ToString());
                                    if (row["bdate"] != DBNull.Value)
                                    {
                                        cmd.Parameters.AddWithValue("@bdate", row["bdate"]);
                                    }
                                    else
                                    {
                                        cmd.Parameters.AddWithValue("@bdate", DBNull.Value);
                                    }

                                    cmd.Parameters.AddWithValue("@email", row["email"].ToString());
                                    cmd.Parameters.AddWithValue("@gender", row["gender"].ToString());
                                    cmd.Parameters.AddWithValue("@phone", row["phone"].ToString());
                                    cmd.Parameters.AddWithValue("@address", row["address"].ToString());
                                    cmd.Parameters.AddWithValue("@selt", row["SelectedCourse"].ToString());

                                    if (imageData != null)
                                    {
                                        cmd.Parameters.Add("@picture", SqlDbType.VarBinary, -1).Value = pic.ToArray();
                                    }
                                    else
                                    {
                                        // If imageData is null, set picture parameter value to DBNull
                                        cmd.Parameters.AddWithValue("@picture", DBNull.Value);
                                    }

                                    // Execute the command
                                    cmd.ExecuteNonQuery();

                                }
                            }
                        }
                        MessageBox.Show("Save Successfully", "SaveDB", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No data to Save database", "Save Database", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "SaveDB", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CurrentCellChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_DoubleClick_2(object sender, EventArgs e)
        {
            UpdateDeleteStudentForm upDestudent = new UpdateDeleteStudentForm();
            upDestudent.tb_id.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            upDestudent.tb_fname.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            upDestudent.tb_lname.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            upDestudent.dtP.Value = (DateTime)dataGridView1.CurrentRow.Cells[3].Value;
            if (dataGridView1.CurrentRow.Cells[5].Value.ToString().Trim() == "Female")
            {
                upDestudent.rb_Female.Checked = true;
            }
            else
            {
                upDestudent.rb_Male.Checked = true;
            }
            upDestudent.tb_Phone.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();

            upDestudent.richtb_address.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();


            // Check if the value is DBNull before casting
            if (dataGridView1.CurrentRow.Cells[9].Value != DBNull.Value)
            {
                byte[] pic = (byte[])dataGridView1.CurrentRow.Cells[9].Value;
                MemoryStream picture = new MemoryStream(pic);
                upDestudent.picUp.Image = Image.FromStream(picture);
            }

            upDestudent.Show();
        }
    }
}
