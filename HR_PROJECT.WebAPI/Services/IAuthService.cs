﻿using HR_PROJECT.WebAPI.DTOs.ApplicationUserDTOs;

namespace HR_PROJECT.WebAPI.Services
{
    public interface IAuthService
    {
        Task<(int, string)> Login(LoginApplicationUserDTO dto);
        Task<(int, string)> ResetPassword(ChangePasswordForResetDTO dto);
        Task<(int, CreateUserResponseDTO)> CreateUser(CreateApplicationUserDTO dto);
    }
}
