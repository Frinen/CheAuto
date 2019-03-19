using System;
using CheAuto.Models.Schema.Common;
using Microsoft.AspNetCore.Identity;

namespace CheAuto.Models.Schema
{
    public class Role : IdentityRole<Guid>
    {
        public User User { get; set; }
    }
}
