using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using VetClinic.API.DTO;
using VetClinic.API.DTO.Responses;
using VetClinic.API.DTO.Service;
using VetClinic.BLL.Services.Interfaces;
using VetClinic.DAL.Entities;

namespace VetClinic.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServicesController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IServiceService _serviceService;

        public ServicesController(IMapper mapper, IServiceService serviceService)
        {
            _mapper = mapper;
            _serviceService = serviceService;
        }

        //GET api/service
        [HttpGet]
        public async Task<ActionResult<ICollection<ServiceDto>>> GetAsync()
        {
            var services = await _serviceService.GetAllServicesAsync();
            var servicesDTO = _mapper.Map<ICollection<ServiceDto>>(services);
            var response = new Response<ICollection<ServiceDto>>(servicesDTO);
            return Ok(response);
        }

        // GET api/service/3
        [HttpGet("{id:min(1)}")]
        public async Task<ActionResult<ServiceDto>> GetAsync([FromRoute] int id)
        {
            var service = await _serviceService.GetServiceByIdAsync(id);

            if(service == null)
            {
                return NotFound();
            }

            var serviceDTO = _mapper.Map<ServiceDto>(service);
            return Ok(new Response<ServiceDto>(serviceDTO));
        }

        // POST api/service
        [HttpPost]
        public async Task<ActionResult<ServiceDto>> PostAsync([FromBody] ServiceCreateDto serviceCreateDTO)
        {
            var service = _mapper.Map<Service>(serviceCreateDTO);
            var insertedService  =  await _serviceService.AddAsync(service);
            var insertedServiceDTO = _mapper.Map<ServiceDto>(insertedService);
            return CreatedAtAction(nameof(GetAsync), new Response<ServiceDto>(insertedServiceDTO));
        }

        // PUT api/service/id
        [HttpPut("{id:min(1)}")]
        public async Task<IActionResult> PutAsync([FromRoute] int id, [FromBody]ServiceUpdateDto serviceUpdateDTO)
        {
            var service = _mapper.Map<Service>(serviceUpdateDTO);
            var updated = await _serviceService.UpdateAsync(id, service);
            if (!updated)
            {
                return NotFound();
            }
            
            return NoContent();
        }

        // DELETE api/service/id
        [HttpDelete("{id:min(1)}")]
        public async Task<IActionResult> DeleteAsync(int id)
        {
            var service = await _serviceService.RemoveAsync(id);
            if(!service)
            {
                return NotFound();
            }
            
            return NoContent();
        }
       
    }
}
