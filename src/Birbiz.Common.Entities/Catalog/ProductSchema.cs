using System.Collections.Generic;

namespace Birbiz.Common.Entities.Catalog
{
    public class ProductSchema : BaseEntity
    {
        public string DisplayName { get; set; }

        public string FriendlyName { get; set; }

        public string Description { get; set; }

        public int GroupId { get; set; }

        public virtual ProductGroup Group { get; set; }

        public virtual ICollection<Product> Products { get; set; } = new HashSet<Product>();

        public virtual ICollection<ProductAttributeGroup> AttributeGroups { get; set; } = new HashSet<ProductAttributeGroup>();
    }
}