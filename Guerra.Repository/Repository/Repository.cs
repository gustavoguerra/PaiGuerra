using Dapper;
using Guerra.Domain;
using Guerra.Repository.Interfaces;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace Guerra.Repository.Repository
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : Entity
    {
        private readonly IConfiguration _config;
        
        public Repository(IConfiguration config)
        {
            _config = config;
        }
        public IEnumerable<TEntity> ExecuteQuery(string query, DynamicParameters parameters)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TEntity> GetAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TEntity> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public bool insert(TEntity obj)
        {
            throw new NotImplementedException();
        }

        public bool Remove(TEntity obj)
        {
            throw new NotImplementedException();
        }

        public bool Update(TEntity obj)
        {
            throw new NotImplementedException();
        }
    }
}
