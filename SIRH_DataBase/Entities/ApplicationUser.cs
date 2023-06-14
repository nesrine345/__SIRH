using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace SIRH_DataBase.Entities
{
    public class ApplicationUser : IdentityUser
    {
        public string DisplayName { get; set; }

    }
}
