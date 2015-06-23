using System;
using System.Collections.Generic; 
using System.Linq;
using System.Text;  
using System.Threading.Tasks;

namespace Learn.Loja.Dominio.Entidades
{
    class Produto
    {
        private int id { get; set; }

        private string nome { get; set; }

        private string descricao { get; set; }

        private decimal preco { get; set; }

        private string categoria { get; set; }
    }
}
