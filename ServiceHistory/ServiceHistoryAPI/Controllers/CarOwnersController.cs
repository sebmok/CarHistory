using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services;

namespace ServiceHistoryAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarOwnersController : ControllerBase
    {
        private readonly ICarOwnerService _carOwnerService;

        public CarOwnersController(ICarOwnerService carOwnerService)
        {
            _carOwnerService = carOwnerService;
        }

        [HttpGet]
        public IActionResult GetList()
        {
            var carowners = _carOwnerService.GetOwners();
            return Ok(carowners);

        }
    }
}