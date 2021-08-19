﻿using Microsoft.AspNetCore.Mvc;

namespace RMP.Measurements.Presentation.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TestController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok();
        }
    }
}
