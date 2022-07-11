using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For_Learning_EF.Models
{
    public class User
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        public string UserName { get; set; }

        public DateTime CreatedDate { get; set; } = DateTime.Now;
    }
}
