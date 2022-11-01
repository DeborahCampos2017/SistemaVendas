using Microsoft.AspNetCore.Mvc;
using SistemaVendas.Context;
using SistemaVendas.Models;
using System.Runtime.Serialization;

namespace SistemaVendas.Controllers
{
    public class VendasController : Controller
    {
        private readonly VendasContext _context;

        public VendasController(VendasContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var contatos = _context.Vendas.ToList();
            return View(contatos);
        }
        public IActionResult Criar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Criar(Vendas venda)
        {
            if (ModelState.IsValid)
            {
                _context.Vendas.Add(venda);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(venda);
        }
        public IActionResult Editar(int id)
        {
            var contato = _context.Vendas.Find(id);

            if (contato == null)
            {
                return NotFound();
            }
            return View(contato);
        }

        [HttpPost]
        public IActionResult Editar(Vendas contato)
        {
            var contatoBanco = _context.Vendas.Find(contato.Id);

            contatoBanco.DataVenda = contato.DataVenda;
            contatoBanco.IdProduto = contato.IdProduto;
            contatoBanco.NomeProduto = contato.NomeProduto;
            contatoBanco.ValorProduto = contato.ValorProduto;
            contatoBanco.NomeVendedor = contato.NomeVendedor;
            contatoBanco.CpfVendedor =  contato.CpfVendedor;
            contatoBanco.EmailVendedor = contato.EmailVendedor;
            contatoBanco.Status = contato.Status;

            _context.Vendas.Update(contatoBanco);
            _context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }

        public IActionResult Detalhes(int id)
        {
            var contato = _context.Vendas.Find(id);

            if (contato == null)
                return RedirectToAction(nameof(Index));

            return View(contato);
        }

        public IActionResult Vendedor(int id)
        {
            var contato = _context.Vendas.Find(id);

            if (contato == null)
                return RedirectToAction(nameof(Index));

            return View(contato);
        }

        public IActionResult Deletar(int id)
        {
            var contato = _context.Vendas.Find(id);

            if (contato == null)
                return RedirectToAction(nameof(Index));

            return View(contato);
        }

        [HttpPost]
        public IActionResult Deletar(Vendas contato)
        {
            var contatoBanco = _context.Vendas.Find(contato.Id);

            _context.Vendas.Remove(contatoBanco);
            _context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }
    }
}
