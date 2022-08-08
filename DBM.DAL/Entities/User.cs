using System;
using Microsoft.AspNetCore.Identity;

namespace DBM.DAL.Entities
{
	public class User : IdentityUser
	{
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Avatar { get; set; }
    }
}

