﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Data.Entity;
using AutoMapper;
using SportTransfer4.Models;
using SportTransfer4.Dtos;

namespace SportTransfer4.Controllers.Api
{
    public class TransfersController : ApiController
    {
        private ApplicationDbContext _context;

        public TransfersController()
        {
            _context = new ApplicationDbContext();
        }

        public IEnumerable<TransferDto> GetTransfers(string query = null )
        {
            var transfersQuery = _context.Transfers
                .Include(m => m.Genre)
                .Where(m => m.NumberAvailable > 0);

            if (!String.IsNullOrWhiteSpace(query))
                transfersQuery = transfersQuery.Where(m => m.Name.Contains(query));

            return transfersQuery
                .ToList()
                .Select(Mapper.Map<Transfer, TransferDto>);
        }

        public IHttpActionResult GetTransfer(int id)
        {
            var transfer = _context.Transfers.SingleOrDefault(c => c.Id == id);

            if (transfer == null)
                return NotFound();

            return Ok(Mapper.Map<Transfer, TransferDto>(transfer));
        }

        [HttpPost]
        public IHttpActionResult CreateTransfer(TransferDto transferDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var transfer = Mapper.Map<TransferDto, Transfer>(transferDto);
            _context.Transfers.Add(transfer);

            _context.SaveChanges();

            transferDto.Id = transfer.Id;
            return Created(new Uri(Request.RequestUri + "/" + transfer.Id), transferDto);
        }

        [HttpPut]
        public IHttpActionResult UpdateTransfer(int id, TransferDto transferDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var transferInDb = _context.Transfers.SingleOrDefault(c => c.Id == id);

            if (transferInDb == null)
                return NotFound();

            Mapper.Map(transferDto, transferInDb);

            _context.SaveChanges();

            return Ok();
        }

        [HttpDelete]
        public IHttpActionResult DeleteTransfer(int id)
        {
            var transferInDb = _context.Transfers.SingleOrDefault(c => c.Id == id);

            if (transferInDb == null)
                return NotFound();

            _context.Transfers.Remove(transferInDb);
            _context.SaveChanges();

            return Ok();
        }
    }
}
