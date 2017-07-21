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
        // Getting cart.
        [HttpGet]
        public IEnumerable<int> GetMenu()
        {
            return (CartData.itemList);
        }

        // Getting total.
        [HttpGet]
        [Route("api/Cart/GetTotal")]
        public double GetTotal()
        {
            double tRe = 0;
            for(int i = 0; i < CartData.itemList.Count; i++)
            {
                tRe += MenuData.itemList[i].ItemPrice * CartData.itemList[i];
            }
            return (Math.Round(tRe * 100) / 100);
        }

        // Inserting item.
        [HttpPut]
        [Route("api/Cart/{id}")]
        public void ItemInsert(int id)
        {
            if (CartData.itemList[id] < 10) CartData.itemList[id]++;
        }

        // Removing item.
        [HttpDelete]
        [Route("api/Cart/{id}")]
        public void ItemRemove(int id)
        {
            CartData.itemList[id] = 0;
        }
    }
}
