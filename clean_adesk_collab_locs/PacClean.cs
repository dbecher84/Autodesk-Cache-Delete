using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;



namespace paccache_clean
{
    class PacCleaning
    {
        static string accelProcFound = "no";

        public static void StopRevAccel()
        {
            string foundProc = "no";

            Process[] testprocess = Process.GetProcesses();
            foreach (var proc in testprocess)
            {
                if (foundProc == "no" && proc.ProcessName == "RevitAccelerator")
                {
                    proc.Kill();
                    proc.WaitForExit();
                    proc.Dispose();
                    //MessageBox.Show("stopped", "yay");
                    accelProcFound = "yes";   
                }
            }
        }

        public static string StartRevAccel()
        {
            try
            {
                string RevAccelPath = @"C:\Program Files\Autodesk\Personal Accelerator for Revit\";
                string RevAccelFile = "RevitAccelerator.exe";

                Thread.Sleep(2000);

                Process.Start(RevAccelPath + RevAccelFile);
                //MessageBox.Show("started", "yay");
                return ("good");
            }
            catch (Exception ex)
            {
                MessageBox.Show( ex.ToString(), "The Revit Personal Accelereator did not succussfull start");
                return ("bad");
            }
        }

        public static void PacClean(string inputFilePath)
        {
            StopRevAccel();

            try
            {
                if (accelProcFound == "yes")
                {
                    delete_files.DeleteFiles.Pacdelete(inputFilePath);

                    StartRevAccel();
                }
                if (accelProcFound == "no")
                {
                    MessageBox.Show("Attempting to delete PacCache anyway.", "Revit Accelerator Process not found.");

                    delete_files.DeleteFiles.Pacdelete(inputFilePath);

                    StartRevAccel();
                }
            }
            catch (Exception ex2) 
            {
                MessageBox.Show(ex2.ToString(), "Error deleting PacCache folder");
            }
            
        }
    }
}
