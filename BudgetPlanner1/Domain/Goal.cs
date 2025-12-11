namespace BudgetPlanner1.Domain
{
    public class Goal : BaseDomainModel
    {
        public int GoalId { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public decimal TargetAmount { get; set; }
        public DateTime TargetDate { get; set; }
        public int UserId { get; set; }
    }
}
