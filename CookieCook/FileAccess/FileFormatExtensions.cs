public static class FileFormatExtensions
{
    public static string AsFileExtension(this FileFormat format)
    {
        return format == FileFormat.Json ? "json" : "txt";
    }
}


