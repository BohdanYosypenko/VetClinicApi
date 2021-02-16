using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;
using VetClinic.API.DTO.Animal;
using VetClinic.API.DTO.Queries;
using VetClinic.API.DTO.Responses;
using VetClinic.BLL.Domain;
using VetClinic.BLL.Services.Interfaces;
using VetClinic.DAL.Entities;

namespace VetClinic.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnimalsController : Controller
    {
        private readonly IAnimalService _animalService;
        private readonly IMapper _mapper;

        public AnimalsController(IAnimalService animalService, IMapper mapper)
        {
            _animalService = animalService;
            _mapper = mapper;
        }

        [HttpPost]
        public async Task<IActionResult> PostAsync([FromBody] CreateAnimalDto createAnimalDto)
        {
            var animal = await _animalService.CreateAnimal(_mapper.Map<Animal>(createAnimalDto));

            var readAnimalDto = _mapper.Map<ReadAnimalDto>(animal);

            return Created(nameof(GetAsync), new Response<ReadAnimalDto>(readAnimalDto));
        }

        [HttpGet]
        public async Task<IActionResult> GetAsync(
            [FromQuery] AnimalsFiltrationQuery query,
            [FromQuery] PaginationQuery paginationQuery)
        {
            var pagination = _mapper.Map<PaginationFilter>(paginationQuery);
            var filter = _mapper.Map<AnimalsFilter>(query);

            var animals = await _animalService.GetAllAsync(filter, pagination);

            var result = animals.Select(x => _mapper.Map<ReadAnimalDto>(x));
            var pagedResponse = new PagedResponse<ReadAnimalDto>(result, paginationQuery);
            return Ok(pagedResponse);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetAsync(int id)
        {
            var animal = await _animalService.GetAsync(id);

            if (animal == null)
            {
                return NotFound();
            }

            var animalDto = _mapper.Map<ReadAnimalDto>(animal);
            return Ok(new Response<ReadAnimalDto>(animalDto));
        }


        [HttpPut("{id}")]
        public async Task<IActionResult> PutAsync(int id, [FromBody] UpdateAnimalDto updateAnimalDto)
        {
            var animal = await _animalService.GetAsync(id);

            if (animal == null)
            {
                return NotFound();
            }
            var updateAnimal = _mapper.Map<Animal>(updateAnimalDto);

            await _animalService.UpdateAnimal(id, updateAnimal);

            return NoContent();
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync(int id)
        {
            var animal = await _animalService.GetAsync(id);

            if (animal == null)
            {
                return NotFound();
            }

            await _animalService.RemoveAnimal(animal);
            return NoContent();
        }
    }
}