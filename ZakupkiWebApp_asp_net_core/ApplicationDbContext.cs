using Microsoft.EntityFrameworkCore;
using ZakupkiWebApp_asp_net_core.Models;

namespace ZakupkiWebApp_asp_net_core
{
    public class ApplicationDbContext: DbContext
    {
        public DbSet<Contact> Contacts_feedback { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            IConfiguration configuration = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .Build();

            optionsBuilder.UseNpgsql(configuration.GetConnectionString("DefaultConnection"));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Contact>().ToTable("feedback"); // указывается таблица БД
        }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
        {
            // Добавьте DbSet для ваших моделей здесь
            // public DbSet<YourModel> YourModels { get; set; }
        }

        public ApplicationDbContext()
        {
        }
    }
}
