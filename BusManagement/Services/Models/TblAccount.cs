﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Services.Models
{
    public partial class TblAccount
    {
        public string AccountId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string FullName { get; set; }
        public DateTime? Dob { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Role { get; set; }
        public bool? IsActive { get; set; }
    }
}
