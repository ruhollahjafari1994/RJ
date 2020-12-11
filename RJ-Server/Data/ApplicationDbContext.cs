using Microsoft.EntityFrameworkCore;
 using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RJ_Server.Data
{
    public class ApplicationDbContext :DbContext
    {
        public ApplicationDbContext(DbContextOptions <ApplicationDbContext>options):base(options)
        {

        }
        public DbSet<RJ_Server.Models.UserDetails> UserDetails { get; set; }
        public DbSet<RJ_Server.Models.Act> Acts { get; set; }
    }
}
