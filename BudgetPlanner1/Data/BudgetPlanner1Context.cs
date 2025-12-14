using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using BudgetPlanner1.Data;
using BudgetPlanner1.Configurations.Entities;

namespace BudgetPlanner1.Data
{
    public class BudgetPlanner1Context(DbContextOptions<BudgetPlanner1Context> options) : IdentityDbContext<BudgetPlanner1User>(options)
    {
        public DbSet<BudgetPlanner1.Domain.Category> Category { get; set; } = default!;
        public DbSet<BudgetPlanner1.Domain.Expense> Expense { get; set; } = default!;
        public DbSet<BudgetPlanner1.Domain.Goal> Goal { get; set; } = default!;
        public DbSet<BudgetPlanner1.Domain.User> User { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new CategorySeed());
            builder.ApplyConfiguration(new GoalSeed());
            builder.ApplyConfiguration(new ExpenseSeed());
        }
    }


}
