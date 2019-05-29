using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SportTransfer4.Models;
using System.ComponentModel.DataAnnotations;

namespace SportTransfer4.ViewModels
{
    public class TransferFormViewModel
    {
        public IEnumerable<Genre> Genres { get; set; }
        public int? Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [Display(Name = "Genre")]
        [Required]
        public byte? GenreId { get; set; }

        [Display(Name = "Release Date")]
        [Required]
        public DateTime? ReleaseDate { get; set; }

        [Display(Name = "Number in Stock")]
        [Range(1, 20)]
        [Required]
        public byte? NumberInStock { get; set; }

        public string Title
        {
            get
            {
                return Id != 0 ? "Edit Transfer" : "New Transfer";
            }
        }

        public TransferFormViewModel()
        {
            Id = 0;
        }

        public TransferFormViewModel(Transfer transfer)
        {
            Id = transfer.Id;
            Name = transfer.Name;
            ReleaseDate = transfer.ReleaseDate;
            NumberInStock = transfer.NumberInStock;
            GenreId = transfer.GenreId;
        }
    }
}