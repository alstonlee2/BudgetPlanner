namespace BudgetPlanner.Domain
{
    public class Category : BaseDomainModel
    {
        public string? CategoryId { get; set; } 
        public string? Name { get; set; } 
        public string? Description { get; set; } = null;
    }
}
