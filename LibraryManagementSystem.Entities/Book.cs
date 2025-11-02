using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Entities
{
    public class Book
    {
        [Key]
        public int BookID { get; set; }

        [Required, StringLength(100)]
        public string? Title { get; set; }

        [Required, StringLength(100)]
        public string? Author { get; set; }

        [StringLength(100)]
        public string? Publisher { get; set; }

        public int Year { get; set; }

        public bool IsAvailable { get; set; } = true;
    }
}
