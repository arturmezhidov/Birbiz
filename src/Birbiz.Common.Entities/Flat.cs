using System.Collections.Generic;

namespace Birbiz.Common.Entities
{
    public class Flat : BaseEntity
    {
        public int Number { get; set; }

        public virtual Home Home { get; set; }

        public virtual ICollection<ProfileUser> Users { get; set; } = new HashSet<ProfileUser>();
    }
}