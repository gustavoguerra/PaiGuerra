using System;
using System.Collections.Generic;
using System.Text;

namespace Guerra.Domain.Models
{
    public class TipoPreco : Entity
    {
        public string Descricao { get; set; }
        public List<MercadoriaPreco> ListMercadoria { get; set; }
        public DateTime Datacadastro { get; set; }
    }
}
