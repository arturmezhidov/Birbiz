using System.Collections.Generic;

namespace Birbiz.Common.Entities.Catalog
{
    public class ProductAttributeGroup : BaseEntity
    {
        public string DisplayName { get; set; }

        public string HelpInfo { get; set; }

        public int ProductSchemaId { get; set; }

        public virtual ProductSchema ProductSchema { get; set; }

        public virtual ICollection<ProductAttributeSchema> AttributeSchemas { get; set; } = new HashSet<ProductAttributeSchema>();
    }
}