using Guerra.Business.Interface;
using Guerra.Domain.Cadastro;
using Guerra.Services.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Guerra.Services.Service
{
    public class MercadoriaService : IMercadoriaService
    {
        protected readonly IMercadoriaBusiness _mercadoriaBusiness;

        public MercadoriaService(IMercadoriaBusiness mercadoriabusiness)
        {
            _mercadoriaBusiness = mercadoriabusiness;
        }
        public IEnumerable<Mercadoria> GetAll()
        {
            return _mercadoriaBusiness.GetAll();
        }

        public IEnumerable<Mercadoria> GetById(int id)
        {
            return _mercadoriaBusiness.GetById(id);
        }

        public bool Insert(Mercadoria obj)
        {
            return _mercadoriaBusiness.Insert(obj);
        }

        public bool Remove(Mercadoria obj)
        {
            return _mercadoriaBusiness.Remove(obj);
        }

        public bool Update(Mercadoria obj)
        {
            return _mercadoriaBusiness.Update(obj);
        }
    }
}
