using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using GapShoes.Models;

namespace GapShoes.Controllers
{
    [Authorize]
    public class StoresAPIController : ApiController
    {
        private GapShoesContext db = new GapShoesContext();

        // GET: api/StoresAPI
        public IQueryable<Stores> GetStores()
        {
            return db.Stores;
        }

        // GET: api/StoresAPI/5
        [ResponseType(typeof(Stores))]
        public async Task<IHttpActionResult> GetStores(int id)
        {
            Stores stores = await db.Stores.FindAsync(id);
            if (stores == null)
            {
                return NotFound();
            }

            return Ok(stores);
        }        

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool StoresExists(int id)
        {
            return db.Stores.Count(e => e.StoreID == id) > 0;
        }
    }
}