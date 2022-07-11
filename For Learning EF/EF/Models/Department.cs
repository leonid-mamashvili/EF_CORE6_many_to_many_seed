using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For_Learning_EF.Models
{
   
    public class Department
    {

        public Guid Id { get; set; } = Guid.NewGuid();

        public string Name { get; set; }

        public string? Description { get; set; }
        [ForeignKey("DepartmentId")]
        public ICollection<DepartmentEmployee>? DepartmentEmployee { get; set; }
    }
}
