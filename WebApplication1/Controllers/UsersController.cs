using Business;
using Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        ILogInService _logInService;
        public UsersController(ILogInService logInService)
        {
            _logInService = logInService;
        }

        [HttpPost("login")]
        public ActionResult Login()
        {
            _logInService.LogIn();
            return RedirectToAction("SetLogin");
        }
    }
}
