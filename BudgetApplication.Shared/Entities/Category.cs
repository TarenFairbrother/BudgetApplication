namespace BudgetApplication.Shared.Entities;

public class Category
{
    public Guid CategoryId { get; set; }
    public string CategoryName { get; set; } = string.Empty;
    public string CategoryDescription { get; set; } = string.Empty;
    public List<SubCategory> SubCategories { get; set; } = new List<SubCategory>();
}