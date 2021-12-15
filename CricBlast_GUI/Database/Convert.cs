using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CricBlast_GUI.Database
{
    public static class Convert
    {
        public static byte[] toBytes(Image image)
        {
            using (var memoryStream = new MemoryStream())
            {
                image.Save(memoryStream, image.RawFormat);
                return memoryStream.GetBuffer();
            }
        }

        public static Image toImage(byte[] imageBytes)
        {
            using (var memoryStream = new MemoryStream(imageBytes))
                return Image.FromStream(memoryStream);
        }
    }
}
