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
                        sqlCommand.CommandText = "SELECT * FROM Employee";
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
                                    Birthday = Convert.ToDateTime(sqlDataReader["Birthday"])
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
        public void DeleteEmployees(string idValue)
        {
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {
                    sqlConnection.Open();
                    using (SqlCommand sqlCommand = new SqlCommand())
                    {
                        sqlCommand.Connection = sqlConnection;
                        sqlCommand.CommandText = $"DELETE FROM Employee WHERE Id={idValue}";
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
        public void AddEmployee(string firstname, string lastname, string phone, string email, DateTime birthday)
        {
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {
                    sqlConnection.Open();
                    using (SqlCommand sqlCommand = new SqlCommand())
                    {
                        sqlCommand.Connection = sqlConnection;
                        sqlCommand.CommandText = $"INSERT INTO Employee (Firstname, Lastname, Phone, Email, Birthday) VALUES (@firstname,@lastname,@phone,@email, @birthday)";
                        sqlCommand.Parameters.AddWithValue("@firstname", firstname);
                        sqlCommand.Parameters.AddWithValue("@lastname", lastname);
                        sqlCommand.Parameters.AddWithValue("@phone", phone);
                        sqlCommand.Parameters.AddWithValue("@email", email);
                        sqlCommand.Parameters.AddWithValue("@birthday", birthday);
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
        public void EditEmployee(string id, string firstname, string lastname, string phone, string email, DateTime birthday)
        {
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {
                    sqlConnection.Open();
                    using (SqlCommand sqlCommand = new SqlCommand())
                    {
                        sqlCommand.Connection = sqlConnection;
                        sqlCommand.CommandText = "UPDATE Employee SET Firstname=@firstname, Lastname=@lastname, Phone=@phone, Email=@email, Birthday=@birthday WHERE  Id=@id ";
                        sqlCommand.Parameters.AddWithValue("@id", id);
                        sqlCommand.Parameters.AddWithValue("@firstname", firstname);
                        sqlCommand.Parameters.AddWithValue("@lastname", lastname);
                        sqlCommand.Parameters.AddWithValue("@phone", phone);
                        sqlCommand.Parameters.AddWithValue("@email", email);
                        sqlCommand.Parameters.AddWithValue("@birthday", birthday);
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
        public int GetCount()
        {
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {
                    sqlConnection.Open();
                    using (SqlCommand sqlCommand = new SqlCommand())
                    {
                        sqlCommand.Connection = sqlConnection;
                        sqlCommand.CommandText = "SELECT COUNT(*) FROM Employee";
                        int rowCount = (int)sqlCommand.ExecuteScalar();   
                        sqlConnection.Close();
                        return rowCount;
                    }
                 
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Some error happend (Exception: {ex.Message})");
            }
        }
        public int GetAverage()
        {
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {
                    sqlConnection.Open();
                    using (SqlCommand sqlCommand = new SqlCommand())
                    {
                        sqlCommand.Connection = sqlConnection;
                        sqlCommand.CommandText = "SELECT AVG(DATEDIFF(YEAR, Birthday, CURRENT_TIMESTAMP)) FROM Employee";
                        int avgAge = (int)sqlCommand.ExecuteScalar();
                        sqlConnection.Close();
                        return avgAge;
                    }

                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Some error happend (Exception: {ex.Message})");
            }
        }
        public int GetMax()
        {
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {
                    sqlConnection.Open();
                    using (SqlCommand sqlCommand = new SqlCommand())
                    {
                        sqlCommand.Connection = sqlConnection;
                        sqlCommand.CommandText = "SELECT MAX(Birthday) FROM Employee";
                        DateTime getAge = Convert.ToDateTime(sqlCommand.ExecuteScalar());
                        int maxAge = DateTime.Now.Year - getAge.Year;

                        sqlConnection.Close();
                        return maxAge;
                    }

                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Some error happend (Exception: {ex.Message})");
            }
        }
        public int GetMin()
        {
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {
                    sqlConnection.Open();
                    using (SqlCommand sqlCommand = new SqlCommand())
                    {
                        sqlCommand.Connection = sqlConnection;
                        sqlCommand.CommandText = "SELECT MIN(Birthday) FROM Employee";
                        DateTime getAge = Convert.ToDateTime(sqlCommand.ExecuteScalar());
                        int maxAge = DateTime.Now.Year - getAge.Year;

                        sqlConnection.Close();
                        return maxAge;
                    }

                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Some error happend (Exception: {ex.Message})");
            }
        }
    }
}