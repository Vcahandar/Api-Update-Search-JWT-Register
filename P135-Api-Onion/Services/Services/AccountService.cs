using AutoMapper;
using Domain.Models;
using Microsoft.AspNetCore.Identity;
using Services.DTOs.Account;
using Services.Helpers;
using Services.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services
{
    public class AccountService : IAccountService
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly IMapper _mapper;
        public AccountService(UserManager<AppUser> userManager, RoleManager<IdentityRole> roleManager, IMapper mapper)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _mapper = mapper;
        }
        public async Task<AuthResponse> SignUpAsync(RegisterDto model)
        {
            AppUser user = _mapper.Map<AppUser>(model);
            IdentityResult result = await _userManager.CreateAsync(user, model.Password);
            if (!result.Succeeded)
                return new AuthResponse { StatusMessage = "Failed", Errors = result.Errors.Select(m => m.Description).ToList() };

            return new AuthResponse { Errors = null, StatusMessage = "Success" };
        }
    }
}
