using CQRSAndMediatR.Models;
using Microsoft.EntityFrameworkCore;

namespace CQRSAndMediatR.Data
{
    public class DbContextClass : DbContext
    {
        public DbContextClass(DbContextOptions<DbContextClass> options) : base(options)
        {
        }
        public DbSet<StudentDetails> Students { get; set; }
    }
}
