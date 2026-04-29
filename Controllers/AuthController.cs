using ApiConcertHub.Interfaces;
using ApiConcertHub.Models.DTO;
using Microsoft.AspNetCore.Mvc;

namespace ApiConcertHub.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : Controller
    {
        private readonly IAuthService _authService;

        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        [HttpPost("register")]
        public async Task<IActionResult> register(RegisterDTO model)
        {
            var result = await _authService.Register(model.Mail, model.Password, model.Role);
            if (result.Succeeded)
            {
                return Ok(new {message=$"Usuario {model.Mail} creado con exito"});
            }

            return BadRequest(result.Errors);
        }

        public ActionResult Index()
        {
            return View();
        }

    }
}
