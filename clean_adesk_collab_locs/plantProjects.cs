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

namespace project_selection
{
    public partial class plantProjects : Form
    {
        ////Don't use Environment.UserName as this can be different from the name used in the path
        //public String plantFilePath = @"C:\Users\" + Environment.UserName + @"\AppData\Local\Autodesk\AutoCAD Plant 3D\CollaborationCache\";

        public String plantFilePath = Environment.GetEnvironmentVariable("LocalAppData") + @"\Autodesk\AutoCAD Plant 3D\CollaborationCache\";

        public plantProjects()
        {
            InitializeComponent();
            
            var directories = Directory.GetDirectories(plantFilePath);
            if (directories.Length > 0)
            {
                foreach (string dPath in directories)
                {
                    DirectoryInfo getFileName = new DirectoryInfo(dPath);
                    String folderName = getFileName.Name.ToString();
                    projectsfound.Items.Add(folderName.ToString());
                    //MessageBox.Show(folderName, "directories found");
                }
            }
            else
            {
                projectsfound.Items.Add("No Projects Found");
            }
        }

        private void projectsfound_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void projectsdelete_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        //Delete projects
        private void button1_Click(object sender, EventArgs e)
        {
            if (projectsdelete.Items.Count > 0)
            {
                List<string> deletedItems = new List<string>();

                foreach (string projectSelected in projectsdelete.Items)
                {
                    //MessageBox.Show(projectSelected, "Path");
                    try
                    {
                        string deletePath = plantFilePath + projectSelected;
                        //MessageBox.Show(deletePath, "Path");
                        delete_files.DeleteFiles.Plantdelete(deletePath);
                        deletedItems.Add(projectSelected);

                    }
                    catch (Exception ex_cache)
                    {
                        MessageBox.Show(ex_cache.Message, "Error deleting Plant Cache files.");
                    }
                }
                projectsdelete.Items.Clear();
                MessageBox.Show(deletedItems.Count + " Projects Successfully Deleted", "Results");
            }
            else
            {
                MessageBox.Show("No Projects were Selected.", "Results");
            }
        }

        //close window
        private void button2_Click(object sender, EventArgs e)
        {

        }

        //add project to delete list
        private void button3_Click(object sender, EventArgs e)
        {
            List<string> removed = new List<string>();

            if (projectsfound.SelectedItems.Count > 0)
            {
                foreach (string project in projectsfound.SelectedItems)
                {
                    if (projectsdelete.Items.Contains(project) == false)
                    {
                        projectsdelete.Items.Add(project);
                        removed.Add(project);
                    }
                }
            }
            else
            {
                MessageBox.Show("No Projects were Selected.", "Results");
            }

            foreach (string item2 in removed)
            {
                projectsfound.Items.Remove(item2);
            }
        }

        //add all project to delete list
        private void button4_Click(object sender, EventArgs e)
        {
            List<string> removed2 = new List<string>();

            foreach (string item in projectsfound.Items)
            {
                projectsdelete.Items.Add(item);
                removed2.Add(item);
            }
            foreach (string item in removed2)
            {
                projectsfound.Items.Remove(item);
            }
        }

        //clear delete list
        private void button5_Click(object sender, EventArgs e)
        {
            if (projectsdelete.Items.Count > 0)
            {
                foreach (string item3 in projectsdelete.Items)
                {
                    projectsfound.Items.Add(item3);
                }
            }
            projectsdelete.Items.Clear();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            List<string> removed = new List<string>();

            if (projectsdelete.SelectedItems.Count > 0)
            {
                foreach (string project in projectsdelete.SelectedItems)
                {
                    if (projectsfound.Items.Contains(project) == false)
                    {
                        projectsfound.Items.Add(project);
                        removed.Add(project);
                    }
                }
            }
            else
            {
                MessageBox.Show("No Projects were Selected.", "Results");
            }

            foreach (string item2 in removed)
            {
                projectsdelete.Items.Remove(item2);
            }
        }
    }
}
