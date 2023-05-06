using Domain.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace React_EshopAPI.Controllers
{
    [Route("topBanner")]
    [ApiController]
    public class Top_BannerController : ControllerBase
    {
        private readonly ITopBannerRepository _topBannerRepo;
        public Top_BannerController(ITopBannerRepository topBannerRepo)
        {
            this._topBannerRepo = topBannerRepo;
        }
        [HttpGet]
        public async Task<IActionResult> GetTopBanner()
        {
            return Ok(await this._topBannerRepo.GetTopBanner());
        }
    }
}
