using BudgetApplication.API.Services.Contracts;
using BudgetApplication.Shared.Entities;
using BudgetApplication.Shared.Models;
using BudgetApplication.Shared.Models.Budget;
using Microsoft.AspNetCore.Mvc;

namespace BudgetApplication.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class BudgetController : ControllerBase
{
    private readonly IBudgetService budgetService;

    public BudgetController(IBudgetService budgetService)
    {
        this.budgetService = budgetService;
    }

    [HttpGet]
    public async Task<ActionResult<List<Budget>>> GetAllBudgets()
    {
        return Ok(await this.budgetService.GetAllBudgets());
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Budget>> GetBudget(Guid id)
    {
        var result = await this.budgetService.GetBudgetById(id);

        if (result == null)
        {
            return NotFound();
        }
        
        return Ok(result);
    }

    [HttpPost]
    public async Task<ActionResult<List<BudgetResponse>>> CreateBudget(CreateBudgetRequest request)
    {
        var budgets = await budgetService.CreateBudget(request);
        
         return Ok(budgets);
    }
}