namespace QRCodeGenerator
{
    internal static class MimeUtility
    {
        public static readonly string[] KnownAudioExtensions = { "ogg", "mp3", "flac", "wav", "m4a" };
        public static readonly string[] KnownVideoExtensions = { "webm", "mp4", "avi", "mkv" };
        public static readonly string[] KnownImageExtensions = { "jpg", "jpeg", "png", "bmp", "webp", "heif", "avif" };

        public static readonly Dictionary<string, string> MimeMap = new()
        {
            { "jpg", "image/jpeg" },
            { "jpeg", "image/jpeg" },
            { "png", "image/png" },
            { "bmp", "image/bmp" },
            { "webp", "image/webp" },
            { "heif", "image/heif" },
            { "avif", "image/avif" },

            { "ogg", "audio/ogg" },
            { "mp3", "audio/mpeg" },
            { "flac", "audio/flac" },
            { "wav", "audio/wav" },
            { "m4a", "audio/mp4" },

            { "webm", "video/webm" },
            { "mp4", "video/mp4" },
            { "avi", "video/x-msvideo" },
            { "mkv", "video/x-matroska" }
        };

        public static string GetMimeMapping(string filename)
        {
            var ext = Path.GetExtension(filename)[1..].ToLower();
            return MimeMap[ext];
        }

    }
}
