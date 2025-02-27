using BudgetApplication.API.Data.Services.Contracts;
using BudgetApplication.Shared.Entities;
using BudgetApplication.Shared.Models.Budget;
using Microsoft.EntityFrameworkCore;

namespace BudgetApplication.API.Data.Services;

public class BudgetDataService : IBudgetDataService
{
    private readonly DataContext context;

    public BudgetDataService(DataContext context)
    {
        this.context = context;
    }

    public async Task<List<Budget>> GetAllBudgets()
    {
        return await context.Budgets
            .Include(budget => budget.Categories)
            .ToListAsync();
    }

    public async Task<Budget?> GetBudgetById(Guid id)
    {
        return await this.context.Budgets.FirstOrDefaultAsync(b => b.BudgetId == id);
    }

    public async Task<List<Budget>> CreateBudget(Budget budget)
    {
        this.context.Budgets.Add(budget);
        await this.context.SaveChangesAsync();

        return await this.context.Budgets.ToListAsync();
    }
}