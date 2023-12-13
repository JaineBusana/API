using ParticandoAPI.Contracts.Repository;
using ParticandoAPI.DTO;
using ParticandoAPI.Entity;
using ParticandoAPI.Infrastructure;

namespace ParticandoAPI.Repository
{
    public class CollectionPointRepository : Connection, ICollectionPointRepository
    {
        public Task Create(CollectionPointDTO collection)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<CollectionPointEntity>> Get()
        {
            throw new NotImplementedException();
        }

        public Task<CollectionPointEntity> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task Update(CollectionPointEntity collection)
        {
            throw new NotImplementedException();
        }
    }
}
