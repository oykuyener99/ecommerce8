using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.DTOs
{
    public class UserDto
    {
        public string Email { get; set; }
        public string DisplayName { get; set; }
        public string Role { get; set; }
        public string Token { get; set; }
    }
}