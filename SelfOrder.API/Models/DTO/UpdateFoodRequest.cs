using System;
using SelfOrder.API.Models.Enums;

namespace SelfOrder.API.Models.DTO;

public class UpdateFoodRequest
{
    public string Name { get; set; } = null!;
    public int Price { get; set; }
    public string ImageUrl { get; set; } = null!;
    public MenuCategory MenuId { get; set; }
    public int SubMenuId { get; set; }
}
