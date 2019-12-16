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
    [RoutePrefix("api/BudgetItems")]
    public class BudgetItemsController : BaseController
    {
        //Get BudgetItems
        [Route("GetBudgetItems")]
        public async Task<List<BudgetItems>> GetBudgetItems(int id)
        {
            return await db.GetBudgetItems(id);
        }

        [Route("GetBudgetItems/json")]
        public async Task<IHttpActionResult> GetBudgetItemsJson(int id)
        {
            var data = await db.GetBudgetItems(id);
            return Json(data, new JsonSerializerSettings { Formatting = Formatting.Indented });
        }

        //Get BudgetItem Details
        [Route("GetBudgetItemDetail")]
        public async Task<BudgetItems> GetBudgetItemDetail(int id)
        {
            return await db.GetBudgetItemDetail(id);
        }

        [Route("GetBudgetItemDetail/json")]
        public async Task<IHttpActionResult> GetBudgetDetailJson(int id)
        {
            var data = await db.GetBudgetItemDetail(id);
            return Json(data, new JsonSerializerSettings { Formatting = Formatting.Indented });
        }

    }
}
