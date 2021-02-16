using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using VetClinic.BLL.Services.Interfaces;

namespace VetClinic.API.Controllers
{
    public class SecretController : Controller
    {
        public SecretController(IUserService userService)
        {
            UserService = userService;
        }

        public IUserService UserService { get; }

        [HttpGet]
        [Route("/secret")]
        [Authorize(Roles = "admin")]
        public string Index()
        {
            return "VetClinic Secret";
        }
    }
}
