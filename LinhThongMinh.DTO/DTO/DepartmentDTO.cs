using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinhThongMinh.DTO.DTO
{
    public class DepartmentDTO
    {
        public string Department_ID { get; set; }
        public string Department_Name { get; set; }
        public List<EmployeeDTO> employees { get; set; }
    }
}