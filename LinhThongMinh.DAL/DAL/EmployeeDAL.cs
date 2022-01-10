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
            SqlCommand cmd = new SqlCommand("SELECT * FROM Employee_2119110221", conn);
            SqlDataReader reader = cmd.ExecuteReader();

            List<EmployeeDTO> employees = new List<EmployeeDTO>();
            DepartmentDAL departmentDAL = new DepartmentDAL();
            while (reader.Read())
            {
                EmployeeDTO employee = new EmployeeDTO();
                employee.ID_Employee = reader["ID_Employee"].ToString();
                employee.Name = reader["Name"].ToString();
                employee.DateBirth = reader["DateBirth"].ToString();
                employee.Gender = (bool)reader["Gender"];
                employee.PlaceBirth = reader["PlaceBirth"].ToString();
                employee.ID_Department = departmentDAL.ReadDepartment(reader["ID_Department"].ToString());
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
                SqlCommand cmd = new SqlCommand("UPDATE Employee_2119110221 SET Name = @Name, DateBirth = @DateBirth, Gender = @Gender, PlaceBirth = @PlaceBirth, ID_Department = @ID_Department where ID_Employee = @ID_Employee", conn);
                cmd.Parameters.Add(new SqlParameter("@ID_Employee", employee.ID_Employee));
                cmd.Parameters.Add(new SqlParameter("@Name", employee.Name));
                cmd.Parameters.Add(new SqlParameter("@DateBirth", employee.DateBirth));
                cmd.Parameters.Add(new SqlParameter("@Gender", employee.Gender));
                cmd.Parameters.Add(new SqlParameter("@PlaceBirth", employee.PlaceBirth));
                cmd.Parameters.Add(new SqlParameter("@ID_Department", employee.ID_Department.ID_Department));
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
                SqlCommand cmd = new SqlCommand("DELETE FROM Employee_2119110221 WHERE ID_Employee = @ID_Employee", conn);
                cmd.Parameters.Add(new SqlParameter("@ID_Employee", employee.ID_Employee));

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
                SqlCommand cmd = new SqlCommand("INSERT INTO Employee_2119110221 (ID_Employee, Name, DateBirth, Gender, PlaceBirth, ID_Department) " +
                    "VALUES(@ID_Employee, @Name, @DateBirth, @Gender, @PlaceBirth, @ID_Department)", conn);
                cmd.Parameters.Add(new SqlParameter("@ID_Employee", employee.ID_Employee));
                cmd.Parameters.Add(new SqlParameter("@Name", employee.Name));
                cmd.Parameters.Add(new SqlParameter("@DateBirth", employee.DateBirth));
                cmd.Parameters.Add(new SqlParameter("@Gender", employee.Gender));
                cmd.Parameters.Add(new SqlParameter("@PlaceBirth", employee.PlaceBirth));
                cmd.Parameters.Add(new SqlParameter("@ID_Department", employee.ID_Department.ID_Department));

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