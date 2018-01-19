using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace WebApplication1
{
    [Route("identity")]
    [Authorize("read")]
    public class IdentityController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var b = User;
            return new JsonResult(from c in User.Claims select new { c.Type, c.Value });
        }
    }
}
