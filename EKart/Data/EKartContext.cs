using EKart.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EKart.Data
{
    public class EKartContext :DbContext
    {
        public EKartContext(DbContextOptions<EKartContext>options):base(options)
        {
            
        }
        public DbSet<DegreeProgram> DegreePrograms { get; set; }
        public DbSet<YearLevel> YearLevels { get; set; }

        public DbSet<Student> Students { get; set; }
    }
}
