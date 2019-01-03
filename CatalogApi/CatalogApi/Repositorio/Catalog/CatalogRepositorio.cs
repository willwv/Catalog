using CatalogApi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CatalogApi.Repositorio.Catalog
{
    public class CatalogRepositorio: ICatalogRepositorio
    {
        public List<Produto> ListaProdutos()
        {
            return new List<Produto>()
            {
                new Produto()
                {
                    Id = 1,
                    Nome = "Memória RAM DDR 4 8 GB",
                    Descricao = "Aumenta memória virtual do computador.",
                    Preco = 200.00
                },
                new Produto()
                {
                    Id = 2,
                    Nome = "Placa de Video",
                    Descricao = "Possibilita jogar jogos atuais.",
                    Preco = 2500.00
                },
                new Produto()
                {
                    Id = 3,
                    Nome = "Processador",
                    Descricao = "Torna o computador mais rápido.",
                    Preco = 800.00
                }
            };
        }
    }
}
