using System;
using Microsoft.AspNetCore.Identity;

namespace CheAuto.Models.Schema
{
    public class User : IdentityUser<Guid>
    {
        public UserOrder UserOrder{ get; set; }
        public Guid UserOrderId { get; set; }

        public Role Role { get; set; }
        public Guid RoleId { get; set; }

        public string Name { get; set; }
        public string LastName { get; set; }
    }
}
