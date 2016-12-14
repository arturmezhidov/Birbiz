using System.Collections.Generic;

namespace Birbiz.Common.Entities.Catalog
{
    public class ProductCategory : BaseEntity
    {
        public string DisplayName { get; set; }

        public string FriendlyName { get; set; }

        public string Description { get; set; }

        public virtual ICollection<ProductGroup> Groups { get; set; } = new HashSet<ProductGroup>();
    }
}