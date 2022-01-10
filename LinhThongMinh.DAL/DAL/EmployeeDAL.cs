using LinhThongMinh.DTO.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinhThongMinh.DAL.DAL
{
    public class EmployeeDAL : DBConnection
    {
        public List<EmployeeDTO> ReadEmployee()
        {
            SqlConnection conn = CreateConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Employee", conn);
            SqlDataReader reader = cmd.ExecuteReader();

            List<EmployeeDTO> employees = new List<EmployeeDTO>();
            DepartmentDAL departmentDAL = new DepartmentDAL();
            while (reader.Read())
            {
                EmployeeDTO employee = new EmployeeDTO();
                employee.Employee_ID = reader["Employee_ID"].ToString();
                employee.Employee_Name = reader["Employee_Name"].ToString();
                employee.DOB = reader["DOB"].ToString();
                employee.Gender = (bool)reader["Gender"];
                employee.POB = reader["POB"].ToString();
                employee.Department = departmentDAL.ReadDepartment(reader["Department_ID"].ToString());
                employees.Add(employee);
            }
            conn.Close();
            return employees;
        }

        public void EditEmployee(EmployeeDTO employee)
        {
            SqlConnection conn = CreateConnection();
            try
            {
                SqlCommand cmd = new SqlCommand("UPDATE Employee SET Employee_Name = @Employee_Name, DOB = @DOB, Gender = @Gender, POB = @POB, Department_ID = @Department_ID where Employee_ID = @Employee_ID", conn);
                cmd.Parameters.Add(new SqlParameter("@Employee_ID", employee.Employee_ID));
                cmd.Parameters.Add(new SqlParameter("@Employee_Name", employee.Employee_Name));
                cmd.Parameters.Add(new SqlParameter("@DOB", employee.DOB));
                cmd.Parameters.Add(new SqlParameter("@Gender", employee.Gender));
                cmd.Parameters.Add(new SqlParameter("@POB", employee.POB));
                cmd.Parameters.Add(new SqlParameter("@Department_ID", employee.Department.Department_ID));
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                Console.WriteLine("Successfully");
            }
            catch (Exception e)
            {
                Console.WriteLine("Something was wrong!" + e);
            }
            finally
            {
                conn.Close();
            }
        }

        public void DeleteEmployee(EmployeeDTO employee)
        {
            SqlConnection conn = CreateConnection();
            try
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM Employee WHERE Employee_ID = @Employee_ID", conn);
                cmd.Parameters.Add(new SqlParameter("@Employee_ID", employee.Employee_ID));

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                Console.WriteLine("Successfully");
            }
            catch (Exception e)
            {
                Console.WriteLine("Something was wrong!" + e);
            }
            finally
            {
                conn.Close();
            }
        }

        public void NewEmployee(EmployeeDTO employee)
        {
            SqlConnection conn = CreateConnection();
            try
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO Employee (Employee_ID, Employee_Name, DOB, Gender, POB, Department_ID) " +
                    "VALUES(@Employee_ID, @Employee_Name, @DOB, @Gender, @POB, @Department_ID)", conn);
                cmd.Parameters.Add(new SqlParameter("@Employee_ID", employee.Employee_ID));
                cmd.Parameters.Add(new SqlParameter("@Employee_Name", employee.Employee_Name));
                cmd.Parameters.Add(new SqlParameter("@DOB", employee.DOB));
                cmd.Parameters.Add(new SqlParameter("@Gender", employee.Gender));
                cmd.Parameters.Add(new SqlParameter("@POB", employee.POB));
                cmd.Parameters.Add(new SqlParameter("@Department_ID", employee.Department.Department_ID));

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                Console.WriteLine("Successfully");
            }
            catch (Exception e)
            {
                Console.WriteLine("Something was wrong!" + e);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}