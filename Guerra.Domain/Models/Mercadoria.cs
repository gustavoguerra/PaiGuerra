using System;
using System.Collections.Generic;
using System.Text;

namespace Guerra.Domain.Cadastro
{
    public class Mercadoria : Entity
    {
        public string Descricao { get; set; }
        public string UnidadeMedida { get; set; }
        public bool Status { get; set; }
        public DateTime DataCadastro { get; set; }
    }
}
