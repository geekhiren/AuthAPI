using System;
using System.Collections.Generic;

namespace AuthLogin.Models
{
    public class AccountViewModel
    {
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }


        public string LoggedOn { get; set; }
    }
}
