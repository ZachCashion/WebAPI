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
    [RoutePrefix("api/Budgets")]
    public class BudgetsController : BaseController
    {
        //Add Budget
        [HttpPost]
        [Route("AddBudget")]
        public IHttpActionResult AddBudget(int hhId, string ownerId, string name, string target, string current)
        {
            return Ok(db.AddBudget( hhId, ownerId, name, target, current));
        }
        //Get Budgets
        [Route("GetBudgets")]
        public async Task<List<Budgets>> GetBudgets(int id)
        {
            return await db.GetBudgets(id);
        }

        [Route("GetBudgetsJson")]
        public async Task<IHttpActionResult> GetBudgetsJson(int id)
        {
            var data = await db.GetBudgets(id);
            return Json(data, new JsonSerializerSettings { Formatting = Formatting.Indented });
        }

        //Get Budget Details
        [Route("GetBudgetDetail")]
        public async Task<Budgets> GetBudgetDetail(int id)
        {
            return await db.GetBudgetDetail(id);
        }

        [Route("GetBudgetDetailJson")]
        public async Task<IHttpActionResult> GetBudgetDetailJson(int id)
        {
            var data = await db.GetBudgetDetail(id);
            return Json(data, new JsonSerializerSettings { Formatting = Formatting.Indented });
        }

    }
}
