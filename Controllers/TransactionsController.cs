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
    [RoutePrefix("api/Transactions")]
    public class TransactionsController : BaseController
    {
        //Add Transaction
        [HttpPost]
        [Route("AddTransaction")]
        public IHttpActionResult AddTransaction(int budgetId, int bankAccId, string ownerId, string amount, string memo, bool dipositWithdraw, int transactionCatagory)
        {
            return Ok(db.AddTransaction( budgetId, bankAccId, ownerId, amount, memo, dipositWithdraw, transactionCatagory));
        }

        //Get Transactions
        [Route("GetTransactions")]
        public async Task<List<Transactions>> GetTransactions(int id)
        {
            return await db.GetTransactions(id);
        }

        [Route("GetTransactionsJson")]
        public async Task<IHttpActionResult> GetTransactionsJson(int id)
        {
            var data = await db.GetTransactions(id);
            return Json(data, new JsonSerializerSettings { Formatting = Formatting.Indented });
        }

        //Get Transaction Details
        [Route("GetTransactionDetail")]
        public async Task<Transactions> GetTransactionDetail(int id)
        {
            return await db.GetTransactionDetail(id);
        }

        [Route("GetTransactionDetailJson")]
        public async Task<IHttpActionResult> GetTransactionDetailJson(int id)
        {
            var data = await db.GetTransactionDetail(id);
            return Json(data, new JsonSerializerSettings { Formatting = Formatting.Indented });
        }

    }
}
