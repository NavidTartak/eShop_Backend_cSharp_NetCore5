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
    public class TopBannerRepository : ITopBannerRepository
    {
        private readonly EshopContext _db;
        public TopBannerRepository(EshopContext db)
        {
            this._db = db;
        }
        public async Task<Top_Banner> GetTopBanner()
        {
            try
            {
                var connection = this._db.CreateConnection();
                return await connection.QueryFirstOrDefaultAsync<Top_Banner>("SELECT TOP (1) * FROM [dbo].[Top_Banner]");
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
