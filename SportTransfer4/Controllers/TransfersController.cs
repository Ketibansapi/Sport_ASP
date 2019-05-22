using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SportTransfer4.Models;

namespace SportTransfer4.Controllers
{
    public class TransfersController : Controller
    {
        // GET: Transfers 
        public ActionResult Random()
        {
            var transfer = new Transfer() { Name = "Griffiths" };

            // return RedirectToAction("Index", "Home", new {page = 1, sortBy = "name"});

        //    ViewData["Transfer"] = transfer;

            return View(transfer);
        }

        /*       public ActionResult Edit (int id)
               {
                   return Content("id=" + id);
               }

               public ActionResult Index (int? pageIndex, string sortBy)
               {
                   if (!pageIndex.HasValue)
                       pageIndex = 1;
                   if (String.IsNullOrWhiteSpace(sortBy))
                       sortBy = "Name";

                   return Content(String.Format("pageIndex={0}&sortBy={1}", pageIndex, sortBy));
               }
       */

        /* [Route("transfers/released/{year}/{month:regex(\\d{4}):range(1, 12)}")]
           public ActionResult ByReleaseDate(int year, int month)
               {
                   return Content(year + "/" );
               }
        */

    }
}