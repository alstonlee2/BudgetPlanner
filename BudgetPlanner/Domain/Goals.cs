namespace BudgetPlanner.Domain
{
    public class Goals : BaseDomainModel
    {
        public string? GoalsId { get; set; }
        public string? BudgetId { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime DateEnd { get; set; } 
        = DateTime.Now; 
    }
}
