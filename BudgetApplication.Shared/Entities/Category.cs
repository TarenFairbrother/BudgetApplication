namespace BudgetApplication.Shared.Entities;

public class Category
{
    public Guid CategoryId { get; set; }
    public string CategoryName { get; set; } = string.Empty;
    public string CategoryDescription { get; set; } = string.Empty;
    public Guid? BudgetId { get; set; }
    public Budget? Budget { get; set; }
    public List<SubCategory> SubCategories { get; set; } = new List<SubCategory>();
}