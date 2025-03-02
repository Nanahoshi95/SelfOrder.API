using SelfOrder.API.Models.Enums;

namespace SelfOrder.API.Models.Domain;

public class Food
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public int Price { get; set; }
    public string ImageUrl { get; set; } = null!;
    public MenuCategory MenuId { get; set; }
    public int SubMenuId { get; set; }
}