namespace BudgetPlanner1.Domain
{
    public class Category : BaseDomainModel
    {
        public int CategoryId { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public int UserId { get; set; }

    }
}
