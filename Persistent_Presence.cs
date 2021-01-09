using System;
using System.Diagnostics;

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
        public void duplicate_executables()
        {
            // Create folder in "Program Files" and store executable.
            string current_path_location = @"C:\Users\Anthony\source\repos\Persistent_Presence\bin\Debug\netcoreapp3.1\temp";
            if (!System.IO.Directory.Exists(current_path_location))
            {
                System.IO.Directory.CreateDirectory(current_path_location);
                Debug.WriteLine("[+] Creating \"{0}\"", current_path_location);
            }
        }
    }
}
