using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using RegisterApi.Models;
using RegisterApi.Services;

namespace RegisterApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegisterController : ControllerBase
    {
        private readonly IDataBaseService _register;

        public RegisterController(IDataBaseService register)
        {
            _register = register;
        }

        [HttpGet]
        public ActionResult<string> Get() 
        {
            return "value";
        }

        [HttpPost]
        public ActionResult<string> Post([FromBody] Person newPerson)
        {
            var response = _register.CreateRegister(newPerson);
            return Ok(response);
        }
    }
}
