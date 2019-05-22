using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SportTransfer4.Models;

namespace SportTransfer4.ViewModels
{
    public class RandomTransferViewModel
    {
        public Transfer Transfer { get; set; }
        public List<Customer> Customers { get; set; }
    }
}