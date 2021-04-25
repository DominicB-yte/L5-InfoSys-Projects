using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFFirstCode
{
    public class PersonContext : DbContext
    {
        public DbSet<Person> People { get; set; }
    }
}
