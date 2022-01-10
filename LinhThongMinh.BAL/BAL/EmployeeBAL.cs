using LinhThongMinh.DAL.DAL;
using LinhThongMinh.DTO.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinhThongMinh.BAL.BAL
{
    public class EmployeeBAL
    {
        EmployeeDAL dal = new EmployeeDAL();
        public List<EmployeeDTO> ReadEmployee()
        {
            List<EmployeeDTO> employees = dal.ReadEmployee();
            return employees;
        }

        public void NewEmployee(EmployeeDTO employee)
        {
            dal.NewEmployee(employee);
        }

        public void DeleteEmployee(EmployeeDTO employee)
        {
            dal.DeleteEmployee(employee);
        }

        public void EditEmployee(EmployeeDTO employee)
        {
            dal.EditEmployee(employee);
        }
    }
}