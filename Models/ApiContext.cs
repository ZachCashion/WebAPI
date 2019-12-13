using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace WebAPI.Models
{
    public class ApiContext : DbContext
    {
        public ApiContext()
            :base("APIConnection")
        {
        }

        public static ApiContext create()
        {
            return new ApiContext();
        }

        public async Task<List<Households>> GetAllHouseholdData()
        {
            return await Database.SqlQuery<Households>("GetAllHouseholdData").ToListAsync();
        }

        public async Task<Households> GetHouseholds(int id)
        {
            return await Database.SqlQuery<Households>("GetHousehold @id",
                new SqlParameter("id", id)).FirstOrDefaultAsync();
        }
    }
}