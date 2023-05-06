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
    public class SevenIconsRepository : ISevenIconsRepository
    {
        private readonly EshopContext _db;
        public SevenIconsRepository(EshopContext db)
        {
            this._db = db;
        }
        public async Task<List<Seven_Icons>> GetSevenIcons()
        {
            try
            {
                var connection = this._db.CreateConnection();
                return (await connection.QueryAsync<Seven_Icons>("SELECT * FROM [dbo].[Seven_Icons]")).ToList();
            }
            catch (Exception)
            {
                return new List<Seven_Icons>();
            }
        }
    }
}
