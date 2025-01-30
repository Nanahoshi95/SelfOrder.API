using System;

namespace SelfOrder.API.Models.DTO;

public class AddFoodRequest
{
    public string Name { get; set; } = null!;
    public int Price { get; set; }
    public string ImageUrl { get; set; } = null!;
}
