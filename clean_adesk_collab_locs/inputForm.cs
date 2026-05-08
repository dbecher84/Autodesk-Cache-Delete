using project_selection;
using System;
using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
using System.IO;
//using System.Linq;
//using System.Linq.Expressions;
//using System.Net.NetworkInformation;
//using System.Text;
using System.Threading;
//using System.Threading.Tasks;
using System.Windows.Forms;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
//using System.Diagnostics;

namespace clean_adesk_collab_locs
{
    public partial class inputForm : Form
    {

        private void rCheckBoxRest()
        {
            checkBox_2021.Text = "2021";
            checkBox_2021.Update();
            checkBox_2022.Text = "2022";
            checkBox_2022.Update();
            checkBox_2023.Text = "2023";
            checkBox_2023.Update();
            checkBox_2024.Text = "2024";
            checkBox_2024.Update();
            checkBox_2025.Text = "2025";
            checkBox_2025.Update();
            checkBox_2026.Text = "2026";
            checkBox_2026.Update();
            checkBox_2027.Text = "2027";
            checkBox_2027.Update();
            checkBox_2028.Text = "2028";
            checkBox_2028.Update();
        }

        public inputForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        string revitButtonsuccess = null;

        private void buttonRevit_Click(object sender, EventArgs e)
        {
            ////testing path
            //string revitFilePath = @"C:\Users\" + userName + @"\Documents\testing\clean_adesk_app\Revit";
            ////revit collab cache location
            ////Don't use Environment.UserName as this can be different from the name used in the path
            //string revitFilePath = @"C:\Users\" + Environment.UserName + @"\AppData\Local\Autodesk\Revit";

            string revitFilePath = Environment.GetEnvironmentVariable("LocalAppData") + @"\Autodesk\Revit";
            //Environment.LocalAppData + @"\Autodesk\Revit"

            List<string> revitYears = new List<string>();
            if (checkBox_2021.Checked)
            {
                revitYears.Add("2021");
            }
            if (checkBox_2022.Checked)
            {
                revitYears.Add("2022");
            }
            if (checkBox_2023.Checked)
            {
                revitYears.Add("2023");
            }
            if (checkBox_2024.Checked)
            {
                revitYears.Add("2024");
            }
            if (checkBox_2025.Checked)
            {
                revitYears.Add("2025");
            }
            if (checkBox_2026.Checked)
            {
                revitYears.Add("2026");
            }
            if (checkBox_2027.Checked)
            {
                revitYears.Add("2027");
            }
            if (checkBox_2028.Checked)
            {
                revitYears.Add("2028");
            }

            if (revitYears.Count > 0)
            {
                try
                {
                    foreach (string year in revitYears)
                    {
                        try
                        {
                            if (checkBoxCefCache.Checked == true)
                            {
                                string cefPath = revitFilePath + @"\Autodesk Revit " + year + @"\CefCache";
                                //MessageBox.Show(cefPath, "Path");
                                delete_files.DeleteFiles.Revitdelete(cefPath);
                            }
                            if (checkBoxCollabCache.Checked == true)
                            {
                                string collabPath = revitFilePath + @"\Autodesk Revit " + year + @"\CollaborationCache";
                                //MessageBox.Show(collabPath, "Path");
                                delete_files.DeleteFiles.Revitdelete(collabPath);
                            }
                            if(checkBoxCefCache.Checked == false && checkBoxCollabCache.Checked == false)
                            {
                                MessageBox.Show("Neither the CefCache or Collabaoration Cache were checked. Only the CefCache will be cleared", "Missing Information");
                                string cefPath2 = revitFilePath + @"\Autodesk Revit " + year + @"\CefCache";
                                //MessageBox.Show(cefPath2, "Path");
                                delete_files.DeleteFiles.Revitdelete(cefPath2);
                            }

                            if (year == "2021")
                            {
                                checkBox_2021.Text = year + " Cleared";
                                checkBox_2021.Update();
                            }
                            if (year == "2022")
                            {
                                checkBox_2022.Text = year + " Cleared";
                                checkBox_2022.Update();
                            }
                            if (year == "2023")
                            {
                                checkBox_2023.Text = year + " Cleared";
                                checkBox_2023.Update();
                            }
                            if (year == "2024")
                            {
                                checkBox_2024.Text = year + " Cleared";
                                checkBox_2024.Update();
                            }
                            if (year == "2025")
                            {
                                checkBox_2025.Text = year + " Cleared";
                                checkBox_2025.Update();
                            }
                            if (year == "2026")
                            {
                                checkBox_2026.Text = year + " Cleared";
                                checkBox_2026.Update();
                            }
                            if (year == "2027")
                            {
                                checkBox_2027.Text = year + " Cleared";
                                checkBox_2027.Update();
                            }
                            if (year == "2028")
                            {
                                checkBox_2028.Text = year + " Cleared";
                                checkBox_2028.Update();
                            }
                        }
                        catch (System.IO.DirectoryNotFoundException)
                        {
                            MessageBox.Show("File or Directory Path does not exists.", "Error deleting " + year + " files");
                        }
                        catch (Exception ex_year)
                        {
                            MessageBox.Show(ex_year.Message, "Error deleting " + year + " files");
                        }
                        //buttonRevit.Text = "Done";
                        //buttonRevit.Update();
                        //Thread.Sleep(3000);
                        //buttonRevit.Text = "Clear";
                        //buttonRevit.Update();
                    }
                    //rCheckBoxRest();

                }
                catch (Exception ex_cache)
                {
                    MessageBox.Show(ex_cache.Message, "Error deleting Revit cache files.");
                }
                revitButtonsuccess = "success";
            }
            else
            {
                MessageBox.Show("A Revit year was not selected", "Missing Information");
            }
            if (revitButtonsuccess == "success")
            {
                Thread.Sleep(2000);
                rCheckBoxRest();
            }
        }

        /// <summary>
        /// Plant Collab Button
        /// </summary>
        private void buttonP3d_Click(object sender, EventArgs e)
        {
            ////testing path
            //string plantFilePath = @"C:\Users\" + userName + @"\Documents\testing\clean_adesk_app\Plant 3D";
            ////plant collab cache location
            //string plantFilePath = @"C:\Users\" + userName + @"\AppData\Local\Autodesk\AutoCAD Plant 3D\CollaborationCache";

            //var directories = Directory.GetDirectories(plantFilePath);
            //foreach (string direct in directories)
            //{
            //    MessageBox.Show(direct, "direcotries found");
            //}

            String plantFilePath = Environment.GetEnvironmentVariable("LocalAppData") + @"\Autodesk\AutoCAD Plant 3D\CollaborationCache\";
            if (Directory.Exists(plantFilePath))
            {
                plantProjects pform = new plantProjects(plantFilePath);
                pform.ShowDialog();
            }
            else
            {
                MessageBox.Show("The Plant 3D Collaboration Cache does not exist.", "Plant Collaboration Cache");
            }

        }

        private void checkBox_2026_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox_2021_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox_2022_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox_2023_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void checkBox_2024_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void checkBox_2025_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void checkBox_2027_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox_2028_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxCefCache_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxCollabCache_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void inputForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void buttonPAC_Click(object sender, EventArgs e)
        {
            string pacFilePath = Environment.GetEnvironmentVariable("LocalAppData") + @"\Autodesk\Revit\PacCache";
            paccache_clean.PacCleaning.PacClean(pacFilePath);
        }

        private void buttonDC_Click(object sender, EventArgs e)
        {
            dc_runreset.DCReset.dcReset();
        }
    }
}
