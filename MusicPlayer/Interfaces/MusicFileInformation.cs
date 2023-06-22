using System;

public class MusicFileInformation
{
    public string Path { get; }
    public string FileName { get; }
    public DateTime LastModified { get; }
    public long FileSize { get; }
    public byte[] ImageBuffer { get; }
    public string Title { get; }
    public string Description { get; }
    public TimeSpan Duration { get; }
    public string Author { get; }
    public string MediaType { get; }
    public int AudioBitrate { get; }
    public int AudioChannel { get; }

    public MusicFileInformation(string path, string fileName, DateTime lastModified, long fileSize, byte[] imageBuffer,
        string title, string description, TimeSpan duration, string author, string mediaType,
        int audioBitrate, int audioChannel)
    {
        Path = path;
        FileName = fileName;
        LastModified = lastModified;
        FileSize = fileSize;
        ImageBuffer = imageBuffer;
        Title = title;
        Description = description;
        Duration = duration;
        Author = author;
        MediaType = mediaType;
        AudioBitrate = audioBitrate;
        AudioChannel = audioChannel;
    }
}
