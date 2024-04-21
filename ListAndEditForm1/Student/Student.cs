using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ListAndEditForm1.CourseNScore;

namespace ListAndEditForm1
{
    class Student
    {
        MY_DB mydb = new MY_DB();
        
        public bool insertStudent(int Id, string fname, string lname, DateTime bdate, string email, string gender, string phone, string address, MemoryStream picture)
        {
            SqlCommand command = new SqlCommand("INSERT INTO std (id, fname, lname, bdate, email, gender, phone, address, picture)" +
             "VALUES (@id, @fn, @ln, @bdt, @mail, @gdr, @phn, @adrs, @pic)", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = Id;
            command.Parameters.Add("@fn", SqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@ln", SqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@bdt", SqlDbType.DateTime).Value = bdate;
            command.Parameters.Add("@mail", SqlDbType.VarChar).Value = email;
            command.Parameters.Add("@gdr", SqlDbType.VarChar).Value = gender;
            command.Parameters.Add("@phn", SqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@adrs", SqlDbType.VarChar).Value = address;
            command.Parameters.Add("@pic", SqlDbType.Image).Value = picture.ToArray();


            mydb.openConnection();
            if ((command.ExecuteNonQuery() == 1))
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            }
        }

        public bool InsertStudent(int Id, string fname,string lname, DateTime bdate, string mail, string gender, string phone, string address, MemoryStream picture)
        {
            SqlCommand command = new SqlCommand("INSERT INTO std (id, fname, lname, bdate, email, gender, phone, address, picture)" +
            "VALUES (@id, @fn, @ln, @bdt,@mail, @gdr, @phn, @adrs, @pic)", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = Id;
            command.Parameters.Add("@fn", SqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@ln", SqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@bdt", SqlDbType.VarChar).Value = mail;
            command.Parameters.Add("@bdt", SqlDbType.DateTime).Value = bdate;
            command.Parameters.Add("@gdr", SqlDbType.VarChar).Value = gender;
            command.Parameters.Add("@phn", SqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@adrs", SqlDbType.VarChar).Value = address;
            command.Parameters.Add("@pic", SqlDbType.Image).Value = picture.ToArray();


            mydb.openConnection();
            if ((command.ExecuteNonQuery() == 1))
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            }

        }
        public DataTable getStudents(SqlCommand command)
        {
            command.Connection = mydb.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public DataTable getStudents1(string command)
        {
            SqlCommand cmd = new SqlCommand(command, mydb.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }


        string execCount(string query)
        {
            SqlCommand command = new SqlCommand(query,mydb.getConnection);
            mydb.openConnection();
            String count = command.ExecuteScalar().ToString();
            mydb.closeConnection();
            return count;
        }
        public string totalStudent()
        {
            return execCount("SELECT COUNT (*) FROM STD");
        }
        public string totalMaleStudent()
        {
            return execCount("SELECT COUNT (*) FROM std where gender= 'Male'");
        }
        public string totalFemaleStudent()
        {
            return execCount("SELECT COUNT (*) FROM std where gender= 'Female'");
        }

        internal bool deleteStudent(int studentID)
        {
            throw new NotImplementedException();
        }

        public bool updateSelectedCourse(int studentID, string selectedcourse)
        {
            SqlCommand command = new SqlCommand("SELECT SelectedCourse FROM std WHERE id=@cid", mydb.getConnection);
            command.Parameters.Add("@cid", SqlDbType.Int).Value = studentID;

            mydb.openConnection();
            string currentCourses = command.ExecuteScalar().ToString();
            string updatedCourses = "";

            if (!currentCourses.Contains(selectedcourse))
            {
                updatedCourses = currentCourses + ", " + selectedcourse;
            }
            else
            {
                updatedCourses = currentCourses;
            }

            SqlCommand updateCommand = new SqlCommand("UPDATE std SET SelectedCourse = @selt WHERE id=@cid", mydb.getConnection);
            updateCommand.Parameters.Add("@cid", SqlDbType.Int).Value = studentID;
            updateCommand.Parameters.Add("@selt", SqlDbType.VarChar).Value = updatedCourses;

            if (updateCommand.ExecuteNonQuery() == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
