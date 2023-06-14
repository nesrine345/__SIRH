using System;
using System.Collections.Generic;
using System.Text;

namespace SIRH_Infrastructure.Mediator.UserMediator
{
    public class UserDto
    {
        public int Id { get; set; }

        public string UserName { get; set; }

        public string PasswordHash { get; set; }

        public string Email { get; set; }

        public string FirstName { get; set; }

        public string MiddleInitial { get; set; }

        public string LastName { get; set; }

    }
}
