using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services
{
    public interface ISliderRepository
    {
        Task<List<Main_Slider>> GetMainSlider();
    }
}
