using HealthVault.Models.Northwind;

namespace HealthVault.Northwind
{
    public interface INorthwindService
    {
        Task<List<CategoriesType>> GetCategories();
    }
}
