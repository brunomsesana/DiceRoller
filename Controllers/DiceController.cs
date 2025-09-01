using Microsoft.AspNetCore.Mvc;
using myapp.Services;

namespace myapp.Controllers
{
    [ApiController]
    [Route("/")]
    public class DiceController : ControllerBase
    {
        private readonly DiceService _diceService;

        public DiceController(DiceService diceService)
        {
            _diceService = diceService;
        }

        [HttpGet("roll")]
        public IActionResult Roll(string macro)
        {
            return Ok(_diceService.Roll(macro));
        }
    }
}
