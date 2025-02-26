using BudgetApplication.Shared.Entities;
using Microsoft.EntityFrameworkCore;

namespace BudgetApplication.API.Data;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options) { }

    public DbSet<Budget> Budgets { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<SubCategory> SubCategories { get; set; }
    public DbSet<Transaction> Transactions { get; set; }
}