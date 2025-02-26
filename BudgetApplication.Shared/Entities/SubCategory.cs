namespace BudgetApplication.Shared.Entities;

public class SubCategory
{
    public Guid SubCategoryId { get; set; }
    public string Name { get; set; } = string.Empty;
    public double AssignedAmount { get; set; }
    public List<Transaction> Transactions { get; set; } = new List<Transaction>();

}