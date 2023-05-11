using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    internal class Context: DbContext
    {
        public DbSet<User> Users { get; set; }

        public DbSet<Movie> Movies { get; set; }
        public DbSet<Admin> Admins { get; set; }

        public DbSet<HallStaff> HallStaffs { get; set; }
        public DbSet<AdminToken> AdminTokens { get; set; }

        public DbSet<Hall> Halls { get; set; }

        public DbSet<Circular> Circulars { get; set; }
    }
}
