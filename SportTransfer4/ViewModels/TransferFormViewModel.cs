using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SportTransfer4.Models;

namespace SportTransfer4.ViewModels
{
    public class TransferFormViewModel
    {
        public IEnumerable<Genre> Genres { get; set; }
        public Transfer Transfer { get; set; }
        public string Title
        {
            get
            {
                if (Transfer != null && Transfer.Id != 0)
                    return "Edit Transfer";

                return "New Transfer";
            }
        }
    }
}