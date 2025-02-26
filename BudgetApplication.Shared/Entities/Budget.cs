namespace BudgetApplication.Shared.Entities;

public class Budget
{
    public Guid BudgetId { get; set; }
    public string Name { get; set; } = string.Empty;
    public DateTime Month { get; set; }
    public List<Category> Categories { get; set; } = new List<Category>();
}