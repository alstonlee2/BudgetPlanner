using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BudgetPlanner1.Domain;
using BudgetPlanner1.Configurations.Entities;

namespace BudgetPlanner1.Data
{
    public class BudgetPlanner1Context : DbContext
    {
        public BudgetPlanner1Context (DbContextOptions<BudgetPlanner1Context> options)
            : base(options)
        {
        }

        public DbSet<BudgetPlanner1.Domain.Category> Category { get; set; } = default!;
        public DbSet<BudgetPlanner1.Domain.Expense> Expense { get; set; } = default!;
        public DbSet<BudgetPlanner1.Domain.Goal> Goal { get; set; } = default!;
        public DbSet<BudgetPlanner1.Domain.User> User { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new CategorySeed());
        }
    }
}
