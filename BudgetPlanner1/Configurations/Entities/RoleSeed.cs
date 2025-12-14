using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BudgetPlanner1.Configurations.Entities
{
    public class RoleSeed : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(
                new IdentityRole
                {
                    Id = "cdd8a76d-4a32-454e-969a-a3c3edec3e93",
                    Name = "Admin",
                    NormalizedName = "ADMIN"
                },
                new IdentityRole
                {
                    Id = "fd3138d5-6fac-4ef5-aef0-36bdd1d63bf8",
                    Name = "User",
                    NormalizedName = "USER"
                }
            );
        }
    }
}
