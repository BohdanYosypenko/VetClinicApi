using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using VetClinic.API.DTO.Doctor;
using VetClinic.API.DTO.Queries;
using VetClinic.API.DTO.Responses;
using VetClinic.BLL.Domain;
using VetClinic.BLL.Services.Interfaces;
using VetClinic.DAL.Entities;

namespace VetClinic.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoctorsController : ControllerBase
    {
        private readonly IDoctorService _doctorService;
        private readonly IMapper _mapper;

        public DoctorsController(IDoctorService doctorService, IMapper mapper)
        {
            _doctorService = doctorService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAsync(
            [FromQuery] DoctorsFiltrationQuery query,
            [FromQuery] PaginationQuery paginationQuery)
        {
            var pagination = _mapper.Map<PaginationFilter>(paginationQuery);
            var filter = _mapper.Map<DoctorsFilter>(query);
            var doctors = await _doctorService.GetDoctorAsync(filter, pagination);
            var doctorsDto = _mapper.Map<ICollection<ReadDoctorDto>>(doctors);
            var totalCount = await _doctorService.GetTotalCount(filter);
            var pagedResponse = new PagedResponse<ReadDoctorDto>(doctorsDto, paginationQuery, totalCount);
            return Ok(pagedResponse);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetAsync([FromRoute] int id)
        {
            Doctor doctor = await _doctorService.GetDoctorByIdAsync(id);
            ReadDoctorDto doctorDto = _mapper.Map<ReadDoctorDto>(doctor);
            if (doctorDto == null)
                return NotFound();

            return Ok(new Response<ReadDoctorDto>(doctorDto));
        }

        [HttpPost]
        public async Task<IActionResult> PostAsync([FromBody] CreateDoctorDto doctorDto)
        {
            var doctor = _mapper.Map<Doctor>(doctorDto);
            var user = _mapper.Map<User>(doctorDto);
            var createdDoctor = await _doctorService.AddDoctorAsync(doctor, user);
            var readDoctorDto = _mapper.Map<ReadDoctorDto>(createdDoctor);

            return Created(nameof(GetAsync), new Response<ReadDoctorDto>(readDoctorDto));
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutAsync([FromBody] UpdateDoctorDto doctorDto, [FromRoute] int id)
        {
            var doctor = _mapper.Map<Doctor>(doctorDto);
            var user = _mapper.Map<User>(doctorDto);
            var successUpdate = await _doctorService.UpdateDoctorAsync(doctor, user, id);
            if (successUpdate)
                return NoContent();

            return NotFound();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync([FromRoute] int id)
        {
            var successDelete = await _doctorService.RemoveDoctorAsync(id);
            if (successDelete)
                return NoContent();

            return NotFound();
        }
    }
}
