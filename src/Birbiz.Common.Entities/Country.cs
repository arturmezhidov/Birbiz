using System.Collections.Generic;

namespace Birbiz.Common.Entities
{
    public class Country : BaseEntity
    {
        public string Name { get; set; }

        public virtual ICollection<Region> Regions { get; set; } = new HashSet<Region>();
    }
}