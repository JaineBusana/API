using ParticandoAPI.DTO;
using ParticandoAPI.Entity;

namespace ParticandoAPI.Contracts.Repository
{
    public interface ICollectionPointRepository
    {
        Task Create(CollectionPointDTO collection);
        Task Update(CollectionPointEntity collection);
        Task Delete(int id);
        Task<IEnumerable<CollectionPointEntity>> Get();
        Task<CollectionPointEntity> GetById(int id);

        Task<CollectionPointTokenDTO> CollectionPointLogin(CollectionPointLoginDTO collectionPointLogin);
    }
}
