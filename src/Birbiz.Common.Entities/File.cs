using System;

namespace Birbiz.Common.Entities
{
    public class File : BaseEntity
    {
        public string Title { get; set; }

        public string FileName { get; set; }

        public string ContentType { get; set; }

        public string Extension { get; set; }

        public int Size { get; set; }

        public bool EnablePublishPeriod { get; set; }

        public int PublishedVersion { get; set; }

        public DateTime PublishedStartDate { get; set; }

        public DateTime? PublishedEndDate { get; set; }

        public string SHA1Hash { get; set; }

        public int FolderId { get; set; }

        public virtual Folder Folder { get; set; }
    }
}