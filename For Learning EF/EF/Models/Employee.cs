using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For_Learning_EF.Models
{
    public class Employee
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        public string FullName { get; set; }

        public DateTime CreatedDate { get; set; }

        public int Age { get; set; }
        [ForeignKey("EmployeeId")]
        public ICollection<DepartmentEmployee>? DepartmentEmployee { get; set; }
    }
}
