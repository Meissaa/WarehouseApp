﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Warehouse.Services.Models.Auth
{
    public class LoginRequest
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}