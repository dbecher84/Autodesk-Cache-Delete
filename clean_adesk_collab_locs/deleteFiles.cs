using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace delete_files
{
    class DeleteFiles
    {
        public static void Revitdelete(string inputFilePath)
        {
            DirectoryInfo deletetFilePath = new DirectoryInfo(inputFilePath);

            FileInfo[] rFiles = deletetFilePath.GetFiles();
            foreach (FileInfo file in rFiles)
            {
                file.Delete();
            }

            DirectoryInfo[] rSubDirectories = deletetFilePath.GetDirectories();
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

    }
}
