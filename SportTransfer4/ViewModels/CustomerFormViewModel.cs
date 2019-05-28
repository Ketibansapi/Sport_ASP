using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SportTransfer4.Models;

namespace SportTransfer4.ViewModels
{
    public class CustomerFormViewModel
    {
        public IEnumerable<MembershipType> MembershipTypes { get; set; }
        public Customer Customer { get; set; }
    }
}