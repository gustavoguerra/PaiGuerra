using Dapper;
using Guerra.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Guerra.Business.Interface
{
    public interface ITipoPrecoBusiness
    {
        bool Insert(TipoPreco obj);
        bool Remove(TipoPreco obj);
        IEnumerable<TipoPreco> GetAll();
        IEnumerable<TipoPreco> GetById(int id);
        bool Update(TipoPreco obj);
        IEnumerable<TipoPreco> ExecuteQuery(string query, DynamicParameters parameters);
    }
}
