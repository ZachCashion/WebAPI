using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    public abstract class BaseController : ApiController
    {
        protected ApiContext db = new ApiContext();
    }
}
