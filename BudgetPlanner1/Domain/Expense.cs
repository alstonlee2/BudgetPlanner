namespace BudgetPlanner1.Domain
{
    public class Expense : BaseDomainModel
    {
        public string? Description { get; set; }
        public decimal Amount { get; set; }
        public DateTime ExpenseDate { get; set; }
        public int CategoryId { get; set; }
        public string UserId { get; set; } = null!;
        public int? GoalId { get; set; }   // FK to Goal.Id (still int)
        public Category? Category { get; set; }
    }

}
