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
    public class ArticlesAPIController : ApiController
    {
        private GapShoesContext db = new GapShoesContext();

        // GET: api/ArticlesAPI/GetArticles
        public HttpResponseMessage GetArticles()
        {
            List<Articles> _articles = db.Articles.ToList();

            return Request.CreateResponse(HttpStatusCode.OK, _articles, Configuration.Formatters.JsonFormatter);            
        }

        // GET: services/ArticlesAPI/GetArticles/5
        [ResponseType(typeof(Articles))]
        public async Task<IHttpActionResult> GetArticles(int id)
        {
            Articles articles = await db.Articles.FindAsync(id);
            if (articles == null)
            {
                return NotFound();
            }

            return Ok(articles);
        }

        // GET: service/ArticlesAPI/Stores/1 
        [HttpGet]
        public HttpResponseMessage Stores(int id)
        {
            List<Articles> _articles = (from a in db.Articles
                                        where a.StoreID == id
                                        select a).ToList();

            if (_articles != null)
                return Request.CreateResponse(HttpStatusCode.OK, _articles, Configuration.Formatters.JsonFormatter);
            else
                return Request.CreateResponse(HttpStatusCode.NoContent);
        }


        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ArticlesExists(int id)
        {
            return db.Articles.Count(e => e.ArticleID == id) > 0;
        }
    }
}