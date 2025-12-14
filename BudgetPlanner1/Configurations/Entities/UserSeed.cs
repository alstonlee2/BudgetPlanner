using BudgetPlanner1.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BudgetPlanner1.Configurations.Entities
{
    public class UserSeed : IEntityTypeConfiguration<BudgetPlanner1User>
    {
        public void Configure(EntityTypeBuilder<BudgetPlanner1User> builder)
        {
            var hasher = new PasswordHasher<BudgetPlanner1User>();
            builder.HasData(
                new BudgetPlanner1User
                {
                    Id = "a19d3f30-f3ab-41da-b8fb-723d5f00a803",
                    Email = "admin@localhostPlan.com",
                    NormalizedEmail = "ADMIN@LOCALHOSTPLAN.COM",
                    FirstName = "Admin",
                    LastName = "User",
                    UserName = "admin@localhostPlan.com",
                    NormalizedUserName = "ADMIN@LOCALHOSTPLAN.COM",
                    PasswordHash = hasher.HashPassword(null, "Admin123!"),
                    EmailConfirmed = true
                }
                );
        }
    }
}
