using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SportTransfer4.Models;
using SportTransfer4.ViewModels;

namespace SportTransfer4.Controllers
{
    public class TransfersController : Controller
    {
        
        public ViewResult Index()
        {
            var transfers = GetTransfers();

            return View(transfers);
        }

        private IEnumerable<Transfer> GetTransfers()
        {
            return new List<Transfer>
            {
                new Transfer { Id = 1, Name = "Node"},
                new Transfer { Id = 2, Name = "Miaw"}
            };
        }

    }
}