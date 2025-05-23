using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs.Request
{
    public class UserLoginDTO
    {
        [Required]
        public string? Email { get; set; }

        public string? Password { get; set; }
    }
}
