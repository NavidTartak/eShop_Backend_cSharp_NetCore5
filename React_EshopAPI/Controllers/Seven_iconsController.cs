using Domain.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace React_EshopAPI.Controllers
{

    [ApiController]
    public class Seven_iconsController : ControllerBase
    {
        private readonly ISevenIconsRepository _sevenIconsRepo;
        public Seven_iconsController(ISevenIconsRepository sevenIconsRepo)
        {
            this._sevenIconsRepo = sevenIconsRepo;
        }
        [HttpGet]
        [Route("SevenIcons")]
        public async Task<IActionResult> GetSevenIcons()
        {
            return Ok(await this._sevenIconsRepo.GetSevenIcons());
        }
    }
}
