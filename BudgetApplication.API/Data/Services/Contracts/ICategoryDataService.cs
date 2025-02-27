using BudgetApplication.Shared.Entities;

namespace BudgetApplication.API.Data.Services.Contracts;

public interface ICategoryDataService
{
    Task<List<Category>> CreateCategory(Category category);
    Task<List<Category>> GetAllCategories();
    Task<Category?> GetCategoryById(Guid id);
}