using Guerra.Business.Interface;
using Guerra.Domain.Cadastro;
using Guerra.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Guerra.Business.Business
{
    public class MercadoriaBusiness : IMercadoriaBusiness
    {

        protected readonly IMercadoriaRepository _mercadoriaRepository;
        public MercadoriaBusiness(IMercadoriaRepository mercadoriaRepository)
        {
            _mercadoriaRepository = mercadoriaRepository;
        }

        public IEnumerable<Mercadoria> GetAll()
        {
            return _mercadoriaRepository.GetAll();                       
        }

        public IEnumerable<Mercadoria> GetById(int id)
        {
            return _mercadoriaRepository.GetById(id);
        }

        public bool Insert(Mercadoria obj)
        {
            return _mercadoriaRepository.insert(obj);
        }

        public bool Remove(Mercadoria obj)
        {
            return _mercadoriaRepository.Remove(obj);
        }

        public bool Update(Mercadoria obj)
        {
            return _mercadoriaRepository.Update(obj);
        }
    }
}
