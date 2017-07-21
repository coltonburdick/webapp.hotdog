using HotDogWebApp.App_Start;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using HotDogDAO;

namespace HotDogWebApp.Controllers
{
    [EnableCors(origins:"*", headers:"*", methods:"*")]
    public class CartController : ApiController
    {
    }
}
