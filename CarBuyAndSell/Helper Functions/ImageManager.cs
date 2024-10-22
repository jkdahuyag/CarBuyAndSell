using CarBuyAndSell.Properties;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarBuyAndSell.Helper_Functions
{
    public static class ImageManager
    {
        private static string currentDir = Environment.CurrentDirectory;
        private static string imageFolderDir = @"\Images\";
        private static string imagePath = "";

        public static string FileName { get; set; }

        public static string GenerateImagePathFromFileManager()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp; *.png;)|*.jpg; *.jpeg; *.gif; *.bmp; *.png;";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                FileName = openFileDialog.FileName;
                return GenerateImagePathFromName(FileName);
            }
            return "";
        }
        public static string GenerateImagePathFromName(string imageName) 
        { 
            imageFolderDir = Path.Combine(currentDir, @"..\..\Images\");
            imagePath = Path.Combine(imageFolderDir, imageName);
            return imagePath;
        }


    }
}
