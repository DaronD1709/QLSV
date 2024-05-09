using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListAndEditForm1.Human_Resource
{
    internal class Group
    {
        private int id;
        private string name;
        private int userID;
        public int Id { get { return id; } set { id = value; } }

        public string Name { get { return name; } set { name = value; } }

        public int UserID { get { return userID; } set { userID = value; } }

        public DataTable GetGroups(int usrID)
        {
            MY_DB my_db = new MY_DB();
            SqlCommand cmd = new SqlCommand("Select * from Groups where userID = " + usrID, my_db.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }
        public DataTable GetGroups()
        {
            MY_DB my_db = new MY_DB();
            SqlCommand cmd = new SqlCommand("Select * from Groups", my_db.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }
        public bool AddGroup()
        {
            MY_DB my_db = new MY_DB();
            try
            {
                SqlCommand command = new SqlCommand("INSERT INTO Groups (ID, Name, UserID)" +
                " VALUES (@id, @name, @userid)", my_db.getConnection);
                command.Parameters.Add("@id", SqlDbType.Int).Value = Id;
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = Name;
                command.Parameters.Add("@userid", SqlDbType.Int).Value = UserID;
                my_db.openConnection();
                if (command.ExecuteNonQuery() == 1)
                {
                    my_db.closeConnection();
                    return true;
                }
                else
                {
                    my_db.closeConnection();
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool EditGroup()
        {
            MY_DB my_db = new MY_DB();

            try
            {
                SqlCommand command = new SqlCommand("UPDATE Groups SET Name = @name WHERE ID = @id", my_db.getConnection);
                command.Parameters.Add("@id", SqlDbType.Int).Value = Id;
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = Name;
                my_db.openConnection();
                if (command.ExecuteNonQuery() == 1)
                {
                    my_db.closeConnection();
                    return true;
                }
                else
                {
                    my_db.closeConnection();
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool DeleteGroup()
        {
            MY_DB my_db = new MY_DB();
            try
            {
                SqlCommand command = new SqlCommand("DELETE FROM Groups WHERE ID = @id", my_db.getConnection);
                command.Parameters.Add("@id", SqlDbType.Int).Value = Id;
                my_db.openConnection();
                if (command.ExecuteNonQuery() == 1)
                {
                    my_db.closeConnection();
                    return true;
                }
                else
                {
                    my_db.closeConnection();
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
