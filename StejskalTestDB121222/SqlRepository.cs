using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace StejskalTestDB121222
{
    public class SqlRepository
    {
        private string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=StejskalTestDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public List<Employee> GetEmployees()
        {
            List<Employee> employees = new List<Employee>();
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {
                    sqlConnection.Open();
                    using (SqlCommand sqlCommand = new SqlCommand())
                    {
                        sqlCommand.Connection = sqlConnection;
                        sqlCommand.CommandText = "select * from Employee";
                        using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
                        {
                            while (sqlDataReader.Read())
                            {
                                var employee = new Employee()
                                {
                                    Id = Convert.ToInt32(sqlDataReader["Id"]),
                                    Firstname = sqlDataReader["Firstname"].ToString(),
                                    Lastname = sqlDataReader["Lastname"].ToString(),
                                    Phone = sqlDataReader["Phone"].ToString(),
                                    Email = sqlDataReader["Email"].ToString(),
                                    //Birthday = Convert.ToDateTime(sqlDataReader["Birthday"])
                                };
                                employees.Add(employee);
                            }
                        }
                    }
                    sqlConnection.Close();
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Some error happend (Exception: {ex.Message})");
            }
            return employees;
        }
        public void RemoveEmployees(string idValue)
        {
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {
                    sqlConnection.Open();
                    using (SqlCommand sqlCommand = new SqlCommand())
                    {
                        sqlCommand.Connection = sqlConnection;
                        sqlCommand.CommandText = "DELETE FROM Employee WHERE Id=@Id";
                        sqlCommand.Parameters.AddWithValue("Id", idValue);
                        sqlCommand.ExecuteNonQuery();
                    }
                    sqlConnection.Close();
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Some error happend (Exception: {ex.Message})");
            }
        }
        public void AddEmployee(string firstname, string lastname, string phone, string email)
        {
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {
                    sqlConnection.Open();
                    using (SqlCommand sqlCommand = new SqlCommand())
                    {
                        sqlCommand.Connection = sqlConnection;
                        sqlCommand.CommandText = "INSERT INTO Employee (Firstname, Lastname, Phone, Email, Birthday) VALUES (@firstname,@lastname,@phone,@email, NULL)";
                        sqlCommand.Parameters.AddWithValue("@firstname", firstname);
                        sqlCommand.Parameters.AddWithValue("@lastname", lastname);
                        sqlCommand.Parameters.AddWithValue("@phone", phone);
                        sqlCommand.Parameters.AddWithValue("@email", email);
                        //sqlCommand.Parameters.AddWithValue("@birthday", birthday);
                        sqlCommand.ExecuteNonQuery();
                    }
                    sqlConnection.Close();
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Some error happend (Exception: {ex.Message})");
            }
        }
        public void EditEmployee(int id, string firstname, string lastname, string phone, string email)
        {
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {
                    sqlConnection.Open();
                    using (SqlCommand sqlCommand = new SqlCommand())
                    {
                        sqlCommand.Connection = sqlConnection;
                        sqlCommand.CommandText = "UPDATE Employee SET Firstname=@firtname, Lastname=@lastname, Phone=@phone, Email=@email, Birthday=NULL WHERE  Id=@id ";
                        sqlCommand.Parameters.AddWithValue("@id", id);
                        sqlCommand.Parameters.AddWithValue("@firstname", firstname);
                        sqlCommand.Parameters.AddWithValue("@lastname", lastname);
                        sqlCommand.Parameters.AddWithValue("@phone", phone);
                        sqlCommand.Parameters.AddWithValue("@email", email);
                        //sqlCommand.Parameters.AddWithValue("@birthday", birthday);
                        sqlCommand.ExecuteNonQuery();
                    }
                    sqlConnection.Close();
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Some error happend (Exception: {ex.Message})");
            }
        }
    }
}