using Microsoft.EntityFrameworkCore;

namespace ZakupkiWebApp_asp_net_core
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
        {
            // Добавьте DbSet для ваших моделей здесь
            // public DbSet<YourModel> YourModels { get; set; }
        }
    }
}
