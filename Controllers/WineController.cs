using Microsoft.AspNetCore.Mvc;
using practice_api.Models;
using practice_api.Services;
using practice_api.Services.WineServices;

namespace practice_api.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class WineController : ControllerBase
    {
        private readonly IWineService _wineService;

        public WineController(IWineService wineService)
        {
            _wineService = wineService;
        }

       [HttpGet("GetAll")]
       public async Task<ActionResult<List<Wine>>> Get()
       {
        return Ok(await _wineService.GetAllWines());
       }
       [HttpGet("{id}")]
       public async Task<ActionResult<Wine>> GetSingle(int id)
       {
            return Ok(await _wineService.GetWineById(id));
       }
       [HttpPost("AddWine")]
       public async Task<ActionResult<List<Wine>>> AddWine(Wine newWine)
       {
        return Ok(_wineService.AddNewWine(newWine));
       }


    }
}