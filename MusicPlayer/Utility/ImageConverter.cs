using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

public static class ImageConverter
{
    public static Bitmap ConvertImageBufferToBitmap(byte[] imageBuffer)
    {
        if (imageBuffer == null || imageBuffer.Length == 0)
        {
            //throw new ArgumentException("Invalid image buffer.");
            return MusicPlayer.Properties.Resources.musicListIcon;
        }

        using (MemoryStream memoryStream = new MemoryStream(imageBuffer))
        {
            return new Bitmap(memoryStream);
        }
    }
}
