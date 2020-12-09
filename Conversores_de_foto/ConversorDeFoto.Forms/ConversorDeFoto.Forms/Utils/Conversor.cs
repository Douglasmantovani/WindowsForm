using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;

namespace ConversorDeFoto.Forms.Utils
{
    class Conversor
    {
        public string imageToByteArray(System.Drawing.Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
            byte[] bite = ms.ToArray();

            string a = Convert.ToBase64String(bite);

            return a;
        }
        public Image Base64ToImage(string base64String)
        {

            byte[] imageBytes = Convert.FromBase64String(base64String);

            MemoryStream ms = new MemoryStream(imageBytes, 0, imageBytes.Length);
            ms.Write(imageBytes, 0, imageBytes.Length);
            Image image = Image.FromStream(ms, true);
            return image;
        }
    }
}
