﻿using Newtonsoft.Json;
using System.Collections.Generic;
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

        [Route("GetAllHouseholdData/json")]
        public async Task<IHttpActionResult> GetAllHouseholdDataAsJson()
        {
            var data = await db.GetAllHouseholdData();
            return Json(data, new JsonSerializerSettings { Formatting = Formatting.Indented });
        }

        //=======================================================================================

        [Route("GetHousehold")]
        public async Task<Households> GetHousehold(int id)
        {
            return await db.GetHouseholds(id);
        }

        [Route("GetHousehold/json")]
        public async Task<IHttpActionResult> GetHouseholdAsJson(int id)
        {
            var data = await db.GetHouseholds(id);
            return Json(data, new JsonSerializerSettings { Formatting = Formatting.Indented });
        }

        //=======================================================================================
        // Add Household
        [HttpPost]
        [Route("AddHousehold")]
        public IHttpActionResult AddHousehold (string name, string greeting)
        {
            return Ok(db.AddHousehold(name, greeting));
        }

        //=======================================================================================
        // Update Household
        [HttpPost]
        [Route("UpdateHousehold")]
        public IHttpActionResult UpdateHousehold (int id, string name, string greeting)
        {
            return Ok(db.UpdateHousehold(id, name, greeting));
        }
    }
}
