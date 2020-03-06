using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Globalization.Models
{
    public class UserModel
    {
        [Key]

        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Adress { get; set; }
        

    }
}

