using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP._2_after
{
 public class FileStore
    {
        readonly StoreLogger _log;

        public FileStore(DirectoryInfo workingDirectory)
        {
            if (workingDirectory == null)
            {
                throw new ArgumentNullException(nameof(workingDirectory));
            }
            if (workingDirectory.Exists == false)
            {
                throw new ArgumentException(nameof(workingDirectory));
            }
            _log = new StoreLogger();
        }
        public void Save(int id,string message)
        {
            
        }
    }
}
