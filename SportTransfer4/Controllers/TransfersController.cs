using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SportTransfer4.Migrations;
using SportTransfer4.Models;
using SportTransfer4.ViewModels;

namespace SportTransfer4.Controllers
{
    public class TransfersController : Controller
    {
        private ApplicationDbContext _context;

        public TransfersController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ViewResult Index()
        {
            var transfers = _context.Transfers.Include(m => m.Genre).ToList();

            return View(transfers);
        }

        public ViewResult New()
        {
            var genres = _context.Genres.ToList();

            var viewModel = new TransferFormViewModel
            {
                Genres = genres
            };

            return View("TransferForm", viewModel);
        }

        public ActionResult Edit(int id)
        {
            var transfer = _context.Transfers.SingleOrDefault(c => c.Id == id);

            if (transfer == null)
                return HttpNotFound();

            var viewModel = new TransferFormViewModel
            {
                Transfer = transfer,
                Genres = _context.Genres.ToList()
            };

            return View("TransferForm", viewModel);
        }

        public ActionResult Details(int id)
        {
            var transfer = _context.Transfers.Include(m => m.Genre).SingleOrDefault(m => m.Id == id);

            if (transfer == null)
                return HttpNotFound();

            return View(transfer);
        }

     //   [HttpPost]
     //   public ActionResult Save(Transfer transfer)

    }
}