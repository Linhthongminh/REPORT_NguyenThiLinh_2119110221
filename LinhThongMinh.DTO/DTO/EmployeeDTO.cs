using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinhThongMinh.DTO.DTO
{
    public class EmployeeDTO
    {
        public string ID_Employee { get; set; }
        public string Name { get; set; }
        public string DateBirth { get; set; }
        public bool Gender { get; set; }
        public string PlaceBirth { get; set; }
        public DepartmentDTO ID_Department { get; set; }
        public string Name_Department { get { return ID_Department.Name; } }
    }
}