using System.Collections.Generic;

namespace Birbiz.Common.Entities.Catalog
{
    public class ProductGroup : BaseEntity
    {
        public string DisplayName { get; set; }

        public string FriendlyName { get; set; }

        public string Description { get; set; }

        public virtual ProductCategory Category { get; set; }

        public virtual ICollection<ProductSchema> ProductSchemas { get; set; } = new HashSet<ProductSchema>();
    }
}