using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LOGINCORE.Models
{
    public class Login
    {
        [Required]
        [Display(Name ="enter username")]
        public string User { get; set; }


        [Required]
        [Display(Name ="display password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

    }
}
