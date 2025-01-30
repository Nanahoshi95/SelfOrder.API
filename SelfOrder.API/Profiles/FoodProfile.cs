namespace SelfOrder.API.Profiles;

public class FoodProfile : Profile
{
    public FoodProfile()
    {
        CreateMap<Models.Domain.Food, Models.DTO.Food>()
            .ReverseMap();
    }
}
