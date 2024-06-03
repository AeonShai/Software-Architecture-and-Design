using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLayer.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public string RePassword { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime DateOfRegister { get; set; } = DateTime.Now;
        public string Role { get; set; }

    }
}
