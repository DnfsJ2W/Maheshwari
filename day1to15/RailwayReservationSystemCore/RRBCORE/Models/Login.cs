using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace RRBCORE.Models
{
    public partial class Login
    {
        public int Id { get; set; }
        [Required]
        public string UserName { get; set; }
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
