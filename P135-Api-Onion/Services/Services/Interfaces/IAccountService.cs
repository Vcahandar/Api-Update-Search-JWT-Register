﻿using Services.DTOs.Account;
using Services.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services.Interfaces
{
    public interface IAccountService
    {
        Task<AuthResponse> SignUpAsync(RegisterDto model);
    }
}
