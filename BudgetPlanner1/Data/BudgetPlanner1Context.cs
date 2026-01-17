using BudgetPlanner1.Configurations.Entities; // ← your seed configurations
using BudgetPlanner1.Domain;                      // ← your domain models live here
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BudgetPlanner1.Data
{
    public class BudgetPlanner1Context : IdentityDbContext<BudgetPlanner1User>
    {
        public BudgetPlanner1Context(DbContextOptions<BudgetPlanner1Context> options)
            : base(options)
        {
        }

        // DbSets – use singular names by convention (EF will pluralize table names)
        public DbSet<Category> Categories { get; set; } = null!;
        public DbSet<Expense> Expenses { get; set; } = null!;
        public DbSet<Goal> Goals { get; set; } = null!;

        // IMPORTANT: Remove this line – you should NOT have a separate User entity anymore
        // public DbSet<BudgetPlanner1.Domain.User> User { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            // ────────────────────────────────────────────────────────────────
            // Fix decimal precision warnings (very important for money fields)
            // ────────────────────────────────────────────────────────────────
            builder.Entity<Expense>()
                .Property(e => e.Amount)
                .HasPrecision(18, 2);

            builder.Entity<Goal>()
                .Property(g => g.TargetAmount)
                .HasPrecision(18, 2);

            // ────────────────────────────────────────────────────────────────
            // Relationships – UserId is now string (matches IdentityUser.Id)
            // ────────────────────────────────────────────────────────────────
            builder.Entity<Goal>()
                .HasOne<BudgetPlanner1User>()
                .WithMany()
                .HasForeignKey(g => g.UserId)
                .OnDelete(DeleteBehavior.Restrict);   // or Cascade – your choice

            builder.Entity<Expense>()
                .HasOne<BudgetPlanner1User>()
                .WithMany()
                .HasForeignKey(e => e.UserId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<Category>()
                .HasOne<BudgetPlanner1User>()
                .WithMany()
                .HasForeignKey(c => c.UserId)
                .OnDelete(DeleteBehavior.Restrict);

            // Optional: Index on UserId for faster filtering
            builder.Entity<Goal>().HasIndex(g => g.UserId);
            builder.Entity<Expense>().HasIndex(e => e.UserId);
            builder.Entity<Category>().HasIndex(c => c.UserId);

            // ────────────────────────────────────────────────────────────────
            // Apply your seed configurations (keep these if you still need them)
            // ────────────────────────────────────────────────────────────────
            //builder.ApplyConfiguration(new CategorySeed());
            //builder.ApplyConfiguration(new GoalSeed());
            //builder.ApplyConfiguration(new ExpenseSeed());

            // Remove or comment out UserSeed if it seeds the old int-based User table
            // builder.ApplyConfiguration(new UserSeed());
        }
    }
}