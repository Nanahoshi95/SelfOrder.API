
using SelfOrder.API.Models.Domain;

namespace SelfOrder.API.Repositories;

public class MenuRepository(SelfOrderDbContext _dbContext) : IMenuRepository
{
    public async Task<Food> AddAsync(Food food)
    {
        await _dbContext.Foods.AddAsync(food);
        await _dbContext.SaveChangesAsync();
        return food;
    }

    public async Task<IEnumerable<Food>> GetAllAsync()
    {
        return await _dbContext.Foods.ToListAsync();
    }

    public Task<Food> GetAsync(int menuCategory, int subMenuCategory)
    {
        throw new NotImplementedException();
    }
}
