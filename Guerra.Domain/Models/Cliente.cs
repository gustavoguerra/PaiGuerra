using System;
using System.Collections.Generic;
using System.Text;

namespace Guerra.Domain.Cadastro
{
    public class Cliente : Entity
    {
        public string Nome { get; set; }
        public string CNPJ { get; set; }
    }
}
