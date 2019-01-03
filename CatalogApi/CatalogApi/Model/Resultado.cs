using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CatalogApi.Model
{
    public class Resultado
    {
        public bool Sucesso { get; set; }
        public string Mensagem { get; set; }
        public Produto Produto { get; set; }
    }
}
