using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PartialViewExample.Models
{
    public class UserModel
    {
        [Key]
        public int UserId { get; set; }

        [DataType(DataType.Text)]
        [Required]
        public string UserName { get; set; }

        [DataType(DataType.Password)]
        [Required]
        public string UserPassword { get; set; }

    }
}