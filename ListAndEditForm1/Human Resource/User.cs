using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListAndEditForm1.Human_Resource
{
    internal class User
    {
        MY_DB mydb = new MY_DB();


        public bool insertUser(int Id, string fname, string lname, string username, string pass, MemoryStream picture)
        {
            SqlCommand command = new SqlCommand("INSERT INTO loginhuman (Id, f_name, l_name, uname, pwd, fig)" +
             "VALUES (@id, @fn, @ln, @usern, @pass, @pic)", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = Id;
            command.Parameters.Add("@fn", SqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@ln", SqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@usern", SqlDbType.VarChar).Value = username;
            command.Parameters.Add("@pass", SqlDbType.VarChar).Value = pass;
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


    }
}
