﻿using Dapper;
using ParticandoAPI.Contracts.Repository;
using ParticandoAPI.DTO;
using ParticandoAPI.Entity;
using ParticandoAPI.Infrastructure;

namespace ParticandoAPI.Repository
{
    public class CollectionPointRepository : Connection, ICollectionPointRepository
    {
        public async Task Create(CollectionPointDTO collection)
        {
            string sql = @"
                INSERT INTO collection_point (Name, Address, Telephone, Residue, Neighborhood_Id)
                           VALUE (@Name, @Address, @Telephone, @Residue, @Neighborhood_Id)
            ";
            await Execute(sql, collection);
        }

        public async Task Delete(int id)
        {
            string sql = @"
                DELETE FROM collection_point
                       WHERE Id = @id
            ";
            await Execute(sql, new { id });
        }

        public async Task<IEnumerable<CollectionPointEntity>> Get()
        {
            string sql = @"
                SELECT * FROM collection_point
            ";
            return await GetConnection().QueryAsync<CollectionPointEntity>(sql);
        }

        public async Task<CollectionPointEntity> GetById(int id)
        {
            string sql = @"
                SELECT * FROM collection_point 
                         WHERE Id = @id
            ";
            return await GetConnection().QueryFirstAsync<CollectionPointEntity>(sql, new {id});
        }

        public async Task<CollectionPointTokenDTO> CollectionPointLogin(CollectionPointLoginDTO collectionPointLogin)
        {
            string sql = "SELECT * FROM collection_point WHERE Name = @Name AND Telephone = @Telephone";
            CollectionPointEntity collectionPoint = await GetConnection().QueryFirstAsync<CollectionPointEntity>(sql, collectionPointLogin);
            return new CollectionPointTokenDTO
            {
                Token = Authentication.GenerateToken(collectionPoint)
            };
        }

        public async Task Update(CollectionPointEntity collection)
        {
            string sql = @"
                UPDATE collection_point 
                   SET Name = @Name, 
                       Address = @Address, 
                       Telephone = @Telephone,
                       Residue = @Residue,
                       Neighborhood_Id = @Neighborhood_Id
                 WHERE Id = @Id
            ";
            await Execute(sql, collection);
        }
    }
}
