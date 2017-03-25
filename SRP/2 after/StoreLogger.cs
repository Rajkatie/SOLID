using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP._2_after
{
   public class StoreLogger
    {
        public void Saving(int id)
        {
            Log.Information($"Saving message {1}.");
        }
        public void Saved(int id)
        {
            Log.Information($"Saved message {1}.");
        }
    }
}
