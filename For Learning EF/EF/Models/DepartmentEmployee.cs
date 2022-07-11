using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For_Learning_EF.Models
{
    public class DepartmentEmployee
    {
        public Guid EmployeeId { get; set; }
        public Guid DepartmentId { get; set; }
        
        public Employee Employee { get; set; }   
        public Department Department { get; set; }
    }
}
