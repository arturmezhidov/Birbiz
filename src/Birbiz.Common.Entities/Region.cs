using System.Collections.Generic;

namespace Birbiz.Common.Entities
{
    public class Region : BaseEntity
    {
        public string Name { get; set; }

        public int CountryId { get; set; }

        public virtual Country Country { get; set; }

        public virtual ICollection<City> Cities { get; set; } = new HashSet<City>();
    }
}