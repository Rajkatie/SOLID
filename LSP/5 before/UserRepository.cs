using System;
using System.Collections.Generic;

namespace LSP._5_before
{

    public class EntityRepository
    {
        public virtual Entity GetUserById(Guid userId)
        {
            return new Entity();
        }

    }
    public class UserRepository: EntityRepository
    {
        IEnumerable<string> Ienustrings = new List<string>();
        IEnumerable<int> integers = new List<int>();

        public override Entity GetUserById(Guid userId)
        {
            IEnumerable<object> objects1 = Ienustrings;

            //IEnumerable<Object> objects = integers;
            return base.GetUserById(userId);
        }
    }
}
