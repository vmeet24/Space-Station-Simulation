using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Payload.Utility
{
    internal class ImageUtil
    {
        //This method will be called by the application to get Thumbnail  
        public static Stream GetThumbnail(int fileNo)
        {
            try
            {
                string ImagesDirectory = Path.Combine(
                                            Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location),
                                            "Assets");
                Image imgThumb = null;
                Image img = Image.FromFile($"{ImagesDirectory}/Images/img{fileNo}.jpg");
                imgThumb = CreateThumbnail(img, 200, 200);
                var stream = ToStream(imgThumb, ImageFormat.Jpeg);
                return stream;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //This method will generate thumbanail of 100 x 100   
        private static Image CreateThumbnail(Image image, int thumbWidth, int thumbHeight)
        {
            try
            {
                return image.GetThumbnailImage(
                thumbWidth,
                thumbHeight,
                delegate ()
                {
                    return false;
                },
                IntPtr.Zero);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //Method to convert image in stream  
        private static Stream ToStream(Image image, ImageFormat formaw)
        {
            try
            {
                var stream = new MemoryStream();
                image.Save(stream, formaw);
                stream.Position = 0;
                return stream;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
