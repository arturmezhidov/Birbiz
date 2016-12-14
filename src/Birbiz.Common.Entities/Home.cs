using System.Collections.Generic;

namespace Birbiz.Common.Entities
{
    public class Home : BaseEntity
    {
        public int Number { get; set; }

        public string Block { get; set; }

        public double Latitude { get; set; }

        public double Longitude { get; set; }

        public virtual Street Street { get; set; }

        public virtual ICollection<Flat> Flats { get; set; } = new HashSet<Flat>();
    }
}