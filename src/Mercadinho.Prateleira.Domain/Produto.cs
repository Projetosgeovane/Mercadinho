using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mercadinho.Prateleira.Domain
{
    class Produto
    {
        public int id { get; set; }
        public string Descricao { get; set; }
        public ICollection<Categoria> Categorias { get; set; }
        public Estoque Estoque { get; set; } = default;
    }
}
