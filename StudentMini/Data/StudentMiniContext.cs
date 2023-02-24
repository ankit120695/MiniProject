using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using StudentMini.Model;

namespace StudentMini.Data
{
    public class StudentMiniContext : DbContext
    {
        public StudentMiniContext (DbContextOptions<StudentMiniContext> options)
            : base(options)
        {
        }

        public DbSet<StudentMini.Model.Student> Student { get; set; } = default!;
    }
}
