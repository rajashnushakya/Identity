using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace asp.netIdentityApp.Areas.Identity.Data;

// Add profile data for application users by adding properties to the aspnetIdentityAppUser class
public class aspnetIdentityAppUser : IdentityUser
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
}

