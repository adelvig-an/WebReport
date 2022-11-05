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
        public DbSet<Person> Persons { get; set; } = null!;
        public DbSet<PrivatePerson> PrivatePersons { get; set; } = null!;
        public DbSet<Director> Directors { get; set; } = null!;
        public DbSet<Organization> Organizations { get; set; } = null!;
        public DbSet<Customer> Customers { get; set; } = null!;
        public DbSet<Contact> Contacts { get; set; } = null!;

        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
                optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=WebReportDb;Username=postgres;Password=1111");
        }

        protected override void OnModelCreating(ModelBuilder model)
        {
            base.OnModelCreating(model);
            model.Entity<Person>().ToTable("Persons");
            model.Entity<PrivatePerson>().ToTable("PrivatePersons");
            model.Entity<Director>().ToTable("Directors");
            //model.Entity<Organization>().ToTable("Organizations");

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

            model.Entity<EvaluationTask>()
                .Property(e => e.Target)
                .HasConversion(v => v.ToString(),
                v => (TargetType)Enum.Parse(typeof(TargetType), v));
            model.Entity<Customer>()
                .Property(e => e.Customers)
                .HasConversion(v => v.ToString(),
                v => (CustomerType)Enum.Parse(typeof(CustomerType), v));
            model.Entity<Director>()
                .Property(e => e.PowerOfAttorney)
                .HasConversion(v => v.ToString(),
                v => (PowerOfAttorneyType)Enum.Parse(typeof(PowerOfAttorneyType), v));
        }
    }
}
