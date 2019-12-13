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
    [RoutePrefix("api/BankAccounts")]
    public class BankAccountController : BaseController
    {
        //Add BankAccount ================================================================================================================================
        [HttpPost]
        [Route("AddBankAccount")]
        public IHttpActionResult AddBankAccount(int hhId, string ownerId, string name, string start, string current, int accountType)
        {
            return Ok(db.AddBankAccount( hhId, ownerId, name, start, current, accountType));
        }

        //Get BankAccounts ==========================================================================================================================
        [Route("GetBankAccounts")]
        public async Task<List<BankAccounts>> GetBankAccounts(int id)
        {
            return await db.GetBankAccounts(id);
        }

        [Route("GetBankAccountsJson")]
        public async Task<IHttpActionResult> GetBankAccountsJson(int id)
        {
            var data = await db.GetBankAccounts(id);
            return Json(data, new JsonSerializerSettings { Formatting = Formatting.Indented });
        }

        //Get BankAccount Details ==========================================================================================================================
        [Route("GetHousehold")]
        public async Task<BankAccounts> GetBankAccountDetail(int id)
        {
            return await db.GetBankAccountDetail(id);
        }

        [Route("GetBankAccountDetailJson")]
        public async Task<IHttpActionResult> GetBankAccountDetailJson(int id)
        {
            var data = await db.GetBankAccountDetail(id);
            return Json(data, new JsonSerializerSettings { Formatting = Formatting.Indented });
        }
    }
}
