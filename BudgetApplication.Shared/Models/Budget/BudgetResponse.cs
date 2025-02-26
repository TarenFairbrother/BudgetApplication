namespace BudgetApplication.Shared.Models.Budget;

public class BudgetResponse
{
    public Guid BudgetId { get; set; }
    public string Name { get; set; } = string.Empty;
    public DateTime Month { get; set; }
}