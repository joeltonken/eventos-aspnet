using EventoApplication.Data;
using EventoApplication.Models;
using Microsoft.AspNetCore.Mvc;

namespace EventoApplication.Controllers
{
    public class EventoController : Controller
    {
        readonly private ApplicationDbContext _db;

        public EventoController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<EventosModel> eventos = _db.Eventos;
            return View(eventos);
        }

        [HttpGet]
        public IActionResult Cadastrar()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Editar(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            EventosModel evento = _db.Eventos.FirstOrDefault(x => x.Id == id);

            if (evento == null) 
            {
                return NotFound();
            }

            return View(evento);
        }

        [HttpGet]
        public IActionResult Excluir(int? id) 
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            EventosModel evento = _db.Eventos.FirstOrDefault(x => x.Id == id);

            if (evento == null)
            {
                return NotFound();
            }
            return View(evento);
        }

        [HttpPost]
        public IActionResult Cadastrar(EventosModel eventos)
        {
            if (ModelState.IsValid)
            {
                _db.Eventos.Add(eventos);
                _db.SaveChanges();

                TempData["MensagemSucesso"] = "Cadastro realizado com sucesso!";

                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpPost]
        public IActionResult Editar(EventosModel evento)
        {
            if (ModelState.IsValid)
            {
                var eventoDB = _db.Eventos.Find(evento.Id);

                eventoDB.Contratante = evento.Contratante;
                eventoDB.Empresa = evento.Empresa;
                eventoDB.Nome = evento.Nome;

                _db.Eventos.Update(eventoDB);
                _db.SaveChanges();

                TempData["MensagemSucesso"] = "Edição realizada com sucesso!";

                return RedirectToAction("Index");
            }

            TempData["MensagemErro"] = "Erro ao realizar edição!";

            return View(evento);
        }


        [HttpPost]
        public IActionResult Excluir(EventosModel evento)
        {
            if(evento == null)
            {
                return NotFound();
            }
            _db.Eventos.Remove(evento);
            _db.SaveChanges();

            TempData["MensagemSucesso"] = "Exclusão realizada com sucesso!";

            return RedirectToAction("Index");

        }


    }
}
