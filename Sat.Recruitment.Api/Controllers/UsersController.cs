using Microsoft.AspNetCore.Mvc;
using Sat.Recruitment.Domain.Entities;
using Sat.Recruitment.Service;
using System;
using System.ComponentModel;
using System.Threading.Tasks;

namespace Sat.Recruitment.Api.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService userService;

        public UserController(IUserService userService)
        {
            this.userService = userService;
        }

        /// <summary>
        /// Create new user (I changed the request parameter to User object assuming I was able to update the consumer in order to send it.)
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        [HttpPost("")]
        public IActionResult CreateUser(User user)
        {
            return Ok(userService.CreateUser(user));
        }
    }
}
