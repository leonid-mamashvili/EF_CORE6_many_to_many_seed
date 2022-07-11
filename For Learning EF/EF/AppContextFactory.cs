using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For_Learning_EF.EF
{
    public class AppContextFactory : IDesignTimeDbContextFactory<ApplicationContext>
    {
        public ApplicationContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationContext>();
            optionsBuilder.UseSqlServer("Data Source=localhost\\MSSQLSERVER01");

            return new ApplicationContext(optionsBuilder.Options);
        }
    }
}
