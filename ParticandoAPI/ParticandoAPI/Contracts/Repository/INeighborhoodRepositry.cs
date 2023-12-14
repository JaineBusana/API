using ParticandoAPI.DTO;
using ParticandoAPI.Entity;

namespace ParticandoAPI.Contracts.Repository
{
    public interface INeighborhoodRepositry
    {
        Task<IEnumerable<NeighborhoodEntity>> Get();
    }
}
