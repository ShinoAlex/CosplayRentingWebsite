using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infactructure.Repositories.Interface
{
    public interface IAuthRepository
    {
        string GenerateJwtToken(string user);
        Task<string?> GetUserIdByRefeshTokenAsync(Guid refeshToken);

    }
}
