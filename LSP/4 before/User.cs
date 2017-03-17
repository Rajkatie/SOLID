using System.Collections.Generic;

namespace LSP._4_before
{
    public class User
    {
        public string Email { get; private set; }
     
        protected Dictionary<string,string> Setting { get; set; }
        public User(string email)
        {
            Email = email;

        }

    }

    public class Admin: User
    {
        public Admin(string email):base(email)
        {
            
        }


    }
}
