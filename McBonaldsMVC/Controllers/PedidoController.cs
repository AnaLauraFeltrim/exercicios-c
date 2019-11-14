using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System;
using McBonaldsMVC.Models;
using McBonaldsMVC.Repositories;

namespace McBonaldsMVC.Views.PedidoController
{
    public class PedidoController : Controller
    {
        PedidoRepository pedidoRepository = new PedidoRepository();
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Registrar (IFormCollection form)
        {
            Pedido pedido = new Pedido();

            Shake shake = new Shake();
            shake.Nome = form["shake"];
            shake.Preco = 0.0;

            Hamburguer hamburguer = new Hamburguer();
            hamburguer.Nome = form["hamburguer"];
            hamburguer.Preco = 0.0;
                
            

            Cliente cliente = new Cliente()
            {
                Nome = form["nome"],
                Endereco = form["endereco"],
                Telefone = form["telefone"],
                Email = form["email"]
            };

            pedido.Cliente =cliente;
            pedido.DataDoPedido = DateTime.Now;

            return View("Sucesso");
        }
    }
}