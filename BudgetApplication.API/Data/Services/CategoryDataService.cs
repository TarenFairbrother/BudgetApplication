using BudgetApplication.API.Data.Services.Contracts;
using BudgetApplication.Shared.Entities;
using Microsoft.EntityFrameworkCore;

namespace BudgetApplication.API.Data.Services;

public class CategoryDataService : ICategoryDataService
{
    private readonly DataContext context;

    public CategoryDataService(DataContext context)
    {
        this.context = context;
    }
    public async Task<List<Category>> GetAllCategories()
    {
        return await this.context.Categories.ToListAsync();
    }

    public async Task<Category?> GetCategoryById(Guid id)
    {
        return await this.context.Categories.FirstOrDefaultAsync(c => c.CategoryId == id);
    }
    
    public async Task<List<Category>> CreateCategory(Category category)
    {
        this.context.Categories.Add(category);
        await this.context.SaveChangesAsync();
        
        return await this.context.Categories.ToListAsync();
    }
}