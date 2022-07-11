using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nav.EntityContext
{
    public class PersonContextFactory : IDesignTimeDbContextFactory<PersonDbContext>
    {
        public PersonDbContext CreateDbContext(string[] args)
        {
            DbContextOptions options = new DbContextOptionsBuilder().UseSqlite("Data Source=person.db").Options;
            return new PersonDbContext(options);
        }
    }
}
