using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CatalogApi.Model;
using CatalogApi.Repositorio.Catalog;
using Microsoft.AspNetCore.Mvc;

namespace CatalogApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CatalogController : ControllerBase
    {
        private CatalogRepositorio catalogRepositorio = new CatalogRepositorio();
        // GET api/values
        [HttpGet]
        public ActionResult<List<Produto>> ListarProdutos()
        {
            return catalogRepositorio.ListaProdutos();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<Resultado> ProdutoPorId(int id)
        {
            bool sucesso;
            string mensagem = string.Empty;
            Produto produtoEncontrado;

            List<Produto> produtoSelecionado = catalogRepositorio.ListaProdutos().Where(produto => produto.Id.Equals(id)).ToList();

            if (produtoSelecionado.Any())
            {
                sucesso = true;
                mensagem = "Produto Encontrado!";
                produtoEncontrado = produtoSelecionado.FirstOrDefault();
            }
            else
            {
                sucesso = false;
                mensagem = "Produto Não Encontrado!";
                produtoEncontrado = null;
            }

            return new Resultado() { Sucesso = sucesso, Mensagem = mensagem, Produto = produtoEncontrado };
        }
    }
}
