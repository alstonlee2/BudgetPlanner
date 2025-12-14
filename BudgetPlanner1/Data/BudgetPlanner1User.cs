using Microsoft.AspNetCore.Identity;

namespace BudgetPlanner1.Data
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class BudgetPlanner1User : IdentityUser
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
    }
}
