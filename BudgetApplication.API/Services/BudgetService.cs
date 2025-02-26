using BudgetApplication.API.Data.Services.Contracts;
using BudgetApplication.API.Services.Contracts;
using BudgetApplication.Shared.Entities;
using BudgetApplication.Shared.Models.Budget;
using Mapster;

namespace BudgetApplication.API.Services;

public class BudgetService : IBudgetService
{
    private readonly IBudgetDataService budgetDataService;

    public BudgetService(IBudgetDataService budgetDataService)
    {
        this.budgetDataService = budgetDataService;
    }

    public async Task<List<BudgetResponse>> GetAllBudgets()
    {
        var response = await budgetDataService.GetAllBudgets();
        return response.Adapt<List<BudgetResponse>>();
    }

    public async Task<BudgetResponse?> GetBudgetById(Guid id)
    {
        var response = await budgetDataService.GetBudgetById(id);
        return response?.Adapt<BudgetResponse>();
    }

    public async Task<List<BudgetResponse>> CreateBudget(CreateBudgetRequest request)
    {
        var budget = request.Adapt<Budget>();
        
        var result = await budgetDataService.CreateBudget(budget);
        return result.Adapt<List<BudgetResponse>>();
    }
}