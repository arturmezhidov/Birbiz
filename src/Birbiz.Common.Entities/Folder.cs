using System.Collections.Generic;

namespace Birbiz.Common.Entities
{
    public class Folder : BaseEntity
    {
        public string FolderPath { get; set; }

        public int? ParentFolderId { get; set; }

        public virtual Folder ParentFolder { get; set; }

        public virtual ICollection<File> Files { get; set; } = new HashSet<File>();
    }
}