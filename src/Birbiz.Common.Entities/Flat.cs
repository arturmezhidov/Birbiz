using System.Collections.Generic;

namespace Birbiz.Common.Entities
{
    public class Flat : BaseEntity
    {
        public int Number { get; set; }

        public int HomeId { get; set; }

        public virtual Home Home { get; set; }
    }
}