using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;
using VetClinic.API.DTO.Animal;
using VetClinic.API.DTO.Responses;
using VetClinic.BLL.Services.Interfaces;
using VetClinic.DAL.Entities;

namespace AzureTest.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {        

        private readonly ILogger<WeatherForecastController> _logger;
        private readonly IAnimalService _animalService;
        private readonly IMapper _mapper;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, IAnimalService animalService, IMapper mapper)
        {
            _logger = logger;
            _animalService = animalService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var animal = await _animalService.GetAsync(9);

            if (animal == null)
            {
                return NotFound();
            }

            var animalDto = _mapper.Map<ReadAnimalDto>(animal);
            return Ok(new Response<ReadAnimalDto>(animalDto));
        }
    }
}
