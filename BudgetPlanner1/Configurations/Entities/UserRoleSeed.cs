using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BudgetPlanner1.Configurations.Entities
{
    public class UserRoleSeed : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(
                new IdentityUserRole<string>
                {
                    UserId = "a19d3f30-f3ab-41da-b8fb-723d5f00a803",
                    RoleId = "cdd8a76d-4a32-454e-969a-a3c3edec3e93" // Admin Role
                }
            );
        }
    }
}
