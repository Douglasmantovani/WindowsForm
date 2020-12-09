using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;

namespace ConversorDeFotoBinario.Utils
{
    class Conversor
    {
        public byte[] imageToByteArray(System.Drawing.Image imageIn)
        {
            using (var ms = new MemoryStream())
            {
                imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Tiff); //aqui voce troca o formato de arquivo a salvar
                return ms.ToArray();
            }
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
