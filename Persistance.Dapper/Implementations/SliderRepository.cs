using Dapper;
using Domain.Models;
using Domain.Services;
using Persistance.Dapper.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistance.Dapper.Implementations
{
    public class SliderRepository : ISliderRepository
    {
        private readonly EshopContext _db;
        public SliderRepository(EshopContext db)
        {
            this._db = db;
        }
        public async Task<List<Main_Slider>> GetMainSlider()
        {
            try
            {
                var connection = this._db.CreateConnection();
                return (await connection.QueryAsync<Main_Slider>("SELECT * FROM [dbo].[Main_Slider]")).ToList();
            }
            catch (Exception)
            {
                return new List<Main_Slider>();
            }
        }
    }
}
