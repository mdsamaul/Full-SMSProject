using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementSystem.Application.DTOs
{
    internal class LoginDto
    {
        public string? UserName { get; set; }
        public string? Email { get; set; }
        public string? StudentId { get; set; }
        public string Password { get; set; }
    }
}
