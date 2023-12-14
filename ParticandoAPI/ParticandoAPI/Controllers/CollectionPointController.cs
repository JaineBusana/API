using Microsoft.AspNetCore.Mvc;
using ParticandoAPI.Contracts.Repository;
using ParticandoAPI.DTO;
using ParticandoAPI.Entity;

namespace ParticandoAPI.Controllers
{
    [ApiController]
    [Route("CollectionPoint")]
    public class CollectionPointController : ControllerBase
    {
        private readonly ICollectionPointRepository _CollectionPointRepository;

        public CollectionPointController(ICollectionPointRepository collectionPointRepository)
        {
            _CollectionPointRepository = collectionPointRepository;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _CollectionPointRepository.Get());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            return Ok(await _CollectionPointRepository.GetById(id));
        }

        [HttpPost]
        public async Task<IActionResult> Create(CollectionPointDTO collectionPoint)
        {
            await _CollectionPointRepository.Create(collectionPoint);
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> Update(CollectionPointEntity collectionPoint)
        {
            await _CollectionPointRepository.Update(collectionPoint);
            return Ok();
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            await _CollectionPointRepository.Delete(id);
            return Ok();
        }

    }
}
