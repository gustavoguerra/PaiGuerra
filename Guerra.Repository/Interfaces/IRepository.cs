using Dapper;
using Guerra.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Guerra.Repository.Interfaces
{
    public interface IRepository<TEntity> where TEntity : Entity
    {
        bool insert(TEntity obj);
        bool Remove(TEntity obj);
        IEnumerable<TEntity> GetAll();
        IEnumerable<TEntity> GetById(int id);
        bool Update(TEntity obj);
        IEnumerable<TEntity> ExecuteQuery(string query, DynamicParameters parameters);                     
    }
}
