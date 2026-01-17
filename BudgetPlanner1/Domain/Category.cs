namespace BudgetPlanner1.Domain
{
    public class Category : BaseDomainModel
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string UserId { get; set; } = null;
    }
}