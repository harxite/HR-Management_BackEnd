﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_PROJECT.WebAPI.DTOs.ApplicationUserDTOs
{
    public class LoginApplicationUserDTO
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string? OneTimeCode { get; set; }
    }
}
