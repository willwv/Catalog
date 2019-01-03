using CatalogApi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CatalogApi.Repositorio.Catalog
{
    public interface ICatalogRepositorio
    {
        List<Produto> ListaProdutos();
    }
}
