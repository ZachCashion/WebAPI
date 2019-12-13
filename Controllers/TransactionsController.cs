using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

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


        //Get Transaction Details

    }
}
