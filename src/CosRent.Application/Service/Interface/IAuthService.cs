using Application.DTOs.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Service.Interface
{
    public interface IAuthService
    {
        Task<(string, string?)> RegisterAsync(UserRegisterDTO requestBody, string role);
        Task<(string, string?)> LgoinAsync(UserLoginDTO requestBody);

    }
}
