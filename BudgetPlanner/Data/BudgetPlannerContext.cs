using Microsoft.EntityFrameworkCore;
using BudgetPlanner.Domain;
using BudgetPlanner.Configuration.Entities;

namespace BudgetPlanner.Data
{
    public class BudgetPlannerContext : DbContext
    {
        public BudgetPlannerContext (DbContextOptions<BudgetPlannerContext> options)
            : base(options)
        {
        }

        public DbSet<User> User { get; set; } = default!; 
        public DbSet<Category> Category { get; set; } = default!;
        public DbSet<Expense> Expense { get; set; } = default!;
        public DbSet<Goals> Goals { get; set; } = default!;


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new GoalsSeed());
            builder.ApplyConfiguration(new CategorySeed());
            builder.ApplyConfiguration(new ExpenseSeed());
        }
    }
}
