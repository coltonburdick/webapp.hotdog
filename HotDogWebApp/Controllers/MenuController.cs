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
    public class MenuController : ApiController
    {
        // Getting menu.
        [HttpGet]
        public IEnumerable<MenuItem> GetMenu()
        {
            return (MenuData.itemList);
        }

        // Delete.
        [HttpDelete]
        [Route("api/Menu/{id}")]
        public IHttpActionResult DeleteItemAtIndex(int id)
        {
            try
            {
                MenuData.itemList.RemoveAt(id);
            }
            catch (ArgumentOutOfRangeException e)
            {
                return (BadRequest($"Index is out of bounds. Index must be between 0 and {MenuData.itemList.Count - 1}."));
            }
            return (Ok(MenuData.itemList));
        }
    }
}
