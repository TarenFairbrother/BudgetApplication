namespace BudgetApplication.Shared.Models.Category;

public class CreateCategoryRequest
{
    public string CategoryName { get; set; } = string.Empty;
    public string CategoryDescription { get; set; } = string.Empty;
    public Guid BudgetId { get; set; }
}