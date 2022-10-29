using Microsoft.EntityFrameworkCore;
using Model;

namespace DbLayer
{
    public class ApplicationContext : DbContext
    {
        public DbSet<User> Users { get; set; } = null!;
        public DbSet<Report> Reports { get; set; } = null!;
        public DbSet<Contract> Contracts { get; set; } = null!;
        public DbSet<EvaluationTask> EvaluationTasks { get; set; } = null!;

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
            model.Entity<EvaluationTask>()
                .Property(e => e.Target)
                .HasConversion(v => v.ToString(),
                v => (TargetType)Enum.Parse(typeof(TargetType), v));
            model.Entity<EvaluationTask>()
                .Property(e => e.Customers)
                .HasConversion(v => v.ToString(),
                v => (CustomerType)Enum.Parse(typeof(CustomerType), v));
            model.Entity<EvaluationTask>().HasData(
                new
                {
                    Id = 1,
                    Number = 1235,
                    DateApplication = DateTime.UtcNow,
                    Target = TargetType.MarketValue,
                    IntendedUse = "Для принятия управленческих решений",
                    Customers = CustomerType.Organization
                },
                new
                {
                    Id = 2,
                    Number = 0540,
                    DateApplication = DateTime.UtcNow,
                    Target = TargetType.MarketAndLiquidationValue,
                    IntendedUse = "Для предоставления в банк",
                    Customers = CustomerType.PrivatePerson
                },
                new
                {
                    Id = 3,
                    Number = 0284,
                    DateApplication = DateTime.UtcNow,
                    Target = TargetType.MarketValue,
                    IntendedUse = "Для принятия управленческих решений",
                    Customers = CustomerType.PrivatePerson
                });
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
