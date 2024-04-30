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
    }
}
