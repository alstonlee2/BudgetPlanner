using BudgetPlanner.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BudgetPlanner.Configuration.Entities
{
    public class GoalsSeed : IEntityTypeConfiguration<Goals>
    {
        public void Configure(EntityTypeBuilder<Goals> builder)
        {
            builder.HasData(
                new Goals
                {
                    
                    BudgetId = "1",
                    DateStart = new DateTime(2024, 1, 1),
                    DateEnd = new DateTime(2024, 6, 30)
                },
                new Goals
                {
                   
                    BudgetId = "2",
                    DateStart = new DateTime(2024, 2, 1),
                    DateEnd = new DateTime(2024, 7, 31)
                }
            );

        }
    }
}
