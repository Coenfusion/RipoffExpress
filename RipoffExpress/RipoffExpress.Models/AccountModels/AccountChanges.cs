using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RipoffExpress.Models.AccountModels
{
    public class AccountChanges
    {
        public int Id { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        public string Username { get; set; }

        [Required]
        [Display(Name = "Current Password")]
        [DataType(DataType.Password)]
        public string CurrentPassword { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Current Password")]
        public string NewPassword { get; set; }
    }
}
