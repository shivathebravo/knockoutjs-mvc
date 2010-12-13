using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Knockout.Mvc.Integration.Web.Model
{
    public class UserDetails
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
    }

    public class UserDetailsEx : UserDetails
    {
        public List<string> Skills { get; set; }
    }
}