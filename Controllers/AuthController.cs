using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FGLWebAPIPOC.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthController : ControllerBase
    {
        [HttpGet("GetConfigurationData")]
        public ActionResult<IEnumerable<Configuration>> GetConfiguration()
        {
            return new[]
            {
            new Configuration { Key = "ApplicationKey" ,Value="Value"},

        };
        }
        public class Configuration
        {
            public string Key { get; set; }
            public string Value { get; set; }
        }

    }
}
