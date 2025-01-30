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




        // [HttpGet]
        // [Authorize(Roles = "reader")]
        // public async Task<IActionResult> GetAllWalksAsync()
        // {
        //     // Fetch data from database - domain walks
        //     var walksDomain = await walkRepository.GetAllAsync();

        //     // Convert domain walks to DTO Walks
        //     var walksDTO = mapper.Map<List<Models.DTO.Walk>>(walksDomain);

        //     // Return response
        //     return Ok(walksDTO);
        // }

        // [HttpGet]
        // [Route("{id:guid}")]
        // [ActionName("GetWalkAsync")]
        // [Authorize(Roles = "reader")]
        // public async Task<IActionResult> GetWalkAsync(Guid id)
        // {
        //     // Get Walk Domain object from database
        //     var walkDomin = await walkRepository.GetAsync(id);

        //     // Convert Domain object to DTO
        //     var walkDTO = mapper.Map<Models.DTO.Walk>(walkDomin);

        //     // Return response
        //     return Ok(walkDTO);
        // }

        // [HttpPost]
        // [Authorize(Roles = "writer")]
        // public async Task<IActionResult> AddWalkAsync([FromBody] Models.DTO.AddWalkRequest addWalkRequest)
        // {
        //     // Validate the incoming request
        //     if (!(await ValidateAddWalkAsync(addWalkRequest)))
        //     {
        //         return BadRequest(ModelState);
        //     }

        //     // Convert DTO to Domain Object
        //     var walkDomain = new Models.Domain.Walk
        //     {
        //         Length = addWalkRequest.Length,
        //         Name = addWalkRequest.Name,
        //         RegionId = addWalkRequest.RegionId,
        //         WalkDifficultyId = addWalkRequest.WalkDifficultyId
        //     };

        //     // Pass domain object to Repository to persist this
        //     walkDomain = await walkRepository.AddAsync(walkDomain);

        //     // Convert the Domain object back to DTO
        //     var walkDTO = new Models.DTO.Walk
        //     {
        //         Id = walkDomain.Id,
        //         Length = walkDomain.Length,
        //         Name = walkDomain.Name,
        //         RegionId = walkDomain.RegionId,
        //         WalkDifficultyId = walkDomain.WalkDifficultyId
        //     };

        //     // Send DTO response back to Client
        //     return CreatedAtAction(nameof(GetWalkAsync), new { id = walkDTO.Id }, walkDTO);
        // }
    }
}
