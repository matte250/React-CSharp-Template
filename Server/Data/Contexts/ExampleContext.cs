using Microsoft.EntityFrameworkCore;
using ReactTemplate.Data.Models;

namespace ReactTemplate.Data.Contexts
{
    public class ExampleContext : DbContext
    {
        public ExampleContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<ExampleModel> ExampleModels { get; set; }
    }
}
