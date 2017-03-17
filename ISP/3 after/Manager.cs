using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP._3_after
{
   public class Manager
    {
        IWorker _worker;
        public void setWorker(IWorker worker)
        {
            _worker = worker;
        }

        public void manage()
        {
            _worker.Work();
        }
    }
}
