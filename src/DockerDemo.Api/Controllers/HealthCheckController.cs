using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DockerDemo.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HealthCheckController : ControllerBase
    {
        /// <summary>
        /// Returns the current date and time
        /// </summary>
        /// <returns>String Value</returns>
        
        [HttpGet]
        public ActionResult<string> Get()
        {
            return DateTime.Now.ToString();
        }
    }
}