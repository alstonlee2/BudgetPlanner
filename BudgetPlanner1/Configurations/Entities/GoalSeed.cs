using BudgetPlanner1.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BudgetPlanner1.Configurations.Entities
{
    public class GoalSeed : IEntityTypeConfiguration<Goal>
    {
        public void Configure(EntityTypeBuilder<Goal> builder)
        {
            builder.HasData(
                new Goal
                {
                    Id = 1,
                    Name = "Emergency Fund",
                    Description = "Save $5000 for emergencies",
                    TargetAmount = 5000m,
                    UserId = 1
                },
                new Goal
                {
                    Id = 2,
                    Name = "Vacation",
                    Description = "Save $2000 for a vacation trip",
                    TargetAmount = 2000m,
                    UserId = 1
                },
                new Goal
                {
                    Id = 3,
                    Name = "New Laptop",
                    Description = "Save $1500 for a new laptop",
                    TargetAmount = 1500m,
                    UserId = 1
                }
            );
        }
    }
}
