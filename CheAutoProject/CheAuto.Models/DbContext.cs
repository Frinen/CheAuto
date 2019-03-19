using System;
using CheAuto.Models.Schema;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;


namespace CheAuto.Models
{
    public class DbContext : IdentityDbContext<User,Role,Guid>
    {

    }
}
