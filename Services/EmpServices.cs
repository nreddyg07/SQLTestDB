using System;
using System.Collections.Generic;
//using System.Data;
using Microsoft.Data.SqlClient;
using SQLTestDB.Data;
using SQLTestDB.Models;

namespace SQLTestDB.Services
{
    public class EmpServices
    {
        public void AddEmp(Employee emp)
        {
            using (SqlConnection con = SqlConn.GetConnection())
            {
                string query = "INSERT INTO Employee VALUES (@Name, @Email, @Dept, @Salary)";
                SqlCommand cmd=new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Name", emp.Name);
                cmd.Parameters.AddWithValue("@Email", emp.Email);
                cmd.Parameters.AddWithValue("@Dept", emp.Dept);
                cmd.Parameters.AddWithValue("@Salary", emp.Salary);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }
        public List<Employee> GetEmp()
        {
            List<Employee> list = new List<Employee>();
            using (SqlConnection con = SqlConn.GetConnection())
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM Employee", con);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(new Employee
                    {
                        EmpID = Convert.ToInt32(reader["EmpID"]),
                        Name = reader["Name"] as string ?? string.Empty,
                        Email = reader["Email"] as string ?? string.Empty,
                        Dept = reader["Dept"] as string ?? string.Empty,
                        Salary = Convert.ToDecimal(reader["Salary"])
                    });
                }
            }
            return list;
        }
        public void UpdateSalary(int empID, decimal Salary)
        {
            using (SqlConnection con = SqlConn.GetConnection())
            {
                string query = "UPDATE Employee SET Salary=@Salary WHERE EmpID=@Id";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Salary", Salary);
                cmd.Parameters.AddWithValue("@Id",empID);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }
        public void DeleteEmp(int empID)
        {
            using (SqlConnection con = SqlConn.GetConnection())
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM Employee WHERE EmpID=@Id", con);
                cmd.Parameters.AddWithValue("@Id", empID);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}