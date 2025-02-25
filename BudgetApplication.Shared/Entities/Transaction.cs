namespace BudgetApplication.Shared.Entities;

public class Transaction
{
    public Guid TransactionId { get; set; }
    public double Amount { get; set; }
    public DateTime Date { get; set; }
    public double Inflow { get; set; }
    public double Outflow { get; set; }
    public SubCategory SubCategory { get; set; } = new SubCategory();
}