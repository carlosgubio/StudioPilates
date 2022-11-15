using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using StudioPilates.Models;

namespace StudioPilates.Data
{
    public class StudioPilatesContext :IdentityDbContext<AppUser>
    {
        public StudioPilatesContext(DbContextOptions<StudioPilatesContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Address> Address { get; set; }
        public DbSet<Customer_payment> Customer_Payments { get; set; }
        public DbSet<Customer_plan> Customer_plans { get; set; }
        public DbSet<Customer_question_response> Customer_Question_Responses { get; set; }
        public DbSet<Plan> Plans { get; set; }
        public DbSet<Question> Questions { get; set; }
    }
}
