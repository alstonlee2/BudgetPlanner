using BudgetPlanner.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BudgetPlanner.Configuration.Entities
{
    public class CategorySeed : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(c => c.CategoryId);
            builder.HasData(
                new Category
                {
                    
                    CategoryId = "1",
                    Name = "Groceries",
                    Description = "Expenses for food and household supplies"
                },
                new Category
                {
                     
                    CategoryId = "2",
                    Name = "Utilities",
                    Description = "Monthly utility bills such as electricity, water, and internet"
                },
                new Category
                {
                    
                    CategoryId = "3",
                    Name = "Transportation",
                    Description = "Costs related to commuting and travel"
                },
                new Category
                {
                    
                    CategoryId = "4",
                    Name = "Entertainment",
                    Description = "Expenses for leisure activities and hobbies"
                }
            );
        }
    }
}
