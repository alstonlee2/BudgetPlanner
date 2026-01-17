namespace BudgetPlanner1.Domain
{
    public class Goal : BaseDomainModel
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public decimal TargetAmount { get; set; }
        public DateTime TargetDate { get; set; }
        public string UserId { get; set; } = null!;   // <-- string, required
    }
}