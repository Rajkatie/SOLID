using System;
using System.IO;

namespace SRP._2_before
{
    public  class FileStore
    {
        public FileStore(DirectoryInfo workingDirectory)
        {
            if (workingDirectory==null)
            {
                throw new ArgumentNullException(nameof(workingDirectory));
            }
            if (workingDirectory.Exists==false)
            {
                throw new ArgumentException(nameof(workingDirectory));
            }
        }

        public DirectoryInfo WorkingDirectory { get; }

        public void Save(int id, string message)
        {
            Log.Information("saving information");

            //GetFileInfo(id);
            //File.WriteAllText(, message);

            Log.Information($"saved message {id}");

        }
    }
}
