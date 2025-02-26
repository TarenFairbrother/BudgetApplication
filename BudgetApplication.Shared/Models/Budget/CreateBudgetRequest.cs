namespace BudgetApplication.Shared.Models.Budget;

public class CreateBudgetRequest
{
    public string Name { get; set; } = string.Empty;
    public DateTime Month { get; set; }
}