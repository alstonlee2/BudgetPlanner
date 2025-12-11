using BudgetPlanner1.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BudgetPlanner1.Configurations.Entities
{
    public class CategorySeed : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(
                new Category
                {
                    Id = 1,
                    Name = "Food",
                    Description = "Expenses related to food and groceries",
                    UserId = 1
                },
                new Category
                {
                    Id = 2,
                    Name = "Transportation",
                    Description = "Expenses related to transportation and travel",
                    UserId = 1
                },
                new Category
                {
                    Id = 3,
                    Name = "Entertainment",
                    Description = "Expenses related to entertainment and leisure activities",
                    UserId = 1
                }
            );
        }
    }
}
