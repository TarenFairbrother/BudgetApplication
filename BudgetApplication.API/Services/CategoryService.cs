using BudgetApplication.API.Data.Services.Contracts;
using BudgetApplication.API.Services.Contracts;
using BudgetApplication.Shared.Entities;
using BudgetApplication.Shared.Models.Category;
using Mapster;

namespace BudgetApplication.API.Services;

public class CategoryService : ICategoryService
{
    private readonly ICategoryDataService categoryDataService;

    public CategoryService(ICategoryDataService categoryDataService)
    {
        this.categoryDataService = categoryDataService;
    }

    public async Task<List<CategoryResponse>> GetAllCategories()
    {
        var response = await this.categoryDataService.GetAllCategories();
        return response.Adapt<List<CategoryResponse>>();
    }

    public async Task<CategoryResponse?> GetCategoryById(Guid id)
    {
        var response = await this.categoryDataService.GetCategoryById(id);
        return response?.Adapt<CategoryResponse>();
    }

    public async Task<List<CategoryResponse>> CreateCategory(CreateCategoryRequest request)
    {
        var category = request.Adapt<Category>();
        
        var response= await this.categoryDataService.CreateCategory(category);
        return response.Adapt<List<CategoryResponse>>();
    }
}