using ControleDeContatos.Models;
using ControleDeContatos.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace ControleDeContatos.Controllers
{
    public class ContatoController : Controller
    {

        private readonly IContatoRepositorio _contatoRespositorio;
        public ContatoController(IContatoRepositorio contatoRepositorio)
        {
            _contatoRespositorio = contatoRepositorio;
        }
        public IActionResult Index()
        {
            List <ContatoModel> contatos = _contatoRespositorio.BuscarContatos();
            return View(contatos);
        }

        public IActionResult Criar()
        {
            return View();
        }
        public IActionResult Editar(int id)
        {
            ContatoModel contato = _contatoRespositorio.ListarPorId(id);
            return View(contato);
        }
        public IActionResult ApagarConfirmacao(int id)
        {
            ContatoModel contato = _contatoRespositorio.ListarPorId(id);
            return View(contato);
        }

        public IActionResult Apagar(int id) { 
            _contatoRespositorio.Apagar(id);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Criar(ContatoModel contato)
        {
            _contatoRespositorio.Adicionar(contato);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Alterar(ContatoModel contato)
        {
            _contatoRespositorio.Atualizar(contato);
            return RedirectToAction("Index");
        }
    }
}
