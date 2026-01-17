using BudgetPlanner1.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BudgetPlanner1.Configurations.Entities
{
    public class ExpenseSeed : IEntityTypeConfiguration<Expense>
    {
        public void Configure(EntityTypeBuilder<Expense> builder)
        {
            builder.HasData(
                new Expense
                {
                    Id = -1,
                    Amount = 50.75m,
                    ExpenseDate = new DateTime(2024, 1, 15),
                    Description = "Grocery shopping",
                    CategoryId = 1,
                    UserId = "fd3138d5-6fac-4ef5-aef0-36bdd1d63bf8"
                },
                new Expense
                {
                    Id = -2,
                    Amount = 20.00m,
                    ExpenseDate = new DateTime(2024, 1, 16),
                    Description = "Bus fare",
                    CategoryId = 2,
                    UserId = "fd3138d5-6fac-4ef5-aef0-36bdd1d63bf8"
                },
                new Expense
                {
                    Id = -3,
                    Amount = 100.00m,
                    ExpenseDate = new DateTime(2024, 1, 17),
                    Description = "Concert tickets",
                    CategoryId = 3,
                    UserId = "fd3138d5-6fac-4ef5-aef0-36bdd1d63bf8"
                }
            );
        }
    }
}
