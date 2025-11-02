using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Entities
{
    public class BorrowRecord
    {
        [Key]
        public int RecordID { get; set; }

        [ForeignKey("Book")]
        public int BookID { get; set; }

        [ForeignKey("Member")]
        public int MemberID { get; set; }

        public DateTime BorrowDate { get; set; } = DateTime.Now;
        public DateTime ReturnDate { get; set; }
        public bool IsReturned { get; set; } = false;

        //Navigation Props
        public virtual Book? Book { get; set; }
        public virtual Member? Member { get; set; }
    }
}
