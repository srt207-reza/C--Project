using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace MySoftWare
{
    sealed class SaleItem : ISaleItem
    {
        private string connect = "Data Source = .;Initial Catalog = DB_Sale;Integrated Security = true";
        public DataTable SelectRowItem(int UserId)
        {
            string query = $"Select * From Tbl_Item Where UserId = {UserId}";
            SqlConnection connection = new SqlConnection(connect);
            SqlDataAdapter adapter = new SqlDataAdapter(query,connection);
            DataTable data = new DataTable();
            adapter.Fill(data);
            return data;
        }

        public DataTable SelectAllItem()
        {
            string query = "Select * From Tbl_Item";
            SqlConnection connection = new SqlConnection(connect);
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable data = new DataTable();
            adapter.Fill(data);
            return data;
        }

        public bool InsertNewData(string name, string family, string username, string password, string phonenumber, string gmail, string region, string sourceid)
        {
            SqlConnection connection = new SqlConnection(connect);
            try
            {
                string query = "Insert Into Tbl_PeopleData (Name,Family,UserName,Password,PhoneNumber,Gmail,Region,SourceId) Values (@Name,@Family,@UserName,@Password,@PhoneNumber,@Gmail,@Region,@SourceId)";
                SqlCommand command = new SqlCommand(query,connection);
                command.Parameters.AddWithValue("@Name", name);
                command.Parameters.AddWithValue("@Family", family);
                command.Parameters.AddWithValue("@UserName", username);
                command.Parameters.AddWithValue("@Password", password);
                command.Parameters.AddWithValue("@PhoneNumber", phonenumber);
                command.Parameters.AddWithValue("@Gmail", gmail);
                command.Parameters.AddWithValue("@Region", region);
                command.Parameters.AddWithValue("@SourceId", sourceid);
                connection.Open();
                command.ExecuteNonQuery();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                connection.Close();
            }
        }

        public bool CheckUsers(string name, string password)
        {
            SqlConnection connection = new SqlConnection(connect);
            try
            {
                string query = "Select * from Tbl_PeopleData where Name=@Name or Password=@Password";
                SqlCommand command = new SqlCommand(query,connection);
                command.Parameters.AddWithValue("@Name",name);
                command.Parameters.AddWithValue("@Password",password);
                connection.Open();
                command.ExecuteNonQuery();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                connection.Close();
            }

        }

        public DataTable SelectAllProduct()
        {
            string query = "Select * From Tbl_Product";
            SqlConnection connection = new SqlConnection(connect);
            SqlDataAdapter adapter = new SqlDataAdapter(query,connection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
    }
}
