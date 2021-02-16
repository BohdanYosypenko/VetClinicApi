using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;
using VetClinic.API.DTO.AnimalType;
using VetClinic.API.DTO.Queries;
using VetClinic.API.DTO.Responses;
using VetClinic.BLL.Domain;
using VetClinic.BLL.Services.Interfaces;
using VetClinic.DAL.Entities;

namespace VetClinic.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnimalTypesController : ControllerBase
    {
        private readonly IAnimalTypeService _animalTypeService;
        private readonly IMapper _mapper;
        public AnimalTypesController(IAnimalTypeService animalTypeService, IMapper mapper)
        {
            _animalTypeService = animalTypeService;
            _mapper = mapper;
        }

        [HttpPost]
        public async Task<IActionResult> PostAsync([FromBody] AnimalTypeDto createAnimalTypeDto)
        {
            await _animalTypeService.CreateAnimalType(_mapper.Map<AnimalType>(createAnimalTypeDto));
            return Created(nameof(GetAsync), new Response<AnimalTypeDto>(createAnimalTypeDto));
        }

        [HttpGet]
        public async Task<IActionResult> GetAsync(
            [FromQuery] PaginationQuery paginationQuery)
        {
            var pagination = _mapper.Map<PaginationFilter>(paginationQuery);

            var animals = await _animalTypeService.GetAllAsync(pagination);
            var result = animals.Select(x => _mapper.Map<ReadAnimalTypeDto>(x));
            return Ok(new PagedResponse<ReadAnimalTypeDto>(result, paginationQuery));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetAsync(int id)
        {
            var animal = await _animalTypeService.GetAsync(id);

            if (animal == null)
            {
                return NotFound();
            }

            var animalTypeDto = _mapper.Map<ReadAnimalTypeDto>(animal);
            return Ok(new Response<ReadAnimalTypeDto>(animalTypeDto));
        }


        [HttpPut("{id}")]
        public async Task<IActionResult> PutAsync(int id, [FromBody] AnimalTypeDto updateAnimalTypeDto)
        {
            var animalType = await _animalTypeService.GetAsync(id);

            if (animalType == null)
            {
                return NotFound();
            }
            var updateAnimalType = _mapper.Map<AnimalType>(updateAnimalTypeDto);

            await _animalTypeService.UpdateAnimalType(id, updateAnimalType);

            return NoContent();
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync(int id)
        {
            var animalType = await _animalTypeService.GetAsync(id);

            if (animalType == null)
            {
                return NotFound();
            }
            await _animalTypeService.RemoveAnimalType(animalType);
            return NoContent();
        }
    }
}
