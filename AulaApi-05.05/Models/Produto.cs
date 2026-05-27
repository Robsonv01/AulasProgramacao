using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AulaApi_05._05.Models
{
    public class Produto
    {
        public int id { get; set; }

        public string Nome { get; set; } = string.Empty;

        public decimal Preco { get; set; }
    }
}