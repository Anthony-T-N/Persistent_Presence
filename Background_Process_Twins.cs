using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading;

namespace Persistent_Presence
{
    class Background_Process_Twin
    {
        public bool check_processes()
        {
            Process[] allProcesses = Process.GetProcesses();
            bool process_alive = false;
            int counter = 0, kill_switch_counter = 0;
            Debug.WriteLine("=================================================================================");
            for (int i = 0; i <= allProcesses.Length - 1; i++)
            {
                if (allProcesses[i].ToString().Contains("Persistent_Presence"))
                {
                    Debug.WriteLine(allProcesses[i].ToString().Substring(27));
                    Debug.WriteLine("[*] Twin Process Is Alive");
                    counter++;
                }
                else if (allProcesses[i].ToString().Contains("notepad"))
                {
                    Debug.WriteLine("[*] Notepad Found. Counter: " + kill_switch_counter);
                    kill_switch_counter++;
                    if (kill_switch_counter >= 2)
                    {
                        kill_switch();
                    }
                }
            }
            if (counter >= 2)
            {
                process_alive = true;
            }
            return process_alive;
        }
        public void execute_twin_process()
        {
            Process process = new Process();
            string exe_location = Directory.GetCurrentDirectory() + @"\Persistent_Presence.exe";
            Debug.WriteLine(exe_location);
            process.StartInfo.FileName = exe_location;
            process.StartInfo.UseShellExecute = true;
            process.Start();
            Debug.WriteLine("[+] Twin Process Executed");
        }
        public void kill_switch()
        {
            Debug.WriteLine("[+] Kill Switch Activated");
            System.Environment.Exit(0);
        }
    }
}
