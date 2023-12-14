using Dapper;
using ParticandoAPI.Contracts.Repository;
using ParticandoAPI.Entity;
using ParticandoAPI.Infrastructure;

namespace ParticandoAPI.Repository
{
    public class NeighborhoodRepository : Connection, INeighborhoodRepositry
    {
        public async Task<IEnumerable<NeighborhoodEntity>> Get()
        {
            string sql = @"SELECT * FROM neighborhood";
            return await GetConnection().QueryAsync<NeighborhoodEntity>(sql);
        }
    }
}
