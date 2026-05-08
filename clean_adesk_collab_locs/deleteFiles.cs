using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace delete_files
{
    //Code to delete the files and folder found in the Revit, Plant, and PacCache folders.
    //The path to the folders is passed in as a string variable from the main form.
    //The Revit paths need to be build base on the Revit version and the user name.
    //The Plant paths need to be build base on the projects selected for deletion and the user name.

    class DeleteFiles
    {
        public static void Revitdelete(string inputFilePath)
        {
            DirectoryInfo deleteFilePath = new DirectoryInfo(inputFilePath);

            FileInfo[] rFiles = deleteFilePath.GetFiles();
            foreach (FileInfo file in rFiles)
            {
                file.Delete();
            }

            DirectoryInfo[] rSubDirectories = deleteFilePath.GetDirectories();
            foreach (DirectoryInfo subDirectory in rSubDirectories)
            {
                subDirectory.Delete(true);
            }
        }

        public static void Plantdelete(string inputFilePath)
        {
            DirectoryInfo deleteFilePath = new DirectoryInfo(inputFilePath);

            //FileInfo[] pFiles = deleteFilePath.GetFiles();

            //foreach (FileInfo file in pFiles)
            //{
            //    file.Delete();
            //}

            foreach (var file in deleteFilePath.GetFiles("*", SearchOption.AllDirectories))
            {
                file.Attributes &= ~FileAttributes.ReadOnly;
                file.Delete();
            }

            DirectoryInfo[] pSubDirectories = deleteFilePath.GetDirectories();
            foreach (DirectoryInfo subDirectory in pSubDirectories)
            {
                subDirectory.Delete(true);
            }
            System.IO.Directory.Delete(inputFilePath, true);
        }

        public static void Pacdelete(string inputFilePath)
        {
            DirectoryInfo pacDeleteFilePath = new DirectoryInfo(inputFilePath);
            FileInfo[] rFiles = pacDeleteFilePath.GetFiles();
            foreach (FileInfo file in rFiles)
            {
                file.Delete();
            }
        }

    }
}
