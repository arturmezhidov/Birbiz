using System.Collections.Generic;

namespace Birbiz.Common.Entities
{
    public class City : BaseEntity
    {
        public string Name { get; set; }

        public int RegionId { get; set; }

        public virtual Region Region { get; set; }

        public virtual ICollection<Street> Streets { get; set; } = new HashSet<Street>();
    }
}