using Microsoft.EntityFrameworkCore;
using Model;

namespace DbLayer
{
    public class ApplicationContext : DbContext
    {
        public DbSet<User> Users { get; set; } = null!;
        public DbSet<Report> Reports { get; set; } = null!;

        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
                optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=WebReportDb;Username=postgres;Password=1111");
        }

        protected override void OnModelCreating(ModelBuilder model)
        {
            base.OnModelCreating(model);
            model.Entity<User>().HasData(
                new
                {
                    Id = 1,
                    Login = "Alex",
                    Password = "password1"
                },
                new
                {
                    Id = 2,
                    Login = "Mike",
                    Password = "password2"
                },
                new
                {
                    Id = 3,
                    Login = "Niki",
                    Password = "password3"
                });

        }
    }
}
