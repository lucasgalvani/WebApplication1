using Microsoft.AspNetCore.Mvc;
using WebApplication1.Data.Repositorio.Interfaces;

namespace WebApplication1.Controllers
{
    public class AlunoController : Controller
    {
        private readonly IAlunoRepositorio _alunoRepositorio;
        public AlunoController(IAlunoRepositorio alunoRepositorio)
        {
            _alunoRepositorio = alunoRepositorio;
        }
        public IActionResult Index()
        {
            var aluno = _alunoRepositorio.BuscarAlunos();
            return View(aluno);
        }
    }
}