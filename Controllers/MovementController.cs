using Microsoft.AspNetCore.Mvc;
using Practica1.Models;
using Practica1.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Practica1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovementController : ControllerBase
    {
        private readonly StockService _stockService;

        public MovementController(StockService stockService)
        {
            _stockService = stockService;
        }


        // POST api/<MovementController>
        [HttpPost]
        public IActionResult CreateMovement(Movement movement)
        {
            try
            {
                _stockService.ApplyMovement(movement);
                return Ok("Movement applied");
            }
            catch(Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        

       
    }
}
