using SelfOrder.API.Repositories;

namespace SelfOrder.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MenuController(IMenuRepository _menuRepository, IMapper _mapper) : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetAllFoodsAsync()
        {
            var foodsDomain = await _menuRepository.GetAllAsync();

            var foodsDTO = _mapper.Map<List<Models.DTO.Food>>(foodsDomain);

            return Ok(foodsDTO);
        }

        [HttpPost]
        public async Task<IActionResult> AddFoodAsync([FromBody] Models.DTO.AddFoodRequest addFoodRequest)
        {

            var foodDomain = new Models.Domain.Food
            {
                Name = addFoodRequest.Name,
                Price = addFoodRequest.Price,
                ImageUrl = addFoodRequest.ImageUrl
            };

            foodDomain = await _menuRepository.AddAsync(foodDomain);

            var foodDTO = _mapper.Map<Models.DTO.Food>(foodDomain);

            return Ok(foodDTO);
        }

        [HttpPut]
        [Route("{id:int}")]
        public async Task<IActionResult> UpdateFoodAsync([FromRoute] int id, [FromBody] Models.DTO.UpdateFoodRequest updateFoodRequest)
        {
            var foodDomain = new Models.Domain.Food
            {
                Id = id,
                Name = updateFoodRequest.Name,
                Price = updateFoodRequest.Price,
                ImageUrl = updateFoodRequest.ImageUrl,
                MenuId = updateFoodRequest.MenuId,
                SubMenuId = updateFoodRequest.SubMenuId
            };

            foodDomain = await _menuRepository.UpdateAsync(foodDomain);

            if (foodDomain == null)
            {
                return NotFound();
            }

            var foodDTO = _mapper.Map<Models.DTO.Food>(foodDomain);

            return Ok(foodDTO);
        }
    }
}
