namespace BudgetPlanner.Domain
{
    public class Expense: BaseDomainModel
    {
        public string? ExpenseId { get; set; }
        public decimal Amount { get; set; }
        public DateTime DateIncurred { get; set; }
        public string? Description { get; set; }

        public string? GoalsId { get; set; }
        public Goals? Goals { get; set; }
        public string? CategoryId { get; set; }
        public Category? Category { get; set; }
    }
}
