using HealthVault.Models.Northwind;

namespace HealthVault.Northwind
{
    public class MockNorthwindService : INorthwindService
    {
        public Task<List<CategoriesType>> GetCategories()
        {
            return Task.FromResult<List<CategoriesType>>(new());
        }
    }
}
