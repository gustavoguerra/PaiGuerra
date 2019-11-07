using System;
using System.Collections.Generic;
using System.Text;

namespace Guerra.Domain.Models
{
    public class MercadoriaPreco : Entity
    {
        public int IdTipoPreco { get; set; }
        public int IdMercadoria { get; set; }
        public double Valor { get; set; }
        public DateTime DataCadastro { get; set; }
    }
}
