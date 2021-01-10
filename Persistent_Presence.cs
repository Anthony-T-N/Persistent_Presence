using System;
using System.Diagnostics;
using System.IO;

namespace Persistent_Presence
{
    class Persistent_Presence
    {
        public bool check_executable_placement()
        {
            if (!System.IO.Directory.Exists(""))
            {
                return true;
            }
            else
            {
                return false;
            }    
        }
        public void check_executable_location()
        {
            // Create folder in "Program Files" and store executable.
            string primary_path_location = @"C:\Users\Anthony\source\repos\Persistent_Presence\bin\Debug\netcoreapp3.1\temp";
            if (!System.IO.Directory.Exists(primary_path_location))
            {
                System.IO.Directory.CreateDirectory(primary_path_location);
                Debug.WriteLine("[+] Creating \"{0}\"", primary_path_location);
            }
            string seconday_path_location = @"C:\Users\Anthony\Desktop\temp";
            if (!System.IO.Directory.Exists(seconday_path_location))
            {
                System.IO.Directory.CreateDirectory(seconday_path_location);
                Debug.WriteLine("[+] Creating \"{0}\"", seconday_path_location);
            }
        }
        public void duplicate_executables()
        {
            File.Copy(source, dest);
        }
    }
}
