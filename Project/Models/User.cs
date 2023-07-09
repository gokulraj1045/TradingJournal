using System;
using System.Collections.Generic;

namespace Project.Models
{
    public partial class User
    {
        public int UserdId { get; set; }
        public string? Fullname { get; set; }
        public string? Password { get; set; }
        public string? Email { get; set; }
    }
}
