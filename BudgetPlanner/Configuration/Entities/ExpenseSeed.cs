using BudgetPlanner.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BudgetPlanner.Configuration.Entities
{
    public class ExpenseSeed : IEntityTypeConfiguration<Expense>
    {
        public void Configure(EntityTypeBuilder<Expense> builder)
        {
            builder.HasData(
                new Expense
                {
                    ExpenseId = "1",
                    GoalsId = "1",
                    CategoryId = "-1",
                    Amount = 150.00m,
                    DateIncurred = new DateTime(2024, 1, 15),
                    Description = "Grocery shopping"
                },
                new Expense
                {
                    ExpenseId = "2",
                    GoalsId = "1",
                    CategoryId = "-2",
                    Amount = 75.50m,
                    DateIncurred = new DateTime(2024, 1, 20),
                    Description = "Electricity bill"
                },
                new Expense
                {
                    ExpenseId = "3",
                    GoalsId = "2",
                    CategoryId = "-1",
                    Amount = 200.00m,
                    DateIncurred = new DateTime(2024, 2, 10),
                    Description = "Monthly groceries"
                }
            );
        }
    }
}
