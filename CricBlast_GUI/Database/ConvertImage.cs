using System.Drawing;
using System.IO;

namespace CricBlast_GUI.Database
{
    public static class ConvertImage
    {
        public static byte[] ToBytes(Image image)
        {
            using (var memoryStream = new MemoryStream())
            {
                try
                {
                    image.Save(memoryStream, image.RawFormat);
                    return memoryStream.GetBuffer();
                }
                catch
                {
                    return null;
                }
            }
        }

        public static Image ToImage(byte[] imageBytes)
        {
            using (var memoryStream = new MemoryStream(imageBytes))
            {
                try
                {
                    return Image.FromStream(memoryStream);
                }
                catch
                {
                    return null;
                }
            }
        }
    }
}
