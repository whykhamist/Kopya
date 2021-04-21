

namespace Kopya
{
    public class FileCopyProgressInfo : ICopyProgressInfo
    {
        /// <summary>
        /// The file name of the file to being copied.
        /// </summary>
        public string FileName { get; set; }

        /// <summary>
        /// The filename including path currently being copied.
        /// </summary>
        public string FullName { get; set; }

        /// <summary>
        /// The Progress (in percentage value) of the copy task.
        /// </summary>
        public double Progress { get; set; }

        /// <summary>
        /// Check if operation has been cancelled
        /// </summary>
        public bool Cancelled { get; set; } = false;

        /// <summary>
        /// The total file size of the file being copied.
        /// </summary>
        public long FileSize { get; set; }

        /// <summary>
        /// The Total size copied from the file.
        /// </summary>
        public long FileSizeCopied { get; set; }
    }
}
