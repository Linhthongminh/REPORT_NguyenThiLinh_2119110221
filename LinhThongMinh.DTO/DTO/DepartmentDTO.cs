using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinhThongMinh.DTO.DTO
{
    public class DepartmentDTO
    {
        public string ID_Department { get; set; }
        public string Name { get; set; }
        public List<EmployeeDTO> employees { get; set; }
    }
}