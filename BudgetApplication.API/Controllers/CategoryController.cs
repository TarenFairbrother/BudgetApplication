using BudgetApplication.API.Services.Contracts;
using BudgetApplication.Shared.Models.Category;
using Microsoft.AspNetCore.Mvc;

namespace BudgetApplication.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CategoryController : ControllerBase
{

    private readonly ICategoryService categoryService;

    public CategoryController(ICategoryService categoryService)
    {
        this.categoryService = categoryService;
    }

    [HttpGet]
    public async Task<ActionResult<List<CategoryResponse>>> GetAllBudgets()
    {
        return Ok(await this.categoryService.GetAllCategories());
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<CategoryResponse>> GetCategoryById(Guid id)
    {
        var result = await this.categoryService.GetCategoryById(id);

        if (result == null)
        {
            return NotFound();
        }
        
        return Ok(result);
    }

    [HttpPost]
    public async Task<ActionResult<List<CategoryResponse>>> CreateCategory(CreateCategoryRequest request)
    {
        var result = await this.categoryService.CreateCategory(request);
        
        return Ok(result);
    }
}