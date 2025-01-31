
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

    public async Task<Food?> UpdateAsync(Food food)
    {
        var existingFood = await _dbContext.Foods.FindAsync(food.Id);

        if (existingFood == null)
        {
            return null;
        }

        existingFood.Name = food.Name;
        existingFood.Price = food.Price;
        existingFood.ImageUrl = food.ImageUrl;
        existingFood.MenuId = food.MenuId;
        existingFood.SubMenuId = food.SubMenuId;

        await _dbContext.SaveChangesAsync();

        return existingFood;
    }
}
