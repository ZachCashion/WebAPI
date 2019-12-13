using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    [RoutePrefix("api/Households")]
    public class HouseholdsController : BaseController
    {
        [Route("GetAllHouseholdData")]
        public async Task<List<Households>> GetAllHouseholdData()
        {
            return await db.GetAllHouseholdData();
        }

        [Route("GetAllHouseholdDataAsJson")]
        public async Task<IHttpActionResult> GetAllHouseholdDataAsJson()
        {
            var data = await db.GetAllHouseholdData();
            return Json(data, new JsonSerializerSettings { Formatting = Formatting.Indented });
        }

        [Route("GetHousehold")]
        public async Task<Households> GetHousehold(int id)
        {
            return await db.GetHouseholds(id);
        }

        [Route("GetHouseholdAsJson")]
        public async Task<IHttpActionResult> GetHouseholdAsJson(int id)
        {
            var data = await db.GetHouseholds(id);
            return Json(data, new JsonSerializerSettings { Formatting = Formatting.Indented });
        }
    }
}
