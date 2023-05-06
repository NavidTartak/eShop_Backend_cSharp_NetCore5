using Domain.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace React_EshopAPI.Controllers
{
    [Route("public")]
    [ApiController]
    public class Main_sliderController : ControllerBase
    {
        private readonly ISliderRepository _sliderRepo;
        public Main_sliderController(ISliderRepository sliderRepo)
        {
            this._sliderRepo = sliderRepo;
        }
        [HttpGet("mainSlider")]
        public async Task<IActionResult> GetMainSlider()
        {
            return Ok(await this._sliderRepo.GetMainSlider());
        }
    }
}
