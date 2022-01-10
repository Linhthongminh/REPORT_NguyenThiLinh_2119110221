using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinhThongMinh.DTO.DTO
{
    public class EmployeeDTO
    {
        public string Employee_ID { get; set; }
        public string Employee_Name { get; set; }
        public string DOB { get; set; }
        public bool Gender { get; set; }
        public string POB { get; set; }
        public DepartmentDTO Department { get; set; }
        public string Department_Name { get { return Department.Department_Name; } }
    }
}