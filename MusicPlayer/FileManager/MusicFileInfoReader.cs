using System;
using System.IO;
using TagLib;

public class MusicFileInfoReader
{
    public static MusicFileInformation GetMusicFileInformation(string filePath)
    {
        if (!System.IO.File.Exists(filePath))
        {
            throw new FileNotFoundException("File not found.", filePath);
        }

        // Get basic file information
        string fileName = Path.GetFileName(filePath);
        DateTime lastModified = System.IO.File.GetLastWriteTime(filePath);
        long fileSize = new FileInfo(filePath).Length;

        // Load the file using TagLib
        TagLib.File tagFile = TagLib.File.Create(filePath);

        // Extract the music file information
        byte[] imageBuffer = GetImageBuffer(tagFile); // Extract image buffer
        string title = tagFile.Tag.Title; // Extract title
        string description = tagFile.Tag.Comment; // Extract description
        TimeSpan duration = tagFile.Properties.Duration; // Extract duration
        string author = tagFile.Tag.FirstPerformer; // Extract author
        string mediaType = tagFile.MimeType; // Extract media type
        int audioBitrate = tagFile.Properties.AudioBitrate; // Extract audio bitrate
        int audioChannel = tagFile.Properties.AudioChannels; // Extract audio channel count

        MusicFileInformation fileInfo = new MusicFileInformation(filePath, fileName, lastModified, fileSize,
            imageBuffer, title, description, duration, author, mediaType, audioBitrate, audioChannel);

        // Dispose the TagLib file object
        tagFile.Dispose();

        return fileInfo;
    }

    // Extract the image buffer from the TagLib file
    private static byte[] GetImageBuffer(TagLib.File tagFile)
    {
        IPicture[] pictures = tagFile.Tag.Pictures;
        if (pictures.Length > 0)
        {
            IPicture picture = pictures[0];
            return picture.Data.Data;
        }

        return null;
    }
    public static string FormatDuration(TimeSpan duration)
    {
        return string.Format("{0:D2}:{1:D2}", (int)duration.TotalMinutes, duration.Seconds);
    }

}
