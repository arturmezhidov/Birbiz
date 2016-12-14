using System.Collections.Generic;

namespace Birbiz.Common.Entities
{
    public class Street : BaseEntity
    {
        public string Name { get; set; }

        public virtual City City { get; set; }

        public virtual ICollection<Home> Homes { get; set; } = new HashSet<Home>();
    }
}