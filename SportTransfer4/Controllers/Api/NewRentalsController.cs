using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using SportTransfer4.Dtos;
using SportTransfer4.Models;

namespace SportTransfer4.Controllers.Api
{
    public class NewRentalsController : ApiController
    {
        private ApplicationDbContext _context;

        public NewRentalsController()
        {
            _context = new ApplicationDbContext();
        }

        [HttpPost]
        public IHttpActionResult CreateNewRentals(NewRentalDto newRental)
        {
            var customer = _context.Customers.Single(
                c => c.Id == newRental.CustomerId);

            var transfers = _context.Transfers.Where(
                m => newRental.TransferIds.Contains(m.Id));

            foreach (var transfer in transfers)
            {
                if (transfer.NumberAvailable == 0)
                    return BadRequest("Transfer is not available.");

                transfer.NumberAvailable--;

                var rental = new Rental
                {
                    Customer = customer,
                    Transfer = transfer,
                    DateRented = DateTime.Now
                };

                _context.Rentals.Add(rental);
            }

            _context.SaveChanges();

            return Ok();
        }
    }
}
