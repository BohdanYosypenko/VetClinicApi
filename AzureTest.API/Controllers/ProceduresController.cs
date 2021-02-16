using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using VetClinic.DAL.Entities;
using VetClinic.API.DTO.ProcedureDTO;
using AutoMapper;
using VetClinic.BLL.Services.Interfaces;
using VetClinic.API.DTO.Responses;

namespace VetClinic.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProceduresController : ControllerBase
    {
        private readonly IProcedureService _procedureService;
        private readonly IMapper _mapper; 
        
        public ProceduresController(IProcedureService procedureService, IMapper mapper)
        {
            _procedureService = procedureService;
            _mapper = mapper;
        }

        [HttpPost]
        public async Task<IActionResult> PostAsync(CreateProcedureDto procedureDTO)
        {
            Procedure procedure = _mapper.Map<CreateProcedureDto, Procedure>(procedureDTO);
            await _procedureService.AddProcedure(procedure);
            return Created(nameof(GetAsync), new Response<CreateProcedureDto>(procedureDTO));
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutAsync(int id, UpdateProcedureDto procedureDTO)
        {
            Procedure procedure = _mapper.Map<UpdateProcedureDto, Procedure>(procedureDTO);
            if (await _procedureService.PutProcedure(id, procedure))
                return NoContent();
            else return NotFound();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync(int id)
        {
            if (await _procedureService.DeleteProcedure(id))
                return NoContent();
            else return NotFound();
        }

        [HttpGet]
        public async Task<ActionResult<ICollection<ReadProcedureDto>>> GetAsync()
        {            
            var res =  await _procedureService.GetAllProcedures();
            ICollection<ReadProcedureDto> readProcedures = new List<ReadProcedureDto>();
            ReadProcedureDto dto;
            foreach(Procedure procedure in res)
            {
                dto = _mapper.Map<ReadProcedureDto>(procedure);
                readProcedures.Add(dto);
            }
            var pagedResponse = new Response<ICollection<ReadProcedureDto>>(readProcedures); 
            return Ok(pagedResponse);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Procedure>> GetAsync(int id)
        {
            var result = await _procedureService.GetProcedure(id);
            if (result != null)
            {
                ReadProcedureDto readDto = _mapper.Map<ReadProcedureDto>(result);
                return Ok(new Response<ReadProcedureDto>(readDto));
            }
            else return NotFound();
        }
    }
}
