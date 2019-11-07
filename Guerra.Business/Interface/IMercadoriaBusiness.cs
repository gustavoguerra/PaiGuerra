using Guerra.Domain.Cadastro;
using System;
using System.Collections.Generic;
using System.Text;

namespace Guerra.Business.Interface
{
    public interface IMercadoriaBusiness
    {
        bool Insert(Mercadoria obj);
        bool Remove(Mercadoria obj);
        IEnumerable<Mercadoria> GetAll();
        IEnumerable<Mercadoria> GetById(int id);
        bool Update(Mercadoria obj);
    }
}
