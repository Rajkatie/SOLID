using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP._5_before
{
   public class Entity
    {
        public Guid UserId { get; set; }

        public string Name { get; set; }
    }

    public class User: Entity
    {
        public string EmailAddress { get; set; }

        public DateTime DateOfBirth { get; set; }
    }
}
