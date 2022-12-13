using project_selection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace clean_adesk_collab_locs
{
    public partial class inputForm : Form
    {

        private void rCheckBoxRest()
        {
            checkBox_2020.Text = "2020";
            checkBox_2020.Update();
            checkBox_2021.Text = "2021";
            checkBox_2021.Update();
            checkBox_2022.Text = "2022";
            checkBox_2022.Update();
            checkBox_2023.Text = "2023";
            checkBox_2023.Update();
        }

        public inputForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Revit text box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Plant Text box
        /// </summary>
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// /Close Button
        /// </summary>
        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        string revitButtonsuccess = null;

        /// <summary>
        /// Revit Collab Button
        /// </summary>
        private void buttonRevit_Click(object sender, EventArgs e)
        {
            ////testing path
            //string revitFilePath = @"C:\Users\" + userName + @"\Documents\testing\clean_adesk_app\Revit";
            ////rveit collab caceh location
            string revitFilePath = @"C:\Users\" + Environment.UserName + @"\AppData\Local\Autodesk\Revit";

            List<string> revitYears = new List<string>();
            if (checkBox_2020.Checked)
            {
                revitYears.Add("2020");
            }
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
                                string completePath = revitFilePath + @"\AutoDesk Revit " + year + @"\CefCache";
                                delete_files.DeleteFiles.Revitdelete(completePath);
                            }
                            if (checkBoxCollabCache.Checked == true)
                            {
                                string completePath = revitFilePath + @"\AutoDesk Revit " + year + @"\CollaborationCache";
                                delete_files.DeleteFiles.Revitdelete(completePath);
                            }
                            if(checkBoxCefCache.Checked == false && checkBoxCollabCache.Checked == false)
                            {
                                MessageBox.Show("Neither the CefCache or Collabaoration Cache were checked. Only the CefCache will be cleared", "Missing Information");
                                string completePath = revitFilePath + @"\AutoDesk Revit " + year + @"\CefCache";
                                delete_files.DeleteFiles.Revitdelete(completePath);
                            }

                            if (year == "2020")
                            {
                                checkBox_2020.Text = year + " Cleared";
                                checkBox_2020.Update();
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
            plantProjects pform = new plantProjects();
            pform.ShowDialog();
            //try
            //{
            //    delete_files.DeleteFiles.Plantdelete(plantFilePath);
            //    buttonP3d.Text = "Done";
            //    buttonP3d.Update();
            //    Thread.Sleep(2000);
            //    buttonP3d.Text = "Clear";
            //    buttonP3d.Update();
            //}
            //catch (Exception ex_cache)
            //{
            //    MessageBox.Show(ex_cache.Message, "Error deleting Plant Cache files.");
            //}
        }

        private void checkBox_2020_CheckedChanged(object sender, EventArgs e)
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

        private void checkBoxCefCache_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxCollabCache_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void inputForm_Load(object sender, EventArgs e)
        {

        }
    }
}
