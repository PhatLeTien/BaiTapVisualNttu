using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Login_Logout_SignUp.Models
{
    public class UserModel
    {
        public int ID { get; set; }
        public string UserName { get; set; }
        public string UserPassword { get; set; }
    }
}