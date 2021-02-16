using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using VetClinic.API.DTO.Position.PositionDTO;
using VetClinic.API.DTO.Queries;
using VetClinic.API.DTO.Responses;
using VetClinic.BLL.Domain;
using VetClinic.BLL.Services.Interfaces;
using VetClinic.DAL.Entities;

namespace VetClinic.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PositionsController : ControllerBase
    {
        private readonly IPositionService _positionService;
        private readonly IMapper _mapper;

        public PositionsController(IPositionService positionService, IMapper mapper)
        {
            _positionService = positionService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAsync(
            [FromQuery] PaginationQuery paginationQuery)
        {
            var pagination = _mapper.Map<PaginationFilter>(paginationQuery);
            var positionsDTO = _mapper.Map<ICollection<PositionDto>>(await _positionService.GetPositionAsync(pagination));
            var pagedResponse = new PagedResponse<PositionDto>(positionsDTO, paginationQuery);
            return Ok(pagedResponse);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetAsync([FromRoute] int id)
        {
            var position = await _positionService.GetPositionByIdAsync(id);
            var positionDTO = _mapper.Map<PositionDto>(position);
            if (positionDTO == null)
                return NotFound();

            return Ok(new Response<PositionDto>(positionDTO));
        }

        [HttpPost]
        public async Task<IActionResult> PostAsync([FromBody] CreateUpdatePositionDto position)
        {
            var createdPosition = await _positionService.AddPositionAsync(_mapper.Map<Position>(position));
            var positionDto = _mapper.Map<PositionDto>(createdPosition);

            return Created(nameof(GetAsync), new Response<PositionDto>(positionDto));
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutAsync([FromBody] CreateUpdatePositionDto position, [FromRoute] int id)
        {
            var successUpdate = await _positionService.UpdatePositionAsync((_mapper.Map<Position>(position)), id);
            if (successUpdate)
                return NoContent();

            return NotFound();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync([FromRoute] int id)
        {
            var successDelete = await _positionService.RemovePositionAsync(id);
            if (successDelete)
                return NoContent();

            return NotFound();
        }
    }
}
