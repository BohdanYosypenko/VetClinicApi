using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VetClinic.API.DTO.Account;
using VetClinic.BLL.Services.Interfaces;

namespace VetClinic.API.Controllers
{
    [Route("api/account")]
    [ApiController]
    public class AccountsController : ControllerBase
    {
        public AccountsController(IUserService userService)
        {
            UserService = userService;
        }

        public IUserService UserService { get; }

        [HttpGet("{userName}")]
        public async Task<bool> UserNameExists(string userName)
        {
            if (userName == null)
            {
                return false;
            }
            return await UserService.UserNameExistsAsync(userName);
        }


        [HttpPut("changepass/{id}")]
        public async Task<IActionResult> ChangePassword([FromBody] ChangePasswordDto dto)
        {
            var res = await UserService.ChangePassword(dto.Id, dto.OldPassword, dto.NewPassword);
            if (res)
            {
                return NoContent();
            }
            return NotFound();
        }

        [HttpPost("validate/pass")]
        public async Task<bool> ValidatePass([FromBody] VerifyPasswordDto dto)
        {
            bool res = await UserService.OldPasswordExists(dto.Id, dto.OldPassword);
            return res;
        }
    }
}
