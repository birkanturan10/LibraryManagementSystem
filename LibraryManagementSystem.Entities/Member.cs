using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Entities
{
    public class Member
    {
        [Key]
        public int MemberID { get; set; }

        [Required, StringLength(100)]
        public string? Name { get; set; }

        [Required, StringLength(100)]
        public string? Surname { get; set; }

        [StringLength(20)]
        public string? Phone { get; set; }

        [StringLength(100)]
        public string? Email { get; set; }

        public DateTime RegisterDate { get; set; } = DateTime.Now;
    }
}
