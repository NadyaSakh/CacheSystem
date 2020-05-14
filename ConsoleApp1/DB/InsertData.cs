using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;
using System.Data;
using System.Data.SqlClient;
using ConsoleApp1.SqlConn;

namespace ConsoleApp1
{
    class InsertData
    {
        public static void Insert()
        {
            SqlConnection connection = DBUtils.GetDBConnection();
            connection.Open();
            try
            {
                // Команда Insert.
                string sql = "Insert into Person (PersonID, FirstName, LastName, ModifiedDate) "
                                                 + " values (@personid, @firstname, @lastname, @modifieddate) ";

                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = sql;

                // Создать объект Parameter.
                SqlParameter personID = new SqlParameter("@personid", SqlDbType.Int);
                personID.Value = 4;
                cmd.Parameters.Add(personID);

                // Добавить параметр @firstname
                SqlParameter firstname = cmd.Parameters.Add("@firstname", SqlDbType.Text);
                firstname.Value = "nadya";

                // Добавить параметр @lastname
                cmd.Parameters.Add("@lastname", SqlDbType.Text).Value = "sakharova";
                cmd.Parameters.Add("@modifieddate", SqlDbType.Date).Value = "12.12.2012";

                // Выполнить Command (Используется для delete, insert, update).
                int rowCount = cmd.ExecuteNonQuery();

                Console.WriteLine("Row Count affected = " + rowCount);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e);
                Console.WriteLine(e.StackTrace);
            }
            finally
            {
                connection.Close();
                connection.Dispose();
                connection = null;
            }
        }
    }
}
