using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BasicVueTemplate.Controllers
{
    /// <summary>
    /// TODO: Dummy just for route tests
    /// </summary>
    [ApiController]
    [Route("[controller]")]
    public class AuthenticationController : ControllerBase
    {
        [HttpPost("[action]")]
        public bool Login([FromBody] LogInModel param)
        {
            return true;
        }

        [HttpGet("[action]")]
        public bool LoginGet(string userName, string passWord)
        {
            return true;
        }
    }

    public class LogInModel
    {
        public string userName { get; set; }
        public string passWord { get; set; }
    }
}
