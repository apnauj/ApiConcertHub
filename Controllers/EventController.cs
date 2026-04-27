using ApiConcertHub.Interfaces;
using ApiConcertHub.Models;
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

        [HttpPost]
        public async Task<IActionResult> Create(Event newEvent)
        {
            var created = await _eventService.Create(newEvent);
            return CreatedAtAction(nameof(GetById), new { id = created.Id }, newEvent);
        }

        [HttpPut]
        public async Task<IActionResult> Edit(Guid id, Event editEvent) => (await _eventService.Edit(id, editEvent)) ? Ok(true) : NotFound(false);

        [HttpPatch("{id}")]
        public async Task<IActionResult> ChangeStatus(Guid id)
        {
            var edit = await _eventService.ChangeStatus(id);
            if (edit == -1) return NotFound();
            var message = (edit == 1) ? "Active" : "Inactive";
            return Ok(message);
        }
    }
}
