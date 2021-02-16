using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using VetClinic.DAL.Entities;
using VetClinic.API.DTO.ClientDto;
using VetClinic.BLL.Services.Interfaces;
using VetClinic.API.DTO.Queries;
using VetClinic.BLL.Domain;
using VetClinic.API.DTO.Responses;

namespace VetClinic.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientsController : ControllerBase
    {
        private readonly IClientService _clientService;
        private readonly IMapper _mapper;
     
        public ClientsController(IClientService clientService, IMapper mapper)
        {
            _clientService = clientService;           
            _mapper = mapper;
        }

        [HttpPost]
        public async Task<IActionResult> PostAsync(CreateClientDto dto)
        {
            User user =  _mapper.Map<CreateClientDto, User>(dto);
            Client client = new Client();
            client = await _clientService.AddClient(user, client);
            ReadClientDto readDto = _mapper.Map<ReadClientDto>(client);
            return Created(nameof(GetAsync), new Response<ReadClientDto>(readDto));
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutAsync(int id, UpdateClientDto dto)
        {
            Client client = await _clientService.GetClient(id);
            if (client == null) return NotFound();
            else
            {
                User user = _mapper.Map<User>(dto);
                var res = await _clientService.PutClient(user, client);
                if (res)
                {
                    return NoContent();
                }
                else return NotFound();
            }
        }

        [HttpGet]
        public async Task<ActionResult<ICollection<Client>>> GetAsync(
            [FromQuery] ClientsFiltrationQuery query,
            [FromQuery] PaginationQuery paginationQuery
            )
        {
            var pagination = _mapper.Map<PaginationFilter>(paginationQuery);
            var filter = _mapper.Map<ClientsFilter>(query);

            var result = await _clientService.GetAllClients(filter, pagination);
            
            ICollection<ReadClientDto> readClients = new List<ReadClientDto>();
            ReadClientDto dto;
            foreach(Client client in result)
            {
                dto = _mapper.Map<ReadClientDto>(client);
                readClients.Add(dto);
            }
            return Ok(new PagedResponse<ReadClientDto>(readClients, paginationQuery));
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Client>> GetAsync(int id)
        {
            var res = await _clientService.GetClient(id);
            if (res == null) 
                return NotFound();
            else
            {
                ReadClientDto readClient = _mapper.Map<ReadClientDto>(res);
                return Ok(new Response<ReadClientDto>(readClient));
            }               
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync(int id)
        {
            if (await _clientService.DeleteClient(id))
                return NoContent();
            else return NotFound();
        }
    }
}
