using ApiConcertHub.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ApiConcertHub.Controllers
{
    [ApiController] 
    [Route("api/[controller]")]
    public class EventController : Controller
    {
        private readonly IEventService _eventService;

        public EventController(IEventService eventService)
        {
            _eventService = eventService;
        }

        // GET: EventController
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public async Task <IActionResult> GetAll() => Ok(await _eventService.GetAll());

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var result = await _eventService.GetById(id);
            return (result != null) ? Ok(result) : NotFound();
        }
    }
}
