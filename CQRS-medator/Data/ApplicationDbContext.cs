using CQRS_medator.Models;
using Microsoft.EntityFrameworkCore;

namespace CQRS_medator.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> optionse): base (optionse)
        {

        }

        public DbSet<Person> People { get; set; }
    }
}
