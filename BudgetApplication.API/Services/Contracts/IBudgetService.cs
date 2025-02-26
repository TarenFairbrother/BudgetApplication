using BudgetApplication.Shared.Models.Budget;

namespace BudgetApplication.API.Services.Contracts;

public interface IBudgetService
{
    Task<List<BudgetResponse>> GetAllBudgets();
    Task<BudgetResponse?> GetBudgetById(Guid id);
    Task<List<BudgetResponse>> CreateBudget(CreateBudgetRequest request);
}