using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace user_reg.Models
{
    public class RegDBContext: DbContext
    {
        public RegDBContext(DbContextOptions<RegDBContext> options):base(options)
        {

        }
        public DbSet<Registration> Registrations { get; set; }
    }
}
