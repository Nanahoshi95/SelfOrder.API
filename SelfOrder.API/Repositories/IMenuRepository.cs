using SelfOrder.API.Models.Domain;

namespace SelfOrder.API.Repositories;

public interface IMenuRepository
{
    Task<IEnumerable<Food>> GetAllAsync();

    Task<Food> GetAsync(int menuCategory, int subMenuCategory);

    Task<Food> AddAsync(Food food);

    Task<Food?> UpdateAsync(Food food);
}