using BudgetApplication.Shared.Models.Category;

namespace BudgetApplication.API.Services.Contracts;

public interface ICategoryService
{
    Task<List<CategoryResponse>> GetAllCategories();
    Task<CategoryResponse?> GetCategoryById(Guid id);
    Task<List<CategoryResponse>> CreateCategory(CreateCategoryRequest request);
}