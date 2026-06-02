using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dc_runreset
{
    //Code to stop the Desktop Connector process, run the reset utility, and restart the Desktop Connector process.

    class DCReset
    {
        public static void dcReset()
        {
            //path to the DC reset utility.
            string restUtilPath = @"C:\Program Files\Autodesk\Desktop Connector\Reset\ResetDesktopConnector.exe";
            //path to the Desktop Connector executable.
            string dcExePath = @"C:\Program Files\Autodesk\Desktop Connector\DesktopConnector.Applications.Tray.exe";

            //omit .exe when using GetProcessesByName
            String dcProcessNames = "DesktopConnector.Applications.Tray";
            Process[] dcProcessFound = Process.GetProcessesByName(dcProcessNames);

            if (dcProcessFound != null)
            {
                if (dcProcessFound.Length == 1 || dcProcessFound.Length == 0)
                {
                    //MessageBox.Show("Number of processes " + dcProcessFound.Length, "Process Count");
                    foreach (Process name in dcProcessFound)
                    {
                        //Kill the DC process if running
                        //MessageBox.Show("Kill DC", "Kill");
                        name.Kill();
                        //wait 10 seconds for the process to exit before disposing of it
                        name.WaitForExit();
                        ////Dispose is crashing the program for some reason. Commenting out for now.
                        //MessageBox.Show("Dispose DC", "Dispose");
                        //name.Dispose();
                        //name.WaitForExit(2000);
                        //MessageBox.Show("Done Killing Process", "DONE");
                    }
                    try
                    {
                        //Run the reset utility
                        //MessageBox.Show("Run Utility", "RestUtil");
                        using (Process resetProcess = Process.Start(restUtilPath, "-p"))
                        {
                            resetProcess.WaitForExit();
                        }
                        MessageBox.Show("Reset Complete. \nYou will need to resync any active projects.", "Results");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error running the rest utility");
                    }
                    try
                    {
                        //Restart the DC process
                        //MessageBox.Show("Restart dc", "Restart");
                        Process.Start(dcExePath);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error restarting the Desktop Connector process");
                    }
                }
                if (dcProcessFound.Length > 1)
                {
                    MessageBox.Show("Aborting: Too many Desktop Connector processes were found. Count is " + dcProcessFound.Length, "Warning: Mulitple Processes found");
                }
            }
            else
            {
                MessageBox.Show("Aborting: Process found was Null", "Warning: No Process found");
            }
        }
    }
  
}
