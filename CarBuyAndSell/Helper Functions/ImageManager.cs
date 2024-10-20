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
    public class ImageManager
    {
        private string currentDir = Environment.CurrentDirectory;
        private string imageFolderDir = @"\Images\";
        private string imagePath = "";
        // create functions to read and write images from file path
        public ImageManager() { }
        public string GenerateImagePathFromFileManager()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp; *.avif;)|*.jpg; *.jpeg; *.gif; *.bmp; *.avif;";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                return GenerateImagePathFromName(openFileDialog.FileName);
            }
            return "";
        }
        public string GenerateImagePathFromName(string imageName) 
        { 
            imageFolderDir = Path.Combine(currentDir, @"../../Images\");
            imagePath = Path.Combine(imageFolderDir, imageName);
            return imagePath;
        }


    }
}
