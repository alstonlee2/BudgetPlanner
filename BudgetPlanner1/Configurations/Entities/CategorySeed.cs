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
                    Id = -1,
                    Name = "Food",
                    Description = "Expenses related to food and groceries",
                    UserId = "fd3138d5-6fac-4ef5-aef0-36bdd1d63bf8"

                },
                new Category
                {
                    Id = -2,
                    Name = "Transportation",
                    Description = "Expenses related to transportation and travel",
                    UserId = "fd3138d5-6fac-4ef5-aef0-36bdd1d63bf8"

                },
                new Category
                {
                    Id = -3,
                    Name = "Entertainment",
                    Description = "Expenses related to entertainment and leisure activities",
                    UserId = "fd3138d5-6fac-4ef5-aef0-36bdd1d63bf8"
                }
            );
        }
    }
}
