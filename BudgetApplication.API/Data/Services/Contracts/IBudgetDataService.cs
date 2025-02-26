using BudgetApplication.Shared.Entities;
using BudgetApplication.Shared.Models.Budget;

namespace BudgetApplication.API.Data.Services.Contracts;

public interface IBudgetDataService
{
    Task<List<Budget>> GetAllBudgets();
    Task<Budget?> GetBudgetById(Guid id);
    Task<List<Budget>> CreateBudget(Budget budget);
}