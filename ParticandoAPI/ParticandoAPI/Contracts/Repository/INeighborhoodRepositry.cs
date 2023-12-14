using ParticandoAPI.DTO;

namespace ParticandoAPI.Contracts.Repository
{
    public interface INeighborhoodRepositry
    {
        Task Create(NeighborhoodDTO neighborhood);
    }
}
