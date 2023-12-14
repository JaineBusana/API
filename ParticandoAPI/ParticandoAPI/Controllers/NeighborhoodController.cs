using Microsoft.AspNetCore.Mvc;
using ParticandoAPI.Contracts.Repository;

namespace ParticandoAPI.Controllers
{
    [ApiController]
    [Route("Neighborhood")]
    public class NeighborhoodController : ControllerBase
    {
        private readonly INeighborhoodRepositry _neighborhoodRepositry;

        public NeighborhoodController(INeighborhoodRepositry neighborhoodRepositry)
        {
            _neighborhoodRepositry = neighborhoodRepositry;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _neighborhoodRepositry.Get());
        }
    }
}
